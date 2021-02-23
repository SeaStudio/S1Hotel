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
    public partial class ReviseThePrice : CCSkinMain
    {
        //调用DBHelper类
        private DBHelper db = new DBHelper();
        public ReviseThePrice()
        {
            InitializeComponent();
        }

        private void ReviseThePrice_Load(object sender, EventArgs e)
        {
            string sql = string.Format(@"select *
                                        from RoomTypeTable");
            DataSet ds = db.GetDataSet(sql, "LeiXing");
            cbLeiXing.DataSource = ds.Tables["LeiXing"];
            cbLeiXing.ValueMember = "ID";
            cbLeiXing.DisplayMember = "TypeName";
            cbYuanJia.DataSource = ds.Tables["LeiXing"];
            cbYuanJia.DisplayMember = "Price";
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (tbXinJia.Text.Equals(""))
            {
                MessageBox.Show("新价格不能为空！");
                return;
            }
            foreach (char item in tbXinJia.Text)
            {
                if (!(item >= '0' && item <= '9'))
                {
                    MessageBox.Show("新价格必须为纯数字");
                    return;
                }
            }
            try
            {
                string sql = string.Format(@"update RoomTypeTable set Price='{0}'
                                            where TypeName='{1}'", tbXinJia.Text, cbLeiXing.Text);
                if (db.ExecuteSQLCommand(sql) > 0)
                {
                    string aac = string.Format("{0}价格成功修改为{1}", cbLeiXing.Text, tbXinJia.Text);
                    MessageBox.Show(aac);
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
            this.Close();
        }
    }
}
