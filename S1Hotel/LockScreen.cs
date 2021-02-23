using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace S1Hotel
{
    public partial class LockScreen : Form
    {
        private Hook h = new Hook();
        private DBHelper db = new DBHelper();
        public string CaoZuoYuan { get; set; }
        public LockScreen()
        {
            InitializeComponent();
        }

        private void LockScreen_Load(object sender, EventArgs e)
        {
            trmCloseTaskmgr.Start();
            h.InstallHook();
        }

        private void trmCloseTaskmgr_Tick(object sender, EventArgs e)
        {
            try
            {
                this.Activate();
                Process[] myProcess = Process.GetProcesses();
                foreach (Process p in myProcess)
                {
                    if (p.ProcessName == "taskmgr")
                    {
                        p.Kill();
                        return;
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void LockScreen_LocationChanged(object sender, EventArgs e)
        {
            this.trmCloseTaskmgr.Stop();
            h.UnInstallHook();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format(@"select COUNT(*)
                                    from UserTable
                                    where UserName ='{0}' and PassWord='{1}'", CaoZuoYuan, txtPwd.Text);
                if (db.GetSingleIntValue(sql) > 0)
                {
                    this.Close();
                }
                else
                {
                    txtPwd.WaterText = "密码错误！";
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

        private void LockScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4 && e.Modifiers == Keys.Alt)
            {
                e.Handled = true;
            }
        }
    }
}
