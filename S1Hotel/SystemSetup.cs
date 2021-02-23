using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using CCWin;

namespace S1Hotel
{
    public partial class SystemSetup : CCSkinMain
    {
        //调用DBHelper类
        private DBHelper db = new DBHelper();
        public SystemSetup()
        {
            InitializeComponent();
        }
        private string mingCheng;

        private void SystemSetup_Load(object sender, EventArgs e)
        {
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
                        tbMingCheng.Text = dr[0].ToString();
                        mingCheng = dr[0].ToString();
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

        /// <summary>
        /// 获取路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Application.StartupPath + "\\";
            sfd.Filter = "备份文件(*.bak)|*.bak";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                tbLuJing.Text = sfd.FileName;
                btBeiFen.Enabled = true;
                btHuaiYuan.Enabled = true;
            }


        }


        private void skinButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        ///  备份数据库！
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btBeiFen_Click(object sender, EventArgs e)
        {
            //备份数据库
            try
            {
                string path = tbLuJing.Text;
                File.Delete(path);

                string sql = string.Format(@"backup database {0} to disk='{1}'", "S1Hotel", tbLuJing.Text);
                db.ExecuteSQLCommand(sql);
                MessageBox.Show("备份成功！","提示");
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

        private void skinButton3_Click(object sender, EventArgs e)
        {

        }

        private void skinButton4_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format(@"update HotelName set Name = '{0}'
                                            where Name = '{1}'", tbMingCheng.Text, mingCheng);
                if (db.ExecuteSQLCommand(sql) > 0)
                {
                    MessageBox.Show("保存成功！","提示");
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
