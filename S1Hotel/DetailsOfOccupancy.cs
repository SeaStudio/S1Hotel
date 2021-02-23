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
    public partial class DetailsOfOccupancy : CCSkinMain
    {
        private DBHelper db = new DBHelper();
        public DetailsOfOccupancy()
        {
            InitializeComponent();
        }

        private void DetailsOfOccupancy_Load(object sender, EventArgs e)
        {
            ChaXun();
        }

        private void ChaXun()
        {
            try
            {
                string sql = string.Format(@"select *
                                            from[dbo].[CheckInTable]");
                if (txtXingMing.Text != "")
                {
                    sql = string.Format(@"select *
                                            from[dbo].[CheckInTable] where UName = '{0}'", txtXingMing.Text);
                }
                DataSet ds = db.GetDataSet(sql, "RuZhu");
                dgvRuZhuBiao.DataSource = ds.Tables["RuZhu"];
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            ChaXun();
        }
    }
}
