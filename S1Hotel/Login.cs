using System;
using System.Data.SqlClient;
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
    /// <summary>
    /// 登入窗口！
    /// </summary>
    public partial class Login : CCSkinMain
    {
        //调用DBHelper类
        private DBHelper db = new DBHelper();
        public Login()
        {
            InitializeComponent();
        }

        private void Lonin_Load(object sender, EventArgs e)
        {
            Win32.AnimateWindow(this.Handle, 300, Win32.AW_ACTIVATE | Win32.AW_VER_POSITIVE | Win32.AW_SLIDE);
        }
       
 /*       private void skinButton1_Click(object sender, EventArgs e)
        {
           
        }*/
        /// <summary>
        /// 输入正确账号和密码后自动获取权限
        /// </summary>
        /// <returns></returns>
        private bool TianXieQuanXian()
        {
            bool bl = false;

            try
            {
                string sql = string.Format(@"select Jurisdiction
                                        from UserTable
                                        where UserName='{0}' and PassWord = '{1}'", tbZhangHao.Text, tbMiMa.Text);
                SqlDataReader dr = db.SelectDataReader(sql);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cbQuanXuan.Text = dr[0].ToString();
                    }
                    return bl = true;
                }
                else
                {
                    cbQuanXuan.Text = "权限";
                    return bl;
                }
            }
            catch (Exception ee)
            {
                System.Windows.Forms.MessageBox.Show(ee.Message);
                return bl;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void TbZhangHao_TextChanged_1(object sender, EventArgs e)
        {
            //输入正确账号和密码后自动获取权限
            TianXieQuanXian();
        }

        private void TbMiMa_TextChanged_1(object sender, EventArgs e)
        {
            //输入正确账号和密码后自动获取权限
            TianXieQuanXian();
        }
        //安全登录按钮
        private void BtDengLu_Click(object sender, EventArgs e)
        {
            //用户名和密码不能为空
            if (tbZhangHao.Text.Equals("") || tbMiMa.Text.Equals(""))
            {
                MessageBox.Show("用户名或密码不能为空！", "提示");
                return;
            }
            if (!TianXieQuanXian())
            {
                MessageBox.Show("用户名或密码错误！", "提示");
                return;
            }
            //打开主界面
            MainInterface MI = new MainInterface();
            MI.CaoZuoYuan = tbZhangHao.Text;
            MI.QuanXuang = cbQuanXuan.Text;
            try
            {
                //获取酒店名称
                string sql = string.Format(@"select *
                                        from [dbo].[HotelName]");
                SqlDataReader dr = db.SelectDataReader(sql);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        MI.Text = dr[0].ToString() + "酒店管理系统 V2021";
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
            Win32.AnimateWindow(this.Handle, 300, Win32.AW_HIDE | Win32.AW_VER_POSITIVE | Win32.AW_SLIDE);
            this.Hide();
            MI.Show();
        }
    }
}
