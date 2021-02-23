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
    public partial class ModifyCustomerType : CCSkinMain
    {
        //调用DBHelper类
        private DBHelper db = new DBHelper();
        public ModifyCustomerType()
        {
            InitializeComponent();
        }

        private void ModifyCustomerType_Load(object sender, EventArgs e)
        {
            //载入顾客类型
            string sql = string.Format(@"select *
                                                from CustomerTypeTable");
            DataSet dss = db.GetDataSet(sql, "LeiXing");
            cbLeiXing.DataSource = dss.Tables["LeiXing"];
            cbLeiXing.ValueMember = "ID";
            cbLeiXing.DisplayMember = "Grade";
            cbZheKou.DataSource = dss.Tables["LeiXing"];
            cbZheKou.ValueMember = "ID";
            cbZheKou.DisplayMember = "Discount";

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {

        }

        private void skinButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void skinButton4_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format(@"update CustomerTypeTable set   Discount='{1}'
                                                    where Grade = '{0}'", cbLeiXing.Text, cbZheKou.Text);
                if (db.ExecuteSQLCommand(sql) > 0)
                {
                    MessageBox.Show("折扣修改成功！");
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

        private void skinButton3_Click(object sender, EventArgs e)
        {
            if (tbLeiXing.Text.Equals("") || tbZheKou.Text.Equals(""))
            {
                MessageBox.Show("类型或折扣不能为空！");
                return;
            }
            try
            {
                string sql = string.Format(@"insert into CustomerTypeTable(Grade, Discount)
                            values('{0}','{1}')", tbLeiXing.Text, tbZheKou.Text);
                if (db.ExecuteSQLCommand(sql) > 0)
                {
                    MessageBox.Show("添加成功！");
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
