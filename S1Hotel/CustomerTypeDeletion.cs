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
    public partial class CustomerTypeDeletion : CCSkinMain
    {
        //调用DBHelper类
        private DBHelper db = new DBHelper();
        public CustomerTypeDeletion()
        {
            InitializeComponent();
        }

        private void CustomerTypeDeletion_Load(object sender, EventArgs e)
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

        private void skinButton4_Click(object sender, EventArgs e)
        {
            try
            {
                //查询是否还有该顾客存在！
                string sql = string.Format(@"select count(*)
                                                from CustomerTable
                                                inner join CustomerTypeTable
                                                on CustomerTable.Type = CustomerTypeTable.ID
												where Grade ='{0}'", cbLeiXing.Text);
                if (db.GetSingleIntValue(sql) > 0)
                {
                    MessageBox.Show("还有该类型的顾客，要删除您请先修改顾客类型！","提示");
                    return;
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
            //确定是是否删除该顾客类型！
            DialogResult dr = MessageBox.Show("您确定要删除" + cbLeiXing.Text + "吗?", "慎重", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.No)
            {
                return;
            }
            try
            {
                string sql = string.Format(@"delete from CustomerTypeTable
                                                where Grade ='{0}'", cbLeiXing.Text);
                if (db.ExecuteSQLCommand(sql) > 0)
                {
                    MessageBox.Show("删除成功！您已失去" + cbLeiXing.Text + "顾客类型！");
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
