using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Globalization;
using System.Speech.Synthesis;
using System.Windows.Forms;
using CCWin;

namespace S1Hotel
{
    public partial class CheckOut : CCSkinMain
    {
        private string CaoZuoYuan = "1";
        //调用DBHelper类
        private DBHelper db = new DBHelper();
        public CheckOut()
        {
            InitializeComponent();
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            NewMethod();
            //自动生成id 格式为 20181018001 
            try
            {
                string danHao = "";
                string today = DateTime.Now.ToString("yyyyMMdd");
                string sql = string.Format(@"select MAX([OrderID])
                                                from CheckoutTable
                                            where OrderID like '{0}%'", today);
                double aa = db.GetSingleDoubleValue(sql);
                //如果标准中有今天的值就今天的最大值加1
                if (aa > 0)
                {
                    aa++;
                    danHao = (aa).ToString();
                }
                else
                {
                    danHao = today.ToString() + "001";
                }
                tbDingDanHao.Text = danHao;

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

        private void NewMethod()
        {
            try
            {
                //查询所有没有结账的订单
                string sql = string.Format(@"select * 
                from OrderTable where State = '{0}'", "新开单");

                if (tbFangHao.Text != "")
                {
                    sql = string.Format(@"select * 
                from OrderTable where State = '{0}' and RoomID = '{1}'", "新开单", tbFangHao.Text);
                }
                SqlDataReader dr = db.SelectDataReader(sql);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ListViewItem items = new ListViewItem(dr["OrderID"].ToString());
                        items.SubItems.Add(dr["RoomID"].ToString());
                        items.SubItems.Add(dr["UName"].ToString());
                        items.SubItems.Add(dr["Phone"].ToString());
                        items.SubItems.Add(dr["CheckInTime"].ToString());
                        items.SubItems.Add(dr["PreDepartureTime"].ToString());
                        items.SubItems.Add(dr["CompanyName"].ToString());
                        items.SubItems.Add(dr["Deposit"].ToString());
                        items.SubItems.Add(dr["AmountReceived"].ToString());
                        items.SubItems.Add(dr["PaymentMethod"].ToString());
                        items.SubItems.Add(dr["Discounts"].ToString());
                        items.SubItems.Add(dr["Remarks"].ToString());
                        items.SubItems.Add(dr["Price"].ToString());
                        lvZaiZhuKeFang.Items.Add(items);
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

        private void lvZaiZhuKeFang_DoubleClick(object sender, EventArgs e)
        {
            if (lvTuiFang.Items.Count > 0)
            {
                if (lvTuiFang.Items[0].SubItems[0].Text != lvZaiZhuKeFang.SelectedItems[0].SubItems[0].Text)
                {
                    MessageBox.Show("不是同一订单不能同时结账");
                    return;
                }
            }
            //双击在住客房里数据添加到准备退房里
            ListViewItem items = new ListViewItem(lvZaiZhuKeFang.SelectedItems[0].SubItems[0].Text);
            items.SubItems.Add(lvZaiZhuKeFang.SelectedItems[0].SubItems[1].Text); //房号
            items.SubItems.Add(lvZaiZhuKeFang.SelectedItems[0].SubItems[2].Text); //姓名
            items.SubItems.Add(lvZaiZhuKeFang.SelectedItems[0].SubItems[3].Text);//手机号码
            items.SubItems.Add(lvZaiZhuKeFang.SelectedItems[0].SubItems[4].Text);//入住时间
            //计算实住时间
            DateTime dt1 = Convert.ToDateTime(lvZaiZhuKeFang.SelectedItems[0].SubItems[4].Text);//入住时间
            DateTime dt2 = DateTime.Now;//本地时间
            TimeSpan d3 = dt2.Subtract(dt1);//实住时间
            items.SubItems.Add(string.Format("{0} {1}:{2}:{3}", d3.Days.ToString(), d3.Hours.ToString(), d3.Minutes.ToString(), d3.Seconds.ToString()));
            //计算应付金额
            double fangJia = Convert.ToDouble(lvZaiZhuKeFang.SelectedItems[0].SubItems[12].Text);//房价
            string jiaGe;
            if (d3.Days >= 1)
            {
                jiaGe = (fangJia * d3.Days).ToString();
            }
            else
            {
                //当入住时间大于6小于1天时价格等于一天的价格
                if (d3.Hours > 6)
                {
                    jiaGe = (fangJia).ToString();
                }
                else
                {
                    //入住小于6小时是房价减半
                    jiaGe = (fangJia / 2).ToString();

                }
            }
            items.SubItems.Add(jiaGe);
            items.SubItems.Add(lvZaiZhuKeFang.SelectedItems[0].SubItems[6].Text);//现金收款
            items.SubItems.Add(lvZaiZhuKeFang.SelectedItems[0].SubItems[7].Text);//余额收款
            items.SubItems.Add(lvZaiZhuKeFang.SelectedItems[0].SubItems[8].Text);//合计金额
            items.SubItems.Add(lvZaiZhuKeFang.SelectedItems[0].SubItems[9].Text);
            items.SubItems.Add(lvZaiZhuKeFang.SelectedItems[0].SubItems[10].Text);
            items.SubItems.Add(lvZaiZhuKeFang.SelectedItems[0].SubItems[12].Text);
            ListViewItem list = lvZaiZhuKeFang.SelectedItems[0];
            lvZaiZhuKeFang.Items.Remove(list);
            lvTuiFang.Items.Add(items);

            //计算应付金额！
            if (lvTuiFang.Items.Count > 0)
            {
                double yingFu = 0;
                double yuEZhiFu = 0;
                double xianJinZhiFu = 0;
                for (int i = 0; i < lvTuiFang.Items.Count; i++)
                {
                    yingFu += Convert.ToDouble(lvTuiFang.Items[i].SubItems[6].Text);
                    yuEZhiFu += Convert.ToDouble(lvTuiFang.Items[i].SubItems[8].Text);
                    xianJinZhiFu += Convert.ToDouble(lvTuiFang.Items[i].SubItems[7].Text);
                }
                if (lvTuiFang.Items[0].SubItems[11].Text != "不打折")
                {
                    yingFu = yingFu * Convert.ToDouble(lvTuiFang.Items[0].SubItems[11].Text.Substring(0, 1)) / 10;
                }
                tbYinFu.Text = yingFu.ToString();
                tbYuEZhiFu.Text = yuEZhiFu.ToString();
                tbXianJin.Text = xianJinZhiFu.ToString();
                cbFuKuanFangShi.Text = lvTuiFang.Items[0].SubItems[10].Text;
            }
            JiSuanJinE();


        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbXianJin_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbFuKuanFangShi_SelectedIndexChanged(object sender, EventArgs e)
        {
            JiSuanJinE();
        }

        private void JiSuanJinE()
        {
            if (cbFuKuanFangShi.Text == "")
            {
                return;
            }
            if (cbFuKuanFangShi.Text == "现金支付")
            {
                //当现金支付大于等于应付金额时
                if (Convert.ToDouble(tbXianJin.Text) >= Convert.ToDouble(tbYinFu.Text))
                {
                    //就退会多余的现金
                    tbZhaoLing.Text = (Convert.ToDouble(tbXianJin.Text) - Convert.ToDouble(tbYinFu.Text)).ToString();
                }
                else
                {
                    //不足则补差价
                    tbChaJia.Enabled = true;
                    tbChaJia.Text = (Convert.ToDouble(tbYinFu.Text) - Convert.ToDouble(tbXianJin.Text)).ToString();
                    tbZhaoLing.Text = ((Convert.ToDouble(tbXianJin.Text) + Convert.ToDouble(tbYuEZhiFu.Text) + Convert.ToDouble(tbChaJia.Text)) - Convert.ToDouble(tbYinFu.Text)).ToString();//计算找零
                }
            }
            else if (cbFuKuanFangShi.Text == "账户余额")
            {
                //当余额支付大于应付金额
                if (Convert.ToDouble(tbYuEZhiFu.Text) >= Convert.ToDouble(tbYinFu.Text))
                {
                    //支付的余额就等于应付的余额
                    tbYuEZhiFu.Text = tbYuEZhiFu.Text;
                    tbZhaoLing.Text = "0";
                }
                else
                {
                    //不足则查询账户里还剩多少余额！
                    try
                    {
                        string sql = string.Format(@"select sum(balance)
                                    from[dbo].[CustomerTable]
                                    where Name ='{0}' and Phone ='{1}'", lvTuiFang.Items[0].SubItems[2].Text, lvTuiFang.Items[0].SubItems[3].Text);
                        double yuEs = db.GetSingleDoubleValue(sql);
                        if (Convert.ToDouble(tbYuEZhiFu.Text) > yuEs)//输入的不能大于账户余额
                        {
                            tbYuEZhiFu.Text = yuEs.ToString();
                        }
                        if (yuEs > Convert.ToDouble(tbYinFu.Text))//余额够，直接付款！
                        {
                            tbYuEZhiFu.Text = tbYinFu.Text;
                        }
                        else
                        {    //余额不够，转化为账户加余额付款！
                            tbYuEZhiFu.Text = yuEs.ToString();
                            tbChaJia.Text = (Convert.ToDouble(tbYinFu.Text) - yuEs).ToString();
                            cbFuKuanFangShi.Text = "现金+余额";
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
            else
            {
                if ((Convert.ToDouble(tbXianJin.Text) + Convert.ToDouble(tbYuEZhiFu.Text)) < Convert.ToDouble(tbYinFu.Text))//余额+现金小于应付的时候就要补差价
                {
                    tbChaJia.Enabled = true;
                    tbYuEZhiFu.Enabled = true;
                    tbChaJia.Text = (Convert.ToDouble(tbYinFu.Text) - Convert.ToDouble(tbYuEZhiFu.Text) - Convert.ToDouble(tbXianJin.Text)).ToString();//计算差价
                    tbZhaoLing.Text = ((Convert.ToDouble(tbXianJin.Text) + Convert.ToDouble(tbYuEZhiFu.Text) + Convert.ToDouble(tbChaJia.Text)) - Convert.ToDouble(tbYinFu.Text)).ToString();//计算找零
                }
                else
                {
                    tbChaJia.Text = "0";
                    tbZhaoLing.Text = ((Convert.ToDouble(tbXianJin.Text) + Convert.ToDouble(tbYuEZhiFu.Text) + Convert.ToDouble(tbChaJia.Text)) - Convert.ToDouble(tbYinFu.Text)).ToString();//计算找零
                }

            }

        }

        private void tbYuEZhiFu_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDouble(tbYuEZhiFu.Text) > Convert.ToDouble(tbYinFu.Text))
            {
                tbYuEZhiFu.Text = tbYinFu.Text;
            }
            try
            {
                //查询账户里的余额
                string sql = string.Format(@"select sum(balance)
                                            from[dbo].[CustomerTable]
                                            where Name ='{0}' and Phone ='{1}'", lvTuiFang.Items[0].SubItems[2].Text, lvTuiFang.Items[0].SubItems[3].Text);
                double yuEs = db.GetSingleDoubleValue(sql);
                if (Convert.ToDouble(tbYuEZhiFu.Text) > yuEs)//输入的不能大于账户余额
                {
                    tbYuEZhiFu.Text = yuEs.ToString();
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
            JiSuanJinE();

        }

        private void tbChaJia_TextChanged(object sender, EventArgs e)
        {

            JiSuanJinE();
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            if (lvTuiFang.Items.Count == 0)
            {
                MessageBox.Show("请选择需要结账的订单！");
                return;
            }
            if (Convert.ToDouble(tbZhaoLing.Text) < 0)
            {
                MessageBox.Show("找零不能为负数！");
                return;
            }
            string danHao = lvTuiFang.Items[0].SubItems[0].Text;
            string xingMing = lvTuiFang.Items[0].SubItems[2].Text;
            string dianHua = lvTuiFang.Items[0].SubItems[3].Text;
            string tradeTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);
            if (cbFuKuanFangShi.Text == "现金结账")
            {
                //在入住表中插入结账信息！
                string sql = string.Format(@"insert into CheckoutTable(OrderID, UName, Phone, TotalCost, BalancePayment, PaymentMethod, CheckoutTime, Operator)
                                values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", tbDingDanHao.Text, xingMing, dianHua, Convert.ToDouble(tbXianJin.Text) + Convert.ToDouble(tbChaJia.Text) - Convert.ToDouble(tbZhaoLing.Text), tbYuEZhiFu.Text, cbFuKuanFangShi.Text, tradeTime, CaoZuoYuan);
                if (db.ExecuteSQLCommand(sql) < 1)
                {
                    MessageBox.Show("结账失败");
                    return;
                }
            }
            else if (cbFuKuanFangShi.Text == "余额结账")
            {
                //扣除账户余额
                string sql = string.Format(@"update [dbo].[CustomerTable] set Balance -= {0}
                                    where Name ='{1}' and Phone ='{2}'", Convert.ToDouble(tbYuEZhiFu.Text), xingMing, dianHua);

                if (db.ExecuteSQLCommand(sql) > 0)
                {
                    string sqls = string.Format(@"insert into MembershipConsumptionList(Name, Phone, AmountOfMoney, Type, Time)
                                        values('{0}','{1}','{2}','{3}','{4}')", xingMing, dianHua, Convert.ToDouble(tbYuEZhiFu.Text), "房间消费", tradeTime);
                    db.ExecuteSQLCommand(sqls);
                }
                else
                {
                    MessageBox.Show("修改余额失败！");
                }

                //在入住表中插入结账信息！
                sql = string.Format(@"insert into CheckoutTable(OrderID, UName, Phone, TotalCost, BalancePayment, PaymentMethod, CheckoutTime, Operator)
                                values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", tbDingDanHao.Text, xingMing, dianHua, Convert.ToDouble(tbXianJin.Text) + Convert.ToDouble(tbChaJia.Text) - Convert.ToDouble(tbZhaoLing.Text), tbYuEZhiFu.Text, cbFuKuanFangShi.Text, tradeTime, CaoZuoYuan);
                if (db.ExecuteSQLCommand(sql) < 1)
                {
                    MessageBox.Show("结账失败");
                    return;
                }
            }
            else
            {
                //扣除账户余额
                string sql = string.Format(@"update [dbo].[CustomerTable] set Balance -= {0}
                                    where Name ='{1}' and Phone ='{2}'", Convert.ToDouble(tbYuEZhiFu.Text), xingMing, dianHua);

                if (db.ExecuteSQLCommand(sql) > 0)
                {
                    string sqls = string.Format(@"insert into MembershipConsumptionList(Name, Phone, AmountOfMoney, Type, Time)
                                        values('{0}','{1}','{2}','{3}','{4}')", xingMing, dianHua, Convert.ToDouble(tbYuEZhiFu.Text), "房间消费", tradeTime);
                    db.ExecuteSQLCommand(sqls);
                }
                else
                {
                    MessageBox.Show("修改余额失败！");
                }
                //在入住表中插入结账信息！
                sql = string.Format(@"insert into CheckoutTable(OrderID, UName, Phone, TotalCost, BalancePayment, PaymentMethod, CheckoutTime, Operator)
                                values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", tbDingDanHao.Text, xingMing, dianHua, Convert.ToDouble(tbXianJin.Text) + Convert.ToDouble(tbChaJia.Text) - Convert.ToDouble(tbZhaoLing.Text), tbYuEZhiFu.Text, cbFuKuanFangShi.Text, tradeTime, CaoZuoYuan);
                if (db.ExecuteSQLCommand(sql) < 1)
                {
                    MessageBox.Show("结账失败");
                    return;
                }
            }
            for (int i = 0; i < lvTuiFang.Items.Count; i++)
            {
                //循环修改房间状态，改为空脏房
                string xiuGaiFangJian = string.Format(@"update RoomTable set StateID=3
                                                where RoomID='{0}'", lvTuiFang.Items[i].SubItems[1].Text);

                if (db.ExecuteSQLCommand(xiuGaiFangJian) < 1)
                {
                    MessageBox.Show("房间状态修改失败！");
                }

                //循环修改订单状态，改为已结账
                string xiuGaiDingDan = string.Format(@"update OrderTable set State='已结账'
                                                    where RoomID='{0}'", lvTuiFang.Items[i].SubItems[1].Text);
                if (db.ExecuteSQLCommand(xiuGaiDingDan) < 1)
                {
                    MessageBox.Show("订单状态修改失败！");
                }

                //删除激活的房卡
                string shanChuFangKa = string.Format(@"delete from RoomIDCard
                                                    where RoomID = '{0}'", lvTuiFang.Items[i].SubItems[1].Text);
                if (db.ExecuteSQLCommand(shanChuFangKa) < 1)
                {
                    //MessageBox.Show("删除房卡失败！");
                }

                //删除入住表
                string shanChuRuZhu = string.Format(@"delete from CheckInTable
                                                    where OrderID='{0}'", lvTuiFang.Items[i].SubItems[0].Text);
                db.ExecuteSQLCommand(shanChuRuZhu);
            }
            //语音提示
            string YuYinTiShi = string.Format("找零{0}元", tbZhaoLing.Text);
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak(YuYinTiShi);
            //关闭窗口
            this.Close();

        }

        private void btChaZhao_Click(object sender, EventArgs e)
        {
            lvZaiZhuKeFang.Items.Clear();
            NewMethod();
        }
    }
}
