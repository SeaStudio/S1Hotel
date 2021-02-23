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
using System.Windows.Forms.DataVisualization.Charting;
using CCWin;

namespace S1Hotel
{
    public partial class StatisticalChart : CCSkinMain
    {
        private DBHelper db = new DBHelper();
        public int fangJian { get; set; }
        public int shangPing { get; set; }
        public int chongZhi { get; set; }
        public int tian { get; set; }
        public double YinLi { get; set; }
        public StatisticalChart()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            JiSuan();
            chart1.Titles.Add("营收统计（占比）"); //添加标题
            chart1.Series["Series1"].Label = "#PERCENT{P}";
            chart1.Series["Series1"].LegendText = "#VALX";

            chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
            chart1.Series[0].ChartType = SeriesChartType.Pie;
            List<string> xData = new List<string>() { "房间营收", "商品营收", "充值营收" };
            List<int> yData = new List<int>() { fangJian, shangPing, chongZhi };
            chart1.Series[0].Points.DataBindXY(xData, yData);
            cbYue.Text = "01";

        }

        private void JiSuan()
        {
            if (textMuBiao.Text == "")
            {
                return;
            }
            try
            {
                textFangJian.Text = fangJian.ToString();
                textChongZhi.Text = chongZhi.ToString();
                textShangPing.Text = shangPing.ToString();
                textHeJi.Text = (fangJian + shangPing + chongZhi).ToString();
                txtYinLi.Text = ((fangJian + shangPing + chongZhi) - YinLi).ToString();
                if ((fangJian + shangPing + chongZhi) <= Convert.ToInt32(textMuBiao.Text))
                {
                    pbDaChengLv.Maximum = Convert.ToInt32(textMuBiao.Text);
                    pbDaChengLv.Value = (fangJian + shangPing + chongZhi);
                    textRiMuBiao.Text = (Convert.ToDouble(textMuBiao.Text) / tian).ToString();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }



        }
        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void skinRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ChaXun();
        }

