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
    public partial class CustomerManagement : CCSkinMain
    {
        public string CaoZuoYuan { get; set; }
        //调用DBHelper类
        private DBHelper db = new DBHelper();
        public CustomerManagement()
        {
            InitializeComponent();
        }

        private void CustomerManagement_Load(object sender, EventArgs e)
        {
            ZaiRuZuiGao();
        }
        /// <summary>
        /// 最高级的载入，不要用错了。
        /// </summary>
        private void ZaiRuZuiGao()
        {
            //不允许自动创建列 dgvGuKe
            dgvGuKe.AutoGenerateColumns = false;

            //            try
            //            {
            //                //载入所有顾客
            string sql = string.Format(@"select *
                                                from CustomerTable
                                                inner join CustomerTypeTable
                                                on CustomerTable.Type = CustomerTypeTable.ID");

            ZaiRu(sql, "LeiXing");

            //                //载入顾客类型
            //                string sql = string.Format(@"select *
            //                                                from CustomerTypeTable");
            //                DataSet dss = db.Biao(sql, "LeiXing");


            //                DataRow row = dss.Tables["LeiXing"].NewRow();
            //                row["ID"] = -1;
            //                row["Grade"] = "全部";
            //                dss.Tables["LeiXing"].Rows.InsertAt(row, 0);
            //                cbLeiXing.DataSource = dss.Tables["LeiXing"];
            //                cbLeiXing.ValueMember = "ID";
            //                cbLeiXing.DisplayMember = "Grade";

            //            }
            //            catch (Exception ee)
            //            {
            //                MessageBox.Show(ee.Message);
            //            }
            //            finally
            //            {
            //                db.GuanBi();
            //            }
        }
        /// <summary>
        /// 载入dgvGuKe列表
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="biaoMing"></param>
        private void ZaiRu(string sql, string biaoMing)
        {
            DataSet ds = db.GetDataSet(sql, biaoMing);
            dgvGuKe.DataSource = ds.Tables[biaoMing];
        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textXingMing.Text != "")
                {
                    //查询相应的顾客
                    string sql = string.Format(@"select *
                                                from CustomerTable
                                                inner join CustomerTypeTable
                                                on CustomerTable.Type = CustomerTypeTable.ID where CustomerTable.Name='{0}'", textXingMing.Text);
                    ZaiRu(sql, "BiaoMing");
                }
                else
                {
                    //查询全部顾客
                    string sql = string.Format(@"select *
                                                from CustomerTable
                                                inner join CustomerTypeTable
                                                on CustomerTable.Type = CustomerTypeTable.ID");
                    ZaiRu(sql, "LeiXing");
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

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomers ac = new AddCustomers();
            ac.ShowDialog();
            ZaiRuZuiGao();
        }

        private void 充值ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvGuKe.SelectedRows.Count > 0)
            {
                CustomerRecharge cr = new CustomerRecharge();
                cr.XingMing = dgvGuKe.SelectedRows[0].Cells[0].Value.ToString();
                cr.ShenFengZheng = dgvGuKe.SelectedRows[0].Cells[1].Value.ToString();
                cr.YuE = dgvGuKe.SelectedRows[0].Cells[5].Value.ToString();
                cr.HuiYuan = dgvGuKe.SelectedRows[0].Cells[6].Value.ToString();
                cr.ShowDialog();
                ZaiRuZuiGao();
            }

        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void cbLeiXing_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void 修改类型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyCustomerType mct = new ModifyCustomerType();
            mct.ShowDialog();
            ZaiRuZuiGao();
        }

        private void 修改信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvGuKe.SelectedRows.Count > 0)
            {
                CustomerModification cm = new CustomerModification();
                cm.ShenFengZheng = dgvGuKe.SelectedRows[0].Cells[1].Value.ToString();
                cm.HuiYuan = dgvGuKe.SelectedRows[0].Cells[6].Value.ToString();
                cm.YuE = dgvGuKe.SelectedRows[0].Cells[5].Value.ToString();
                cm.XingMing = dgvGuKe.SelectedRows[0].Cells[0].Value.ToString();
                cm.DianHua = dgvGuKe.SelectedRows[0].Cells[4].Value.ToString();
                cm.ShowDialog();
                ZaiRuZuiGao();
            }
        }

        private void 删除顾客ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvGuKe.SelectedRows.Count > 0)
            {
                CustomerDeleting cm = new CustomerDeleting();
                cm.ShenFengZheng = dgvGuKe.SelectedRows[0].Cells[1].Value.ToString();
                cm.HuiYuan = dgvGuKe.SelectedRows[0].Cells[6].Value.ToString();
                cm.YuE = dgvGuKe.SelectedRows[0].Cells[5].Value.ToString();
                cm.XingMing = dgvGuKe.SelectedRows[0].Cells[0].Value.ToString();
                cm.DianHua = dgvGuKe.SelectedRows[0].Cells[4].Value.ToString();
                cm.NianLing = dgvGuKe.SelectedRows[0].Cells[2].Value.ToString();
                cm.ShowDialog();
                ZaiRuZuiGao();
            }
        }

        private void 删除类型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerTypeDeletion ctd = new CustomerTypeDeletion();
            ctd.ShowDialog();
            ZaiRuZuiGao();
        }

        private void 退出ToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 消费查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerConsumption cc = new CustomerConsumption();
            cc.Show();
        }
    }
}
