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
    public partial class CustomerModification :CCSkinMain
    {
        //调用DBHelper类
      private  DBHelper db = new DBHelper();
        public string XingMing { get; set; }
        public string ShenFengZheng { get; set; }
        public string YuE { get; set; }
        public string HuiYuan { get; set; }
        public string DianHua { get; set; }
        public CustomerModification()
        {
            InitializeComponent();
        }

        private void CustomerModification_Load(object sender, EventArgs e)
        {
            tbShenFenZheng.Text = ShenFengZheng;
            tbXingMing.Text = XingMing;
            tbDianHua.Text = DianHua;
            tbYuE.Text = YuE;
            tbJiuLeiXing.Text = HuiYuan;
            try
            {
                //载入顾客类型
                string sql = string.Format(@"select *
                                                from CustomerTypeTable");
                DataSet dss = db.GetDataSet(sql, "LeiXing");
                cbLeiXing.DataSource = dss.Tables["LeiXing"];
                cbLeiXing.ValueMember = "ID";
                cbLeiXing.DisplayMember = "Grade";
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

        private void skinButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (tbNianLing.Text.Equals("")||tbShenFenZheng.Text.Equals("")||tbXingMing.Text.Equals(""))
            {
                MessageBox.Show("请认真填写资料！");
                return;
            }
            try
            {
                string sex ="男";
                if (rbNv.Checked)
	            {
		            sex ="女";
	            }
                string sql = string.Format(@"update CustomerTable set Name='{0}', CarID='{1}', Phone='{2}', Balance='{3}', Type='{4}', Sex='{5}', Age='{6}'
                                 where CarID='{7}' and Name ='{8}'",tbXingMing.Text,tbShenFenZheng.Text,tbDianHua.Text,tbYuE.Text,cbLeiXing.SelectedValue,sex,tbNianLing.Text,ShenFengZheng,XingMing);
                if (db.ExecuteSQLCommand(sql)>0)
                {
                    MessageBox.Show("用户信息修改成功！");
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

        private void tbShenFenZheng_MouseLeave(object sender, EventArgs e)
        {
            SFZYanZheng();
        }
        private void SFZYanZheng()
        {

            //if (cbZJLeiXing.Text.Equals("身份证"))
            //{
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

        private void tbYuE_KeyPress(object sender, KeyPressEventArgs e)
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
                    for (int i = 0; i < tbYuE.Text.Length; i++)
                    {
                        if (tbYuE.Text.Substring(i, 1) == ".")
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
