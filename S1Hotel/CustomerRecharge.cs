using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CCWin;
namespace S1Hotel
{
    public partial class CustomerRecharge : CCSkinMain
    {
        public string XingMing { get; set; }
        public string ShenFengZheng { get; set; }
        public string YuE { get; set; }
        public string HuiYuan { get; set; }
        //调用DBHelper类
        private DBHelper db = new DBHelper();
        public CustomerRecharge()
        {
            InitializeComponent();
        }

        private void CustomerRecharge_Load(object sender, EventArgs e)
        {
            tbXingMing.Text = XingMing;
            tbShenFenZheng.Text = ShenFengZheng;
            tbYuanYuE.Text = YuE;
            tbHuiYuan.Text = HuiYuan;
            //载入顾客类型
            string sql = string.Format(@"select *
                                                from CustomerTypeTable");
            DataSet dss = db.GetDataSet(sql, "LeiXing");
            cbLeiXing.DataSource = dss.Tables["LeiXing"];
            cbLeiXing.ValueMember = "ID";
            cbLeiXing.DisplayMember = "Grade";
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            try
            {
                double xinYuE = Convert.ToDouble(tbYuanYuE.Text) + Convert.ToDouble(tbJinE.Text);
                string sql = string.Format(@"update CustomerTable set Balance = '{0}', Type='{1}'
                                                    where CarID='{2}'", xinYuE, cbLeiXing.SelectedValue.ToString(), tbShenFenZheng.Text);
                if (db.ExecuteSQLCommand(sql) > 0)
                {
                    string ccca = string.Format("{0}成功充值{1}元", tbXingMing.Text, tbJinE.Text);

                    MessageBox.Show(ccca);
                    Song();
                }
                else
                {
                    MessageBox.Show("抱歉！充值失败！");
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

            string sj = DateTime.Now.ToString();
            try
            {
                string sql = string.Format(@"
                insert into  CustomerRecharge(RechargeTime, RechargeAmount, RechargeIDCardNumber, Gifts)
                values('{0}','{1}','{2}','{3}')", sj, tbJinE.Text, tbShenFenZheng.Text, tbSong.Text);
                if (db.ExecuteSQLCommand(sql) == 0)
                {
                    MessageBox.Show("新增到充值记录表中失败！");
                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            this.Close();
        }

        private void skinWaterTextBox3_TextChanged(object sender, EventArgs e)
        {
            if (!tbJinE.Text.Equals(""))
            {
                // 非零开头的最多带两位小数的数字：
                Regex rx = new Regex(@"^([1-9][0-9]*)+(.[0-9]{1,2})?$");
                if (!(rx.IsMatch(tbJinE.Text)))
                {
                    lbTiShi.Text = "请输入正确的金额,非零开头的最多带两位小数";
                    return;
                }
                else
                {
                    lbTiShi.Text = "";
                }
                //根据充值的金额改变会员类型
                double jinE = Convert.ToDouble(tbJinE.Text);
                if (jinE >= 5000)
                {
                    cbLeiXing.Text = "陨石会员";
                    tbSong.Text = "可乐";
                }
                else if (jinE >= 2000)
                {
                    cbLeiXing.Text = "钻石会员";
                    tbSong.Text = "芙蓉王";
                }
                else if (jinE >= 800)
                {
                    cbLeiXing.Text = "黄金会员";
                    tbSong.Text = "白沙";
                }
                else
                {
                    cbLeiXing.Text = "普通用户";
                    tbSong.Text = "扑克";
                }
            }
        }
        public void Song()
        {
            string sql = string.Format(@"update Commodity set Number=Number-1 where Name='{0}'", tbSong.Text);
            if (db.ExecuteSQLCommand(sql) == 0)
            {
                MessageBox.Show("商品修改失败！");
            }
        }

        private void tbJinE_KeyPress(object sender, KeyPressEventArgs e)
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
                    for (int i = 0; i < tbJinE.Text.Length; i++)
                    {
                        if (tbJinE.Text.Substring(i, 1) == ".")
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

        private void cbLeiXing_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
