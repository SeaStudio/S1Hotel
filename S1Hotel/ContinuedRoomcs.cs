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
    public partial class ContinuedRoomcs : CCSkinMain
    {
        //调用用DBHelper类
        private DBHelper db = new DBHelper();
        public string FangHao { get; set; }
        public ContinuedRoomcs()
        {
            InitializeComponent();
        }

        private void ContinuedRoomcs_Load(object sender, EventArgs e)
        {
            ZaiRu();
            DateTime dts = Convert.ToDateTime(tbYuanYuLi.Text);
            //预离时间自动加一天
            string temp = dts.AddDays(1).ToShortDateString() + " 12:00";
            tpXinYuLi.Text = temp;
        }
        /// <summary>
        /// 载入
        /// </summary>
        private void ZaiRu()
        {
            lbFangHao.Text = FangHao;
            try
            {
                //载入原预离时间和入住时间
                string sql = string.Format(@"select *
                                            from OrderTable
                                            where RoomID ='{0}' and State='新开单'", lbFangHao.Text);
                SqlDataReader dr = db.SelectDataReader(sql);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        tbRuZhuShiJian.Text = dr["CheckInTime"].ToString();
                        tbYuanYuLi.Text = dr["PreDepartureTime"].ToString();
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

            try
            {
                //载入房间的价格
                string sql = string.Format(@"select  RoomTable.RoomID,RoomTable.Floor,RoomTypeTable.TypeName,RoomTypeTable.Price,RoomStateTable.StateName
                                                from RoomTable
                                                inner join RoomStateTable
                                                on RoomTable.StateID = RoomStateTable.ID
                                                inner join RoomTypeTable
                                                on RoomTable.TypeID = RoomTypeTable.ID
												where RoomStateTable.ID=2 and RoomTable.RoomID='{0}'", lbFangHao.Text);
                SqlDataReader dr = db.SelectDataReader(sql);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        tbJiaGe.Text = dr["Price"].ToString();
                        tbChaJia.Text = dr["Price"].ToString();
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

        private void TpXinYuLi_ValueChanged(object sender, EventArgs e)
        {
            if (tpXinYuLi.Value < Convert.ToDateTime(tbYuanYuLi.Text))
            {
                MessageBox.Show("预离时间不能小于原预离时间！");
                return;
            }
            //按天数计算差价
            DateTime dt1 = tpXinYuLi.Value;
            DateTime dt2 = Convert.ToDateTime(tbYuanYuLi.Text);
            TimeSpan ss = dt1 - dt2;
            int tian = 0;
            tian = ss.Days;
            if (ss.Hours > 6)
            {
                tian++;
            }
            double qian = Convert.ToDouble(tbJiaGe.Text) * (tian);
            tbChaJia.Text = qian.ToString();
            YiChuFangJian();
        }
        public void YiChuFangJian()
        {
            DateTime dt3 = Convert.ToDateTime(tbRuZhuShiJian.Text);
            //预定的房间
            try
            {
                string sql = string.Format(@"select *
                                        from [dbo].[PredeterminedTable]
                                        where RoomID = '{0}' and Type ='预定中'", lbFangHao.Text);
                SqlDataReader dr = db.SelectDataReader(sql);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        DateTime dt1 = Convert.ToDateTime(dr["PreconditioningTime"].ToString());
                        DateTime dt2 = Convert.ToDateTime(dr["PreDepartureTime"].ToString());
                        if (db.CalcTimeOverlap(dt3, tpXinYuLi.Value, dt1, dt2))
                        {
                            string ssc = string.Format("该房间在{0}-{1}时间段被预定!", dt1.ToString(), dt2.ToString());
                            MessageBox.Show(ssc); ;//移除时间冲突的代码！
                            this.Close();
                        }
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
            //                    //入住的房间
            //                    try
            //                    {
            //                        string sql = string.Format(@"select *
            //                                                    from OrderTable
            //                                                    where RoomID ='{0}' and State = '新开单'", lbFangHao.Text);
            //                        SqlDataReader dr = db.ChaXun(sql);
            //                        if (dr.HasRows)
            //                        {
            //                            while (dr.Read())
            //                            {
            //                                DateTime dt1 = Convert.ToDateTime(dr["CheckInTime"].ToString());
            //                                DateTime dt2 = Convert.ToDateTime(dr["PreDepartureTime"].ToString());
            //                                if (db.ShiJian(dt3, tpXinYuLi.Value, dt1, dt2))
            //                                {
            //                                    string ssc = string.Format("该房间在{0}-{1}时间段是入住状态!", dt1.ToString(), dt2.ToString());
            //                                    MessageBox.Show(ssc); ;
            //                                }
            //                            }
            //                        }
            //                    }
            //                    catch (Exception ee)
            //                    {
            //                        MessageBox.Show(ee.Message);
            //                    }
            //                    finally
            //                    {
            //                        db.GuanBi();
            //                    }


        }
        private void skinButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format(@"update OrderTable set AmountReceived+={0},PreDepartureTime ='{2}',CompanyName+={0}
                                                where State ='新开单' and RoomID ='{1}'", Convert.ToInt32(tbChaJia.Text), lbFangHao.Text, tpXinYuLi.Text);
                if (db.ExecuteSQLCommand(sql) > 0)
                {
                    string aaac = string.Format("{0}房间续房成功！", lbFangHao.Text);
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

        private void tbChaJia_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbChaJia_KeyPress(object sender, KeyPressEventArgs e)
        {
            //第一步：判断输入的是否是数字——char.IsNumber(e.KeyChar)
            //如果是数字，可以输入（e.Handled = false;）
            //如果不是数字，则判断是否是小数点
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //判断输入的是否是小数点，或中文状态下的句号，或者是退格键
                //如果是小数点，循环判断每个字符是不是小数点，如果存在不能输入，如果不存在允许输入
                //如果是退格键，允许输入——if (e.KeyChar == '\b')
                //如果不是小数点也不是退格键，不允许输入
                if (e.KeyChar == Convert.ToChar("。") || e.KeyChar == Convert.ToChar("."))
                {

                    int i_d = 0;
                    for (int i = 0; i < tbChaJia.Text.Length; i++)
                    {
                        if (tbChaJia.Text.Substring(i, 1) == ".")
                        {
                            e.Handled = true;
                            i_d++;
                            return;
                        }
                    }
                    if (i_d == 0)
                    {
                        e.KeyChar = Convert.ToChar(".");//设置按键输入的值为"."
                        e.Handled = false;
                    }
                }
                else if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }

                else
                {
                    e.Handled = true;
                }
            }
        }

    }
}
