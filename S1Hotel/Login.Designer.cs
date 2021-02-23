namespace S1Hotel
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tpTiShi = new CCWin.SkinToolTip(this.components);
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.btDengLu = new CCWin.SkinControl.SkinButton();
            this.cbQuanXuan = new CCWin.SkinControl.SkinComboBox();
            this.tbMiMa = new CCWin.SkinControl.SkinWaterTextBox();
            this.tbZhangHao = new CCWin.SkinControl.SkinWaterTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.skinGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tpTiShi
            // 
            this.tpTiShi.AutoPopDelay = 5000;
            this.tpTiShi.InitialDelay = 500;
            this.tpTiShi.OwnerDraw = true;
            this.tpTiShi.ReshowDelay = 800;
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.Black;
            this.skinGroupBox1.Controls.Add(this.btDengLu);
            this.skinGroupBox1.Controls.Add(this.cbQuanXuan);
            this.skinGroupBox1.Controls.Add(this.tbMiMa);
            this.skinGroupBox1.Controls.Add(this.tbZhangHao);
            this.skinGroupBox1.Font = new System.Drawing.Font("新宋体", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBox1.ForeColor = System.Drawing.Color.Green;
            this.skinGroupBox1.Location = new System.Drawing.Point(423, 191);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.Radius = 10;
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.LightSkyBlue;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(273, 222);
            this.skinGroupBox1.TabIndex = 2;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.Text = "用 户 登 录";
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.Black;
            this.skinGroupBox1.TitleRadius = 6;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.LightSkyBlue;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // btDengLu
            // 
            this.btDengLu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btDengLu.BackColor = System.Drawing.Color.Transparent;
            this.btDengLu.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btDengLu.DownBack = null;
            this.btDengLu.Location = new System.Drawing.Point(32, 163);
            this.btDengLu.MouseBack = null;
            this.btDengLu.Name = "btDengLu";
            this.btDengLu.NormlBack = null;
            this.btDengLu.Size = new System.Drawing.Size(205, 38);
            this.btDengLu.TabIndex = 4;
            this.btDengLu.Text = "安  全  登  录";
            this.btDengLu.UseVisualStyleBackColor = false;
            this.btDengLu.Click += new System.EventHandler(this.BtDengLu_Click);
            // 
            // cbQuanXuan
            // 
            this.cbQuanXuan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbQuanXuan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbQuanXuan.Enabled = false;
            this.cbQuanXuan.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbQuanXuan.FormattingEnabled = true;
            this.cbQuanXuan.Location = new System.Drawing.Point(31, 120);
            this.cbQuanXuan.Name = "cbQuanXuan";
            this.cbQuanXuan.Size = new System.Drawing.Size(206, 27);
            this.cbQuanXuan.TabIndex = 3;
            this.cbQuanXuan.WaterText = "权限";
            // 
            // tbMiMa
            // 
            this.tbMiMa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMiMa.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbMiMa.Location = new System.Drawing.Point(30, 77);
            this.tbMiMa.Name = "tbMiMa";
            this.tbMiMa.PasswordChar = '●';
            this.tbMiMa.Size = new System.Drawing.Size(207, 26);
            this.tbMiMa.TabIndex = 2;
            this.tbMiMa.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbMiMa.WaterText = "请输入密码";
            this.tbMiMa.TextChanged += new System.EventHandler(this.TbMiMa_TextChanged_1);
            // 
            // tbZhangHao
            // 
            this.tbZhangHao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbZhangHao.BackColor = System.Drawing.Color.White;
            this.tbZhangHao.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbZhangHao.ForeColor = System.Drawing.Color.Black;
            this.tbZhangHao.Location = new System.Drawing.Point(28, 29);
            this.tbZhangHao.Name = "tbZhangHao";
            this.tbZhangHao.Size = new System.Drawing.Size(209, 26);
            this.tbZhangHao.TabIndex = 1;
            this.tbZhangHao.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbZhangHao.WaterText = "请输入用户名";
            this.tbZhangHao.TextChanged += new System.EventHandler(this.TbZhangHao_TextChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::S1Hotel.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(4, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(751, 462);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(759, 494);
            this.Controls.Add(this.skinGroupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用 户 登 录";
            this.Load += new System.EventHandler(this.Lonin_Load);
            this.skinGroupBox1.ResumeLayout(false);
            this.skinGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinToolTip tpTiShi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private CCWin.SkinControl.SkinButton btDengLu;
        private CCWin.SkinControl.SkinComboBox cbQuanXuan;
        private CCWin.SkinControl.SkinWaterTextBox tbMiMa;
        private CCWin.SkinControl.SkinWaterTextBox tbZhangHao;
    }
}

