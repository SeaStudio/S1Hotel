namespace S1Hotel
{
    partial class CustomerRecharge
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerRecharge));
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.tbXingMing = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.tbShenFenZheng = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.tbJinE = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.cbLeiXing = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.tbYuanYuE = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.lbTiShi = new CCWin.SkinControl.SkinLabel();
            this.lbHuiYuan = new CCWin.SkinControl.SkinLabel();
            this.tbHuiYuan = new CCWin.SkinControl.SkinWaterTextBox();
            this.tbSong = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(44, 44);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(56, 21);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "姓  名:";
            // 
            // tbXingMing
            // 
            this.tbXingMing.Enabled = false;
            this.tbXingMing.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbXingMing.Location = new System.Drawing.Point(106, 42);
            this.tbXingMing.Name = "tbXingMing";
            this.tbXingMing.Size = new System.Drawing.Size(143, 26);
            this.tbXingMing.TabIndex = 0;
            this.tbXingMing.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbXingMing.WaterText = "";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(38, 82);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(62, 21);
            this.skinLabel2.TabIndex = 0;
            this.skinLabel2.Text = "身份证:";
            // 
            // tbShenFenZheng
            // 
            this.tbShenFenZheng.Enabled = false;
            this.tbShenFenZheng.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbShenFenZheng.Location = new System.Drawing.Point(106, 79);
            this.tbShenFenZheng.Name = "tbShenFenZheng";
            this.tbShenFenZheng.Size = new System.Drawing.Size(143, 26);
            this.tbShenFenZheng.TabIndex = 1;
            this.tbShenFenZheng.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbShenFenZheng.WaterText = "";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(22, 234);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(78, 21);
            this.skinLabel3.TabIndex = 0;
            this.skinLabel3.Text = "充值金额:";
            // 
            // tbJinE
            // 
            this.tbJinE.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbJinE.Location = new System.Drawing.Point(106, 228);
            this.tbJinE.Name = "tbJinE";
            this.tbJinE.Size = new System.Drawing.Size(143, 26);
            this.tbJinE.TabIndex = 5;
            this.tbJinE.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbJinE.WaterText = "";
            this.tbJinE.TextChanged += new System.EventHandler(this.skinWaterTextBox3_TextChanged);
            this.tbJinE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbJinE_KeyPress);
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(6, 196);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(94, 21);
            this.skinLabel4.TabIndex = 0;
            this.skinLabel4.Text = "新顾客类型:";
            // 
            // cbLeiXing
            // 
            this.cbLeiXing.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLeiXing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLeiXing.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbLeiXing.FormattingEnabled = true;
            this.cbLeiXing.Location = new System.Drawing.Point(106, 190);
            this.cbLeiXing.Name = "cbLeiXing";
            this.cbLeiXing.Size = new System.Drawing.Size(143, 27);
            this.cbLeiXing.TabIndex = 4;
            this.cbLeiXing.WaterText = "";
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(44, 120);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(56, 21);
            this.skinLabel5.TabIndex = 0;
            this.skinLabel5.Text = "余  额:";
            // 
            // tbYuanYuE
            // 
            this.tbYuanYuE.Enabled = false;
            this.tbYuanYuE.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbYuanYuE.Location = new System.Drawing.Point(106, 116);
            this.tbYuanYuE.Name = "tbYuanYuE";
            this.tbYuanYuE.Size = new System.Drawing.Size(143, 26);
            this.tbYuanYuE.TabIndex = 2;
            this.tbYuanYuE.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbYuanYuE.WaterText = "";
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Location = new System.Drawing.Point(71, 334);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Radius = 18;
            this.skinButton1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton1.Size = new System.Drawing.Size(143, 53);
            this.skinButton1.TabIndex = 7;
            this.skinButton1.Text = "充    值";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // lbTiShi
            // 
            this.lbTiShi.AutoSize = true;
            this.lbTiShi.BackColor = System.Drawing.Color.Transparent;
            this.lbTiShi.BorderColor = System.Drawing.Color.White;
            this.lbTiShi.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTiShi.ForeColor = System.Drawing.Color.Red;
            this.lbTiShi.Location = new System.Drawing.Point(67, 301);
            this.lbTiShi.Name = "lbTiShi";
            this.lbTiShi.Size = new System.Drawing.Size(0, 20);
            this.lbTiShi.TabIndex = 4;
            // 
            // lbHuiYuan
            // 
            this.lbHuiYuan.AutoSize = true;
            this.lbHuiYuan.BackColor = System.Drawing.Color.Transparent;
            this.lbHuiYuan.BorderColor = System.Drawing.Color.White;
            this.lbHuiYuan.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbHuiYuan.Location = new System.Drawing.Point(6, 158);
            this.lbHuiYuan.Name = "lbHuiYuan";
            this.lbHuiYuan.Size = new System.Drawing.Size(94, 21);
            this.lbHuiYuan.TabIndex = 0;
            this.lbHuiYuan.Text = "原顾客类型:";
            // 
            // tbHuiYuan
            // 
            this.tbHuiYuan.Enabled = false;
            this.tbHuiYuan.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbHuiYuan.Location = new System.Drawing.Point(106, 153);
            this.tbHuiYuan.Name = "tbHuiYuan";
            this.tbHuiYuan.Size = new System.Drawing.Size(143, 26);
            this.tbHuiYuan.TabIndex = 3;
            this.tbHuiYuan.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbHuiYuan.WaterText = "";
            // 
            // tbSong
            // 
            this.tbSong.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbSong.Location = new System.Drawing.Point(106, 263);
            this.tbSong.Name = "tbSong";
            this.tbSong.ReadOnly = true;
            this.tbSong.Size = new System.Drawing.Size(143, 26);
            this.tbSong.TabIndex = 6;
            this.tbSong.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbSong.WaterText = "";
            this.tbSong.TextChanged += new System.EventHandler(this.skinWaterTextBox3_TextChanged);
            this.tbSong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbJinE_KeyPress);
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(67, 268);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(30, 21);
            this.skinLabel6.TabIndex = 0;
            this.skinLabel6.Text = "送:";
            // 
            // CustomerRecharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(107)))), ((int)(((byte)(83)))));
            this.BackgroundImage = global::S1Hotel.Properties.Resources.OIP__20_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(278, 399);
            this.Controls.Add(this.lbTiShi);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.cbLeiXing);
            this.Controls.Add(this.tbShenFenZheng);
            this.Controls.Add(this.tbHuiYuan);
            this.Controls.Add(this.tbYuanYuE);
            this.Controls.Add(this.tbSong);
            this.Controls.Add(this.tbJinE);
            this.Controls.Add(this.lbHuiYuan);
            this.Controls.Add(this.tbXingMing);
            this.Controls.Add(this.skinLabel5);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.skinLabel6);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CustomerRecharge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "充  值";
            this.Load += new System.EventHandler(this.CustomerRecharge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinWaterTextBox tbXingMing;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinWaterTextBox tbShenFenZheng;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinWaterTextBox tbJinE;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinComboBox cbLeiXing;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinWaterTextBox tbYuanYuE;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinLabel lbTiShi;
        private CCWin.SkinControl.SkinLabel lbHuiYuan;
        private CCWin.SkinControl.SkinWaterTextBox tbHuiYuan;
        private CCWin.SkinControl.SkinWaterTextBox tbSong;
        private CCWin.SkinControl.SkinLabel skinLabel6;
    }
}