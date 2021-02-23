using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;

namespace S1Hotel
{
    public partial class PredeterminedManagement : CCSkinMain
    {
        private DBHelper db = new DBHelper();
        public PredeterminedManagement()
        {
            InitializeComponent();
        }

        private void PredeterminedManagement_Load(object sender, EventArgs e)
        {
            ChaXun();
        }

        private void ChaXun()
        {
            try
            {
                string sql = string.Format(@"select  *
                  from  PredeterminedTable");
                if (txtXingMing.Text != "")
                {
                    sql = string.Format(@"select  *
                  from  PredeterminedTable where Name like '{0}%'", txtXingMing.Text);
                }
                if (cbZhuangTai.Text != "")
                {
                    sql = string.Format(@"select  *
                  from  PredeterminedTable where Type = '{0}'", cbZhuangTai.Text);
                }
                DataSet set = db.GetDataSet(sql, "BBC");
                dgvDingDan.DataSource = set.Tables["BBC"];
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void 预定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrepaidRoom pr = new PrepaidRoom();
            pr.ShowDialog();
            ChaXun();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            ChaXun();
        }
        private void tpShiJian_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format(@"select  *
                from  PredeterminedTable where PreconditioningTime like '{0}%'", tpShiJian.Text);

                DataSet set = db.GetDataSet(sql, "BBC");
                dgvDingDan.DataSource = set.Tables["BBC"];
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 入住ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDingDan.SelectedRows.Count > 0)
            {
                DateTime dt1 = Convert.ToDateTime(dgvDingDan.SelectedRows[0].Cells[5].Value.ToString());
                DateTime dt2 = DateTime.Now;
                TimeSpan ts = dt1 - dt2;
                if (ts.Hours >= 12 || ts.Days > 0)
                {
                    MessageBox.Show("提早的太久了！","提示");
                    return;
                }
                if ((dgvDingDan.SelectedRows[0].Cells[9].Value.ToString() != ("预定中")))
                {
                    MessageBox.Show("抱歉！不是预定中状态不能入住！","提示");
                    return;
                }
                BulkGuestOpening bk = new BulkGuestOpening();
                bk.YuDingDan = dgvDingDan.SelectedRows[0].Cells[0].Value.ToString();
                if (bk.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string sql = string.Format(@"update PredeterminedTable set Type ='已入住'
                                                    where reservationNumber = '{0}'", dgvDingDan.SelectedRows[0].Cells[0].Value.ToString());
                        db.ExecuteSQLCommand(sql);
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                    finally
                    {
                        db.CloseConnection();
                    }
                    ChaXun();
                }
            }

        }

        private void dgvDingDan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 修改信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDingDan.SelectedRows.Count > 0)
            {
                if (!(dgvDingDan.SelectedRows[0].Cells[9].Value.ToString().Equals("预定中")))
                {
                    MessageBox.Show("非预定中的房间不能修改！","提示");
                    return;
                }
                PredefinedModification pm = new PredefinedModification();
                pm.FangHao = dgvDingDan.SelectedRows[0].Cells[3].Value.ToString();
                pm.XingMing = dgvDingDan.SelectedRows[0].Cells[1].Value.ToString();
                pm.DianHua = dgvDingDan.SelectedRows[0].Cells[2].Value.ToString();
                pm.BeiZhu = "无";
                pm.YuZhu = dgvDingDan.SelectedRows[0].Cells[5].Value.ToString();
                pm.YuLi = dgvDingDan.SelectedRows[0].Cells[6].Value.ToString();
                pm.ShowDialog();
                ChaXun();
            }
        }

        private void skinComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChaXun();
        }

        private void 取消预订ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDingDan.SelectedRows.Count == 0)
            {
                return;
            }
            if (!(dgvDingDan.SelectedRows[0].Cells[9].Value.ToString().Equals("预定中")))
            {
                MessageBox.Show("抱歉！非预定中的房间不能取消！","提示");
                return;
            }
            try
            {
                string sql = string.Format(@"update [dbo].[PredeterminedTable] set Type = '取消预定'
                                                where reservationNumber = '{0}' and RoomID ='{1}'", dgvDingDan.SelectedRows[0].Cells[0].Value.ToString(), dgvDingDan.SelectedRows[0].Cells[3].Value.ToString());
                if (db.ExecuteSQLCommand(sql) > 0)
                {
                    MessageBox.Show("预订取消成功！","提示");
                    ChaXun();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }
    }
}
