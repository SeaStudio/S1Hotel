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
    public partial class BusinessInquiries : CCSkinMain
    {
        //应用DBHelper类
        private DBHelper db = new DBHelper();
        public BusinessInquiries()
        {
            InitializeComponent();
        }

        private void BusinessInquiries_Load(object sender, EventArgs e)
        {
            Win32.AnimateWindow(this.Handle, 300, Win32.AW_CENTER | Win32.AW_ACTIVATE | Win32.AW_SLIDE);
            //    tpKaiShi.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            //    //tpJieShu.Value = DateTime.Now.Date.AddMonths(1).AddDays(-DateTime.Now.Day);
            ZaiRu();
            //计算房间营收
            if (dgvFangJian.Rows.Count > 0)
            {
                double aa = 0;
                double bb = 0;
                for (int i = 0; i < dgvFangJian.Rows.Count; i++)
                {
                    aa += Convert.ToDouble(dgvFangJian.Rows[i].Cells[1].Value.ToString());
                    bb += Convert.ToDouble(dgvFangJian.Rows[i].Cells[2].Value.ToString());
                }
                textXingJin.Text = aa.ToString();
                textYuE.Text = bb.ToString();
            }
            //计算商品营收
            if (dgvShangPing.Rows.Count > 0)
            {
                double aa = 0;
                for (int i = 0; i < dgvShangPing.Rows.Count; i++)
                {
                    aa += Convert.ToDouble(dgvShangPing.Rows[i].Cells[1].Value.ToString());
                }
                textShangPing.Text = aa.ToString();
            }
            //计算充值营收
            if (dgvChongZhi.Rows.Count > 0)
            {
                double aa = 0;
                for (int i = 0; i < dgvChongZhi.Rows.Count; i++)
                {
                    aa += Convert.ToDouble(dgvChongZhi.Rows[i].Cells[1].Value.ToString());
                }
                textChongZhi.Text = aa.ToString();
            }
            if (dgvZhiChu.Rows.Count > 0)
            {
                double aa = 0;
                for (int i = 0; i < dgvZhiChu.Rows.Count; i++)
                {
                    aa += Convert.ToDouble(dgvZhiChu.Rows[i].Cells[1].Value.ToString());
                }
                txtZhiChu.Text = aa.ToString();
            }
        }

        private void ZaiRu()
        {
            dgvFangJian.AutoGenerateColumns = false;
            //查询所有订单
            try
            {
                ChongZhi();

                string sql = string.Format(@"select * from [dbo].[CheckoutTable]");
                DataSet ds = db.GetDataSet(sql, "FangJian");
                dgvFangJian.DataSource = ds.Tables["FangJian"];

                sql = string.Format(@"select *
                                        from[dbo].[MerchandiseOrderTable]");
                DataSet dss = db.GetDataSet(sql, "ShangPin");
                dgvShangPing.DataSource = dss.Tables["ShangPin"];

                string sqlzss = string.Format(@"select *
                                            from Expenditure");
                DataSet dsss = db.GetDataSet(sqlzss, "ZhiChu");
                dgvZhiChu.DataSource = dsss.Tables["ZhiChu"];
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
        public void ChongZhi()//充值记录
        {
            string sql = string.Format(@"select * from CustomerRecharge");
            DataSet ds = db.GetDataSet(sql, "FangJian");
            dgvChongZhi.DataSource = ds.Tables["FangJian"];
        }
        private void skinLabel2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ChaXun();
        }

        private void ChaXun()
        {
            try
            {
                //查询在时间内的。
                string sql = string.Format(@"select * from [dbo].[CheckoutTable] where CheckoutTime > '{0}' and CheckoutTime < '{1}'"
                    , tpKaiShi.Value, tpJieShu.Value);
                DataSet ds = db.GetDataSet(sql, "FangJian");
                dgvFangJian.DataSource = ds.Tables["FangJian"];

                sql = string.Format(@"select *
                                        from[dbo].[MerchandiseOrderTable] where OrderTable > '{0}' and OrderTable < '{1}'", tpKaiShi.Value, tpJieShu.Value);
                DataSet dss = db.GetDataSet(sql, "ShangPin");
                dgvShangPing.DataSource = dss.Tables["ShangPin"];

                if ((ds == null) || (ds.Tables.Count == 0))
                {
                    dgvFangJian.Rows.Clear();
                }
                if ((dss == null) || (dss.Tables.Count == 0))
                {
                    dgvShangPing.Rows.Clear();
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

        private void tpJieShu_ValueChanged(object sender, EventArgs e)
        {
            ChaXun();
        }

        private void 查看详细信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetailedInformation di = new DetailedInformation();
            di.ShowDialog();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            
            StatisticalChart sc = new StatisticalChart();
            sc.fangJian = Convert.ToInt32(textXingJin.Text) + Convert.ToInt32(textYuE.Text);
            sc.chongZhi = Convert.ToInt32(textChongZhi.Text);
            if (sc.shangPing !=0)
            {
                sc.shangPing = Convert.ToInt32(textShangPing.Text);
            }
            DateTime dt1 = Convert.ToDateTime(tpKaiShi.Text);
            DateTime dt2 = Convert.ToDateTime(tpJieShu.Text);
            TimeSpan ts1 = dt2.Subtract(dt1);
            sc.tian = ts1.Days;
            sc.YinLi = Convert.ToDouble(txtZhiChu.Text);
            sc.ShowDialog();
        }

        private void BusinessInquiries_FormClosing(object sender, FormClosingEventArgs e)
        {
            Win32.AnimateWindow(this.Handle, 300, Win32.AW_CENTER | Win32.AW_HIDE | Win32.AW_SLIDE);
        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            Expenditure ed = new Expenditure();
            ed.ShowDialog();
            ZaiRu();
        }
    }
}
