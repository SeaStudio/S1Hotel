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
    public partial class Expenditure : CCSkinMain
    {
        private DBHelper db = new DBHelper();

        public Expenditure()
        {
            InitializeComponent();
        }

        private void Expenditure_Load(object sender, EventArgs e)
        {

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (txtJinE.Text == "" || txtLeiXing.Text == "")
            {
                MessageBox.Show("抱歉！资料填写不完善！","提示");
                return;
            }
            try
            {
                string sql = string.Format(@"insert into Expenditure(DateTime, Money, Type)
                        values('{0}','{1}','{2}')", tpShiJian.Text, txtJinE.Text, txtLeiXing.Text);
                if (db.ExecuteSQLCommand(sql) > 0)
                {
                    MessageBox.Show("新增支出成功！","提示");
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
