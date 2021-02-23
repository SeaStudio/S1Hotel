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
    public partial class Activation : CCSkinMain
    {
        //应用DBHelper类
        private DBHelper db = new DBHelper();
        //房号
        public string FangHao { get; set; }
        public Activation()
        {
            InitializeComponent();
        }

        private void Activation_Load(object sender, EventArgs e)
        {
            tbFangHao.Text = FangHao;
        }
        private void skinButton1_Click(object sender, EventArgs e)
        {
            //激活房卡
            try
            {
                string sql = string.Format(@"insert into RoomIDCard(RoomID, RoomCard)
                                            values('{0}','{1}')", FangHao, tbFangKa.Text);
                int a = db.ExecuteSQLCommand(sql);
                if (a > 0)
                {
                    string aaac = string.Format("激活成功！房号为：{0}，房卡为：{1}", FangHao, tbFangKa.Text);
                    MessageBox.Show(aaac);
                }
                else
                {
                    string aaac = string.Format("{0}房卡激活失败！", FangHao);
                    MessageBox.Show(aaac);
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

        private void skinButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbFangKa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }
    }
}
