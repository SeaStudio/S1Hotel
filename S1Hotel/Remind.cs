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
    public partial class Remind : CCSkinMain
    {
        private DBHelper db = new DBHelper();
        public Remind()
        {
            InitializeComponent();
        }

        private void Remind_Load(object sender, EventArgs e)
        {
            ChaXun();
        }

        private void ChaXun()
        {
            try
            {
                string sql = string.Format(@"select *
                                    from [dbo].[RemindTable]");
                DataSet ds = db.GetDataSet(sql, "TiXing");
                dgvTiXing.DataSource = ds.Tables["TiXing"];
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

        private void dgvTiXing_DoubleClick(object sender, EventArgs e)
        {
            if (dgvTiXing.SelectedRows.Count == 0)
            {
                return;
            }
            try
            {
                string sql = string.Format(@"update RemindTable set Type = '已读'
                        where Type = '未读' and RooID = '{0}'", dgvTiXing.SelectedRows[0].Cells[0].Value.ToString());
                db.ExecuteSQLCommand(sql);

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            ChaXun();
        }
        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (dgvTiXing.Rows.Count > 0)
            {
                for (int i = 0; i < dgvTiXing.Rows.Count; i++)
                {
                    try
                    {
                        string sql = string.Format(@"update RemindTable set Type = '已读'
                                    where Type = '未读' and RooID = '{0}'", dgvTiXing.Rows[i].Cells[0].Value.ToString());
                        db.ExecuteSQLCommand(sql);

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
                ChaXun();
            }
        }
    }
}
