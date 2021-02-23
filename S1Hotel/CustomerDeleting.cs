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

    public partial class CustomerDeleting : CCSkinMain
    {
        //调用DBHelper类
        private DBHelper db = new DBHelper();
        public string XingMing { get; set; }
        public string ShenFengZheng { get; set; }
        public string YuE { get; set; }
        public string HuiYuan { get; set; }
        public string DianHua { get; set; }
        public string NianLing { get; set; }
        public CustomerDeleting()
        {
            InitializeComponent();
        }

        private void CustomerDeleting_Load(object sender, EventArgs e)
        {
            tbShenFenZheng.Text = ShenFengZheng;
            tbXingMing.Text = XingMing;
            tbDianHua.Text = DianHua;
            tbYuE.Text = YuE;
            tbJiuLeiXing.Text = HuiYuan;
            tbNianLing.Text = NianLing;
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format(@"select COUNT(*)
                                            from OrderTable
                                            where State ='新开单' and UName ='{0}'", tbXingMing.Text);
                if (db.GetSingleIntValue(sql) > 0)
                {
                    MessageBox.Show("该客户还在入住状态不能删除！","提示");
                    tbXingMing.Text = "";
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

            DialogResult dr = MessageBox.Show("您确定要删除这位顾客吗?", "慎重", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.No)
            {
                return;
            }

            try
            {
                string sql = string.Format(@"delete from CustomerTable 
                                            where CarID='{0}'", tbShenFenZheng.Text);
                if (db.ExecuteSQLCommand(sql) > 0)
                {
                    MessageBox.Show("删除成功！","提示");
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

        private void skinButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
