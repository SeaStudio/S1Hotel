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
    public partial class PurchaseQuantity : CCSkinMain
    {
        public PurchaseQuantity()
        {
            InitializeComponent();
        }
        public int a { get; set; }

        private void PurchaseQuantity_Load(object sender, EventArgs e)
        {

        }

        private void skinWaterTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbShuLiang_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只能输入数字和退格键
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (tbShuLiang.Text == "")
            {
                MessageBox.Show("抱歉，不能卖空的！");
                return;
            }
            if (Convert.ToInt32(tbShuLiang.Text) > 0)
            {
                a = Convert.ToInt32(tbShuLiang.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("不要玩了！买东西要认真点！");
            }

        }
    }
}
