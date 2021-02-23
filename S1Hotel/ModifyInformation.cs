using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using CCWin;
namespace S1Hotel
{
    public partial class ModifyInformation : CCSkinMain
    {
        //调用DBHelper类
        private DBHelper db = new DBHelper();
        public ModifyInformation()
        {
            InitializeComponent();
        }

        private void ModifyInformation_Load(object sender, EventArgs e)
        {
            try
            {
                //载入房间号码
                string sql = string.Format(@"select  *
                                                from RoomTable
                                                inner join RoomStateTable
                                                on RoomTable.StateID = RoomStateTable.ID
                                                inner join RoomTypeTable
                                                on RoomTable.TypeID = RoomTypeTable.ID");
                DataSet ds = db.GetDataSet(sql, "FangJiaBiao");
                cbFangHao.DataSource = ds.Tables["FangJiaBiao"];
                cbFangHao.ValueMember = "RoomID";
                cbFangHao.DisplayMember = "RoomID";

                //载入房间状态
                string sqls = string.Format(@"select *
                                                  from RoomStateTable");
                DataSet dss = db.GetDataSet(sqls, "ZhuangTai");
                cbZhuangTaii.DataSource = dss.Tables["ZhuangTai"];
                cbZhuangTaii.ValueMember = "ID";
                cbZhuangTaii.DisplayMember = "StateName";

                //载入房间类型
                sql = string.Format(@"select *
                                            from RoomTypeTable");

                DataSet dsss = db.GetDataSet(sql, "LeiXing");

                cbLeiXing.DataSource = dsss.Tables["LeiXing"];
                cbLeiXing.ValueMember = "ID";
                cbLeiXing.DisplayMember = "TypeName";
                cbJiaGe.DataSource = dsss.Tables["LeiXing"];
                cbJiaGe.ValueMember = "ID";
                cbJiaGe.DisplayMember = "Price";

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            //载入房间信息
            if (cbFangHao.Text != "")
            {
                try
                {
                    string sql = string.Format(@"select  RoomTable.RoomID,RoomTable.Floor,RoomTypeTable.TypeName,RoomTypeTable.Price,RoomStateTable.StateName
                                                from RoomTable
                                                inner join RoomStateTable
                                                on RoomTable.StateID = RoomStateTable.ID
                                                inner join RoomTypeTable
                                                on RoomTable.TypeID = RoomTypeTable.ID where RoomID ='{0}'", cbFangHao.Text);
                    SqlDataReader dr = db.SelectDataReader(sql);
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            tbLouCeng.Text = dr["FLOOR"].ToString();
                            cbZhuangTaii.Text = dr["StateName"].ToString();
                        }
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

        private void skinButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            ReviseThePrice rtp = new ReviseThePrice();
            rtp.ShowDialog();
        }

        private void cbFangHao_SelectedIndexChanged(object sender, EventArgs e)
        {
            //载入房间信息
            if (cbFangHao.Text != "")
            {
                try
                {
                    string sql = string.Format(@"select  RoomTable.RoomID,RoomTable.Floor,RoomTypeTable.TypeName,RoomTypeTable.Price,RoomStateTable.StateName
                                                from RoomTable
                                                inner join RoomStateTable
                                                on RoomTable.StateID = RoomStateTable.ID
                                                inner join RoomTypeTable
                                                on RoomTable.TypeID = RoomTypeTable.ID where RoomID ='{0}'", cbFangHao.Text);
                    SqlDataReader dr = db.SelectDataReader(sql);
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            tbLouCeng.Text = dr["FLOOR"].ToString();
                            cbZhuangTaii.Text = dr["StateName"].ToString();
                        }
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

        private void skinButton2_Click(object sender, EventArgs e)
        {
            DialogResult aa;
            if (cbZhuangTaii.Text == "待客")
            {
                aa = MessageBox.Show("待客房间不建议修改！", "慎重！", MessageBoxButtons.OKCancel);
                if (aa == DialogResult.Cancel)
                {
                    return;
                }
            }

            try
            {
                string sql = string.Format(@"update RoomTable set  Floor='{0}', TypeID='{1}', StateID='{2}'
                                            where RoomID ='{3}'", tbLouCeng.Text, cbLeiXing.SelectedValue.ToString(), cbZhuangTaii.SelectedValue.ToString(), cbFangHao.Text);
                if (db.ExecuteSQLCommand(sql) > 0)
                {
                    string aaac = string.Format("{0}房间修改成功", cbFangHao.Text);
                    MessageBox.Show(aaac);
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
            this.Close();
        }
    }
}
