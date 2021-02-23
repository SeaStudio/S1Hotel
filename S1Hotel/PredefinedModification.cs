using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCWin;

namespace S1Hotel
{
    public partial class PredefinedModification : CCSkinMain
    {
        public string FangHao { get; set; }
        public string XingMing { get; set; }
        public string BeiZhu { get; set; }
        public string DianHua { get; set; }
        public string YuZhu { get; set; }
        public string YuLi { get; set; }
        public PredefinedModification()
        {
            InitializeComponent();
        }

        private void PredefinedModification_Load(object sender, EventArgs e)
        {
            txtXingMing.Text = XingMing;
            txtFangHao.Text = FangHao;
            txtDianHua.Text = DianHua;
            txtBeiZhu.Text = BeiZhu;
            tpYuLi.Text = YuLi;
            tpYuZhu.Text = YuZhu;
        }
    }
}
