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
    public partial class ExchangeHouses : CCSkinMain
    {
        public string CaoZuoYuan { get; set; }
        public string FangHao { get; set; }
        //调用DBHelper类
        private DBHelper db = new DBHelper();
        public ExchangeHouses()
        {
            InitializeComponent();
        }

        private void ExchangeHouses_Load(object sender, EventArgs e)
        {

            //载入房间
            try
            {
                //载入待客房间表表及价格
                string sql = string.Format(@"select  RoomTable.RoomID,RoomTable.Floor,RoomTypeTable.TypeName,RoomTypeTable.Price,RoomStateTable.StateName
                                                from RoomTable
                                                inner join RoomStateTable
                                                on RoomTable.StateID = RoomStateTable.ID
                                                inner join RoomTypeTable
                                                on RoomTable.TypeID = RoomTypeTable.ID where RoomStateTable.ID =2");
                DataSet ds = db.GetDataSet(sql, "FangJian");
                cbYuanFang.DataSource = ds.Tables["FangJian"];
                cbYuanFang.ValueMember = "RoomID";
                cbYuanFang.DisplayMember = "RoomID";
                cbYuanJia.DataSource = ds.Tables["FangJian"];
                cbYuanJia.DisplayMember = "Price";

                //载入空净房间表及价格
                sql = string.Format(@"select  RoomTable.RoomID,RoomTable.Floor,RoomTypeTable.TypeName,RoomTypeTable.Price,RoomStateTable.StateName
                                                from RoomTable
                                                inner join RoomStateTable
                                                on RoomTable.StateID = RoomStateTable.ID
                                                inner join RoomTypeTable
                                                on RoomTable.TypeID = RoomTypeTable.ID where RoomStateTable.ID =1");
                DataSet dss = db.GetDataSet(sql, "XinFangJian");
                cbXingFang.DataSource = dss.Tables["XinFangJian"];
                cbXingFang.ValueMember = "RoomID";
                cbXingFang.DisplayMember = "RoomID";
                cbXinJia.DataSource = dss.Tables["XinFangJian"];
                cbXinJia.DisplayMember = "Price";
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            cbYuanFang.Text = FangHao;
        }

        private void skinLabel6_Click(object sender, EventArgs e)
        {

        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbXingFang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbYuanFang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string DingDanHao;
        private void skinButton3_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format(@"select *
                                            from OrderTable
                                    where RoomID='{0}' and State='新开单'", cbYuanFang.Text);
                SqlDataReader dr = db.SelectDataReader(sql);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        DingDanHao = dr["OrderID"].ToString();
                        tbRuZhu.Text = dr["CheckInTime"].ToString();
                        tbYiJiao.Text = dr["AmountReceived"].ToString();
                        DateTime dt = Convert.ToDateTime(dr["PreDepartureTime"].ToString());
                        tpYuLi.Value = dt;
                        tbBeiZhu.Text = dr["Remarks"].ToString();
                        if (dr["CustomerType"].ToString() != "普通用户")
                        {
                            tbChaJia.Text = "会员免费换同类房";
                        }
                        else
                        {
                            tbChaJia.Text = "";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("该房间处于未入住状态","提示");
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
            //计算不同类房间换房
            if (cbXinJia.Text != cbYuanJia.Text)
            {
                TimeSpan ts = tpYuLi.Value - DateTime.Now;
                if (ts.Days > 2)
                {
                    tbChaJia.Text = (ts.Days * Convert.ToDouble(cbXinJia.Text) - Convert.ToDouble(cbYuanJia.Text)).ToString();
                }
                else if (ts.Days > 1)
                {
                    tbChaJia.Text = ((ts.Days + 1) * Convert.ToDouble(cbXinJia.Text) - Convert.ToDouble(cbYuanJia.Text)).ToString();
                }
                else
                {
                    tbChaJia.Text = (Convert.ToDouble(cbXinJia.Text) - Convert.ToDouble(cbYuanJia.Text)).ToString();
                }
            }
            else
            {
                tbChaJia.Text = "0";
            }

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (tbRuZhu.Text == "")
            {
                MessageBox.Show("请却无换房无误后执行！","提示");
                return;
            }
            try
            {
                string sqlxs = string.Format(@"update CheckInTable set RoomID='{0}'
                                                            where RoomID='{1}'", cbXingFang.Text, cbYuanFang.Text);
                db.ExecuteSQLCommand(sqlxs);
                //修改原房状态
                string sql = string.Format(@"update RoomTable set StateID = 3
                                                    where RoomID = '{0}'", cbYuanFang.Text);
                db.ExecuteSQLCommand(sql);
                //修改房卡
                string sqlx = string.Format(@"update RoomIDCard set RoomID ='{0}'
                                                             where RoomID = '{1}'", cbXingFang.Text, cbYuanFang.Text);
                db.ExecuteSQLCommand(sqlx);
                //修改新房状态
                sql = string.Format(@"update RoomTable set StateID = 2
                                                    where RoomID = '{0}'", cbXingFang.Text);
                db.ExecuteSQLCommand(sql);
                //修改订单表

                string sqls = string.Format(@"update OrderTable set RoomID = '{0}',CompanyName+={1},AmountReceived+={1}
                                                where RoomID='{2}'", cbXingFang.Text, Convert.ToInt32(tbChaJia.Text), cbYuanFang.Text);
                if (db.ExecuteSQLCommand(sqls) > 0)
                {
                    string aasc = string.Format("{0}房间已换到{1}房间", cbYuanFang.Text, cbXingFang.Text);
                    MessageBox.Show(aasc);
                    this.Close();
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
