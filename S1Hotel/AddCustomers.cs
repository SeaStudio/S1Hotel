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
    public partial class AddCustomers : CCSkinMain
    {
        //调用DBHelper类
        private DBHelper db = new DBHelper();
        public AddCustomers()
        {
            InitializeComponent();
        }

        private void AddCustomers_Load(object sender, EventArgs e)
        {
            //载入顾客类型
            string sql = string.Format(@"select *
                                                from CustomerTypeTable");
            DataSet dss = db.GetDataSet(sql, "LeiXing");
            cbLeiXing.DataSource = dss.Tables["LeiXing"];
            cbLeiXing.ValueMember = "ID";
            cbLeiXing.DisplayMember = "Grade";
        }

        private void tbShenFengZheng_MouseLeave(object sender, EventArgs e)
        {
            SFZYanZheng();
        }
        private void SFZYanZheng()
        {
            if ((!Regex.IsMatch(tbShenFenZheng.Text, @"^(\d{15}$|^\d{18}$|^\d{17}(\d|X|x))$", RegexOptions.IgnoreCase)))
            {
                lbTiShi.Text = "请输入合法的身份证！";
                tbShenFenZheng.Text = "";
                tbNianLing.Text = "";
                return;
            }
            else
            {
                lbTiShi.Text = "";
            }

            string birthday = "";
            string sex = "";

            //18位身份证判定
            if (tbShenFenZheng.Text.Length == 18)
            {
                //获取出生年月日和性别代码和地区
                birthday = tbShenFenZheng.Text.Substring(6, 4) + "-" + tbShenFenZheng.Text.Substring(10, 2) + "-" + tbShenFenZheng.Text.Substring(12, 2);
                sex = tbShenFenZheng.Text.Substring(14, 3);

            }

            //15位身份证判定
            if (tbShenFenZheng.Text.Length == 15)
            {
                birthday = "19" + tbShenFenZheng.Text.Substring(6, 2) + "-" + tbShenFenZheng.Text.Substring(8, 2) + "-" + tbShenFenZheng.Text.Substring(10, 2);
                sex = tbShenFenZheng.Text.Substring(12, 3);
            }

            //性别代码为偶数是女性奇数为男性
            if (int.Parse(sex) % 2 == 0)
            {
                rbNan.Checked = false;
                rbNv.Checked = true;
            }
            else if (int.Parse(sex) % 2 == 1)
            {
                rbNan.Checked = true;
                rbNv.Checked = false;

            }
            //用出生日期计算出年龄
            DateTime birth = DateTime.Parse(birthday);
            DateTime now = DateTime.Now;
            int age = now.Year - birth.Year;
            tbNianLing.Text = age.ToString();
        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            //清空所有Text文本
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }
            }
        }

        private void tbDianHua_MouseLeave(object sender, EventArgs e)
        {
            //合法手机号判定
            if (tbDianHua.Text != "")
            {
                Regex rx = new Regex(@"^0{0,1}(13[4-9]|15[7-9]|15[0-2]|18[7-8]|17[6-8])[0-9]{8}$");
                if (!rx.IsMatch(tbDianHua.Text)) //不匹配
                {
                    lbTiShi.Text = "请输入合法的手机号！";
                    tbDianHua.Text = "";
                }
                else
                {
                    lbTiShi.Text = "";
                }
            }
            else
            {
                lbTiShi.Text = "";
            }
        }

        private void tbJinE_TextChanged(object sender, EventArgs e)
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
                if (jinE > 5000)
                {
                    cbLeiXing.Text = "王者会员";
                }
                else if (jinE > 2000)
                {
                    cbLeiXing.Text = "钻石会员";
                }
                else if (jinE > 800)
                {
                    cbLeiXing.Text = "黄金会员";
                }
                else
                {
                    cbLeiXing.Text = "普通用户";
                }
            }

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (tbXingMing.Text.Equals("") || tbShenFenZheng.Text.Equals("") || tbJinE.Text.Equals(""))
            {
                lbTiShi.Text = "请认真填写所有资料！";
                return;
            }
            try
            {
                string gender = "男";
                if (rbNv.Checked)
                {
                    gender = "女";
                }
                //向顾客表中插入数据
                string sql = string.Format(@"insert into CustomerTable( Name, CarID, Phone, Balance, Type, Sex, Age)
                                values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", tbXingMing.Text, tbShenFenZheng.Text, tbDianHua.Text, tbJinE.Text, cbLeiXing.SelectedValue, gender, tbNianLing.Text);
                if (db.ExecuteSQLCommand(sql) > 0)
                {
                    string sj = DateTime.Now.ToString();
                    //新增到充值记录表
                    try
                    {
                        sql = string.Format(@"
                insert into  CustomerRecharge(RechargeTime, RechargeAmount, RechargeIDCardNumber, Gifts)
                    values('{0}','{1}','{2}','{3}')", sj, tbJinE.Text, tbShenFenZheng.Text, "新开会员");
                        if (db.ExecuteSQLCommand(sql) == 0)
                        {
                            MessageBox.Show("新增到充值记录表中失败！","提示");
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
                    string aacc = string.Format("{0}恭喜您成为{1}", tbXingMing.Text, cbLeiXing.Text);
                    MessageBox.Show(aacc);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("添加失败！");
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

        private void tbXingMing_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //重名查询
                string sql = string.Format(@"select count(*)
                                        from CustomerTable
                                       where Name ='{0}'", tbXingMing.Text);
                if (db.GetSingleIntValue(sql) > 0)
                {
                    MessageBox.Show("已经有同名的顾客!", "注意:");
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
