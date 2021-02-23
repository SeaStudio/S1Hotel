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
    public partial class CustomerConsumption : CCSkinMain
    {
        private DBHelper db = new DBHelper();
        public CustomerConsumption()
        {
            InitializeComponent();
        }

        private void CustomerConsumption_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format(@"select *
                                        from MembershipConsumptionList");
                DataSet ds = db.GetDataSet(sql, "XiaoFei");
                skinDataGridView1.DataSource = ds.Tables["XiaoFei"];
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
            try
            {
                string sql = string.Format(@"select *
                                        from MembershipConsumptionList where Name = '{0}'", textName.Text);
                DataSet ds = db.GetDataSet(sql, "XiaoFei");
                skinDataGridView1.DataSource = ds.Tables["XiaoFei"];
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
