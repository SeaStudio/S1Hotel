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
    public partial class EmployeeManagement : CCSkinMain
    {
        private DBHelper db = new DBHelper();
        public EmployeeManagement()
        {
            InitializeComponent();
        }

        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            dgvBiao.AutoGenerateColumns = false;
            ChaXun();
        }

        private void ChaXun()
        {
            try
            {
                string sql = string.Format(@"select *
                                            from [dbo].[UserTable]");
                if (txtXingMing.Text != "")
                {
                    sql = string.Format(@"select *
                                            from [dbo].[UserTable] where EmployeeName like '{0}%'", txtXingMing.Text);
                }
                DataSet ds = db.GetDataSet(sql, "YuanGong");
                dgvBiao.DataSource = ds.Tables["YuanGong"];
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

        private void skinButton1_Click(object sender, EventArgs e)
        {
            ChaXun();
        }

        private void 新增员工ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeAdditions ea = new EmployeeAdditions();
            ea.ShowDialog();
            ChaXun();

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 员工辞职ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvBiao.SelectedRows.Count > 0)
            {
                try
                {
                    if (dgvBiao.SelectedRows[0].Cells[3].Value.ToString().Equals("超级管理员"))
                    {
                        MessageBox.Show("权限不足！");
                        return;
                    }
                    string sql = string.Format(@"delete from UserTable
                                                where UserName = '{0}'", dgvBiao.SelectedRows[0].Cells[0].Value.ToString());
                    if (db.ExecuteSQLCommand(sql) > 0)
                    {
                        MessageBox.Show("您失去该员工！");
                        ChaXun();
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
}
