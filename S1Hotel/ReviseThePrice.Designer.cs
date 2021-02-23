namespace S1Hotel
{
    partial class ReviseThePrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviseThePrice));
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.cbLeiXing = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.tbXinJia = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.cbYuanJia = new CCWin.SkinControl.SkinComboBox();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(37, 38);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(78, 21);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "房间类型:";
            // 
            // cbLeiXing
            // 
            this.cbLeiXing.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLeiXing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLeiXing.FormattingEnabled = true;
            this.cbLeiXing.Location = new System.Drawing.Point(119, 35);
            this.cbLeiXing.Name = "cbLeiXing";
            this.cbLeiXing.Size = new System.Drawing.Size(129, 27);
            this.cbLeiXing.TabIndex = 1;
            this.cbLeiXing.WaterText = "";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(37, 75);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(78, 21);
            this.skinLabel2.TabIndex = 0;
            this.skinLabel2.Text = "原来价格:";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(38, 112);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(77, 21);
            this.skinLabel3.TabIndex = 0;
            this.skinLabel3.Text = "新 价 格 :";
            // 
            // tbXinJia
            // 
            this.tbXinJia.Location = new System.Drawing.Point(119, 110);
            this.tbXinJia.Name = "tbXinJia";
            this.tbXinJia.Size = new System.Drawing.Size(129, 26);
            this.tbXinJia.TabIndex = 3;
            this.tbXinJia.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbXinJia.WaterText = "";
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton1.ForeColor = System.Drawing.Color.Transparent;
            this.skinButton1.Location = new System.Drawing.Point(24, 156);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Radius = 12;
            this.skinButton1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton1.Size = new System.Drawing.Size(245, 49);
            this.skinButton1.TabIndex = 4;
            this.skinButton1.Text = "确 定 修 改";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // cbYuanJia
            // 
            this.cbYuanJia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbYuanJia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYuanJia.FormattingEnabled = true;
            this.cbYuanJia.Location = new System.Drawing.Point(119, 73);
            this.cbYuanJia.Name = "cbYuanJia";
            this.cbYuanJia.Size = new System.Drawing.Size(129, 27);
            this.cbYuanJia.TabIndex = 2;
            this.cbYuanJia.WaterText = "";
            // 
            // ReviseThePrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = global::S1Hotel.Properties.Resources.OIP__26_;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(120)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(292, 226);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.tbXinJia);
            this.Controls.Add(this.cbYuanJia);
            this.Controls.Add(this.cbLeiXing);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ReviseThePrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修 改 价 格";
            this.Load += new System.EventHandler(this.ReviseThePrice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinComboBox cbLeiXing;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinWaterTextBox tbXinJia;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinComboBox cbYuanJia;
    }
}