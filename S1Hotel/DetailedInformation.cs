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
    public partial class DetailedInformation : CCSkinMain
    {
     private   DBHelper db = new DBHelper();
        public DetailedInformation()
        {
            InitializeComponent();
        }
        public string danHao { get; set; }
        private void DetailedInformation_Load(object sender, EventArgs e)
        {
            dgvDanHao.AutoGenerateColumns = false;
            ChaXun();
        }

        private void ChaXun()
        {
            try
            {
                string sql = string.Format(@"select *
                                                from OrderTable
                                                where State ='已结账'");
                if (txtXingMing.Text!="")
                {
                    sql = string.Format(@"select *
                                                from OrderTable
                                                where State ='已结账' and UName like '{0}%'",txtXingMing.Text);
                    if (txtNian.Text!="")
                    {
                        sql = string.Format(@"select *
                                                from OrderTable
                                                where State ='已结账' and UName like '{0}%' and CheckInTime like '{1}%'", txtXingMing.Text, txtNian.Text);
                        if (cbYue.Text != "")
                        {

                            string shiJian = txtNian.Text + "-" + cbYue.Text;
                            sql = string.Format(@"select *
                                                from OrderTable
                                                where State ='已结账' and UName like '{0}%' and CheckInTime like '{1}%'", txtXingMing.Text, shiJian);
                        }
                    }

                }
                DataSet ds = db.GetDataSet(sql, "DingDan");
                dgvDanHao.DataSource = ds.Tables["DingDan"];

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
    }
}
