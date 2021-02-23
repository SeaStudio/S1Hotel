namespace S1Hotel
{
    partial class LockScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LockScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPwd = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.trmCloseTaskmgr = new System.Windows.Forms.Timer(this.components);
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "密码:";
            // 
            // txtPwd
            // 
            this.txtPwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPwd.Location = new System.Drawing.Point(56, 15);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '●';
            this.txtPwd.Size = new System.Drawing.Size(100, 21);
            this.txtPwd.TabIndex = 1;
            this.txtPwd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPwd.WaterText = "请输入密码";
            // 
            // skinButton1
            // 
            this.skinButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Location = new System.Drawing.Point(176, 15);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(75, 23);
            this.skinButton1.TabIndex = 2;
            this.skinButton1.Text = "确 定";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // trmCloseTaskmgr
            // 
            this.trmCloseTaskmgr.Enabled = true;
            this.trmCloseTaskmgr.Interval = 1;
            this.trmCloseTaskmgr.Tick += new System.EventHandler(this.trmCloseTaskmgr_Tick);
            // 
            // skinPanel1
            // 
            this.skinPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.skinPanel1.BackColor = System.Drawing.Color.White;
            this.skinPanel1.Controls.Add(this.txtPwd);
            this.skinPanel1.Controls.Add(this.label1);
            this.skinPanel1.Controls.Add(this.skinButton1);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(83, 205);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Radius = 22;
            this.skinPanel1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinPanel1.Size = new System.Drawing.Size(264, 53);
            this.skinPanel1.TabIndex = 4;
            // 
            // LockScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::S1Hotel.Properties.Resources._3018761424_14;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(443, 409);
            this.Controls.Add(this.skinPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "LockScreen";
            this.Text = "LockScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LockScreen_Load);
            this.LocationChanged += new System.EventHandler(this.LockScreen_LocationChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LockScreen_KeyDown);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CCWin.SkinControl.SkinWaterTextBox txtPwd;
        private CCWin.SkinControl.SkinButton skinButton1;
        private System.Windows.Forms.Timer trmCloseTaskmgr;
        private CCWin.SkinControl.SkinPanel skinPanel1;
    }
}