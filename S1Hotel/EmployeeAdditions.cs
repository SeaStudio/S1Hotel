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
    public partial class EmployeeAdditions : CCSkinMain
    {
        private DBHelper db = new DBHelper();
        public EmployeeAdditions()
        {
            InitializeComponent();
        }

        private void EmployeeAdditions_Load(object sender, EventArgs e)
        {

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (txtXingMing.Text == "" || txtShengFenZheng.Text == "" || txtZhangHao.Text == "" || txtMiMa2.Text == "" || txtMiMa1.Text == "" || cbQuanXian.Text == "")
            {
                MessageBox.Show("所有文本框均不能为空！");
                return;
            }
            try
            {
                string sql = string.Format(@"insert into UserTable(UserName, PassWord, CarID, EmployeeName, Jurisdiction)
                                values('{0}','{1}','{2}','{3}','{4}')", txtZhangHao.Text, txtMiMa2.Text, txtShengFenZheng.Text, txtXingMing.Text, cbQuanXian.Text);
                if (db.ExecuteSQLCommand(sql) > 0)
                {
                    MessageBox.Show("新增员工成功！");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("新增员工失败！");
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

        private void txtMiMa2_TextChanged(object sender, EventArgs e)
        {
            if ((txtMiMa1.Text != "") && (txtMiMa2.Text != ""))
            {
                if (txtMiMa2.Text != txtMiMa1.Text)
                {
                    this.top1.Show("两次密码不一致", txtMiMa2);
                }
                else
                {
                    this.top1.Hide(txtMiMa2);
                }
            }
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtZhangHao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtZhangHao_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format(@"select COUNT(*)
                                                from [dbo].[UserTable]
                                                where UserName = '{0}'", txtZhangHao.Text);
                if (db.GetSingleIntValue(sql) > 0)
                {
                    MessageBox.Show("该账号已存在！");
                    txtZhangHao.Text = "";
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