        private void ChaXun()
        {
            if (rbNian.Checked)
            {
                int aa = Convert.ToInt32(textNian.Text);
                chart2.Titles.Clear();
                chart2.Series.Clear();
                chart2.Titles.Add("按年营收统计"); //添加标题
                Series s1 = new Series("房间营收");
                Series s2 = new Series("商品营收");
                Series s3 = new Series("充值营收");
                //绑定数据
                Random r = new Random();
                for (int i = aa - 3; i < aa + 1; i++)
                {
                    try
                    {
                        string sql = string.Format(@"select sum(TotalCost+BalancePayment),year(CheckoutTime)
                                        from [dbo].[CheckoutTable]
                                        group by year(CheckoutTime)");
                        SqlDataReader dr = db.SelectDataReader(sql);
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                if (dr[1].ToString() == i.ToString())
                                {
                                    double a = Convert.ToDouble(dr[0].ToString());
                                    s1.Points.AddXY(i, a);
                                }
                            }
                        }
                        s1.Points.AddXY(i, 0);
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                    finally
                    {
                        db.CloseConnection();
                    }
                    try
                    {
                        string sql = string.Format(@"select sum(CollectMoney),year(OrderTable)
                                                        from[dbo].[MerchandiseOrderTable]
                                                        group by year(OrderTable)");
                        SqlDataReader dr = db.SelectDataReader(sql);
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                if (dr[1].ToString() == i.ToString())
                                {
                                    double a = Convert.ToDouble(dr[0].ToString());
                                    s2.Points.AddXY(i, a);
                                }
                            }
                        }
                        s2.Points.AddXY(i, 0);
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                    finally
                    {
                        db.CloseConnection();
                    }
                    try
                    {
                        string sql = string.Format(@"select sum(RechargeAmount),year(RechargeTime)
                                                     from[dbo].[CustomerRecharge]
                                                     group by year(RechargeTime)");
                        SqlDataReader dr = db.SelectDataReader(sql);
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                if (dr[1].ToString() == i.ToString())
                                {
                                    double a = Convert.ToDouble(dr[0].ToString());
                                    s3.Points.AddXY(i, a);
                                }
                            }
                        }
                        s3.Points.AddXY(i, 0);
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
                //加入到chart1中
                chart2.Series.Add(s1);
                chart2.Series.Add(s2);
                chart2.Series.Add(s3);
            }
            else if (rbYue.Checked)
            {
                chart2.Titles.Clear();
                chart2.Series.Clear();
                chart2.Titles.Add("2021年 按月营收统计"); //添加标题
                Series s1 = new Series("房间营收");
                Series s2 = new Series("商品营收");
                Series s3 = new Series("充值营收");
                //绑定数据
                Random r = new Random();
                for (int i = 1; i < 13; i++)
                {
                    try
                    {
                        string sql = string.Format(@"select sum(TotalCost+BalancePayment),month(CheckoutTime)
                                        from [dbo].[CheckoutTable]
                                        group by month(CheckoutTime)");
                        SqlDataReader dr = db.SelectDataReader(sql);
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                if (dr[1].ToString() == i.ToString())
                                {
                                    double a = Convert.ToDouble(dr[0].ToString());
                                    s1.Points.AddXY(i, a);
                                }
                            }
                        }
                        s1.Points.AddXY(i, 0);
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                    finally
                    {
                        db.CloseConnection();
                    }
                    try
                    {
                        string sql = string.Format(@"select sum(CollectMoney),month(OrderTable)
                                                        from[dbo].[MerchandiseOrderTable]
                                                        group by month(OrderTable)");
                        SqlDataReader dr = db.SelectDataReader(sql);
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                if (dr[1].ToString() == i.ToString())
                                {
                                    double a = Convert.ToDouble(dr[0].ToString());
                                    s2.Points.AddXY(i, a);
                                }
                            }
                        }
                        s2.Points.AddXY(i, 0);
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                    finally
                    {
                        db.CloseConnection();
                    }
                    try
                    {
                        string sql = string.Format(@"select sum(RechargeAmount),month(RechargeTime)
                                                 from[dbo].[CustomerRecharge]
                                                 group by month(RechargeTime)");
                        SqlDataReader dr = db.SelectDataReader(sql);
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                if (dr[1].ToString() == i.ToString())
                                {
                                    double a = Convert.ToDouble(dr[0].ToString());
                                    s3.Points.AddXY(i, a);
                                }
                            }
                        }
                        s3.Points.AddXY(i, 0);
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
                //加入到chart1中
                chart2.Series.Add(s1);
                chart2.Series.Add(s2);
                chart2.Series.Add(s3);
                // chart2.Series.RemoveAt(0); //移除多余的图列
            }
            else
            {
                chart2.Series.Clear();
                chart2.Titles.Clear();
                chart2.Titles.Add("2021年 按日营收统计" + cbYue.Text + "月"); //添加标题
                Series s1 = new Series("房间营收");
                Series s2 = new Series("商品营收");
                Series s3 = new Series("充值营收");
                //绑定数据
                Random r = new Random();
                for (int i = 1; i < 32; i++)
                {
                    try
                    {
                        string sql = string.Format(@"select sum(TotalCost+BalancePayment),day(CheckoutTime)
                                                          from [dbo].[CheckoutTable]
                                                          where CheckoutTime like '{0}-{1}%'
                                                         group by day(CheckoutTime)", textNian.Text, cbYue.Text);
                        SqlDataReader dr = db.SelectDataReader(sql);
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                if (dr[1].ToString() == i.ToString())
                                {
                                    double a = Convert.ToDouble(dr[0].ToString());
                                    s1.Points.AddXY(i, a);
                                }
                            }
                        }
                        s1.Points.AddXY(i, 0);
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                    finally
                    {
                        db.CloseConnection();
                    }
                    try
                    {
                        string sql = string.Format(@"select sum(CollectMoney),day(OrderTable)
                                                        from[dbo].[MerchandiseOrderTable]
                                                        where OrderTable like '{0}-{1}%'
                                                        group by day(OrderTable)", textNian.Text, cbYue.Text);
                        SqlDataReader dr = db.SelectDataReader(sql);
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                if (dr[1].ToString() == i.ToString())
                                {
                                    double a = Convert.ToDouble(dr[0].ToString());
                                    s2.Points.AddXY(i, a);
                                }
                            }
                        }
                        s2.Points.AddXY(i, 0);
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                    finally
                    {
                        db.CloseConnection();
                    }
                    try
                    {
                        string sql = string.Format(@"select sum(RechargeAmount),day(RechargeTime)
                                         from[dbo].[CustomerRecharge]
                                         where RechargeTime like '{0}-{1}%'
                                         group by day(RechargeTime)", textNian.Text, cbYue.Text);
                        SqlDataReader dr = db.SelectDataReader(sql);
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                if (dr[1].ToString() == i.ToString())
                                {
                                    double a = Convert.ToDouble(dr[0].ToString());
                                    s3.Points.AddXY(i, a);
                                }
                            }
                        }
                        s3.Points.AddXY(i, 0);
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
                //加入到chart1中
                chart2.Series.Add(s1);
                chart2.Series.Add(s2);
                chart2.Series.Add(s3);
            }
        }

        private void skinGroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void rbNian_CheckedChanged(object sender, EventArgs e)
        {
            ChaXun();
        }

        private void rbRi_CheckedChanged(object sender, EventArgs e)
        {
            ChaXun();
        }

        private void cbYue_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChaXun();
        }

        private void textMuBiao_TextChanged(object sender, EventArgs e)
        {
            JiSuan();
        }
    }
}
