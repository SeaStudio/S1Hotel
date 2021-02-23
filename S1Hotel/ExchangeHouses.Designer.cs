namespace S1Hotel
{
    partial class ExchangeHouses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExchangeHouses));
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.cbYuanFang = new CCWin.SkinControl.SkinComboBox();
            this.cbXingFang = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.tbRuZhu = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.tbYiJiao = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.tpYuLi = new System.Windows.Forms.DateTimePicker();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.tbBeiZhu = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.skinLabel9 = new CCWin.SkinControl.SkinLabel();
            this.tbChaJia = new CCWin.SkinControl.SkinWaterTextBox();
            this.cbYuanJia = new CCWin.SkinControl.SkinComboBox();
            this.cbXinJia = new CCWin.SkinControl.SkinComboBox();
            this.skinButton3 = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(28, 32);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(62, 21);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "原房间:";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(296, 26);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(62, 21);
            this.skinLabel2.TabIndex = 0;
            this.skinLabel2.Text = "调整为:";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(28, 65);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(62, 21);
            this.skinLabel3.TabIndex = 0;
            this.skinLabel3.Text = "原房价:";
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton1.Location = new System.Drawing.Point(351, 164);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(90, 32);
            this.skinButton1.TabIndex = 2;
            this.skinButton1.Text = "换   房";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // cbYuanFang
            // 
            this.cbYuanFang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbYuanFang.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbYuanFang.FormattingEnabled = true;
            this.cbYuanFang.Location = new System.Drawing.Point(96, 26);
            this.cbYuanFang.Name = "cbYuanFang";
            this.cbYuanFang.Size = new System.Drawing.Size(173, 27);
            this.cbYuanFang.TabIndex = 4;
            this.cbYuanFang.WaterText = "";
            this.cbYuanFang.SelectedIndexChanged += new System.EventHandler(this.cbYuanFang_SelectedIndexChanged);
            // 
            // cbXingFang
            // 
            this.cbXingFang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbXingFang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbXingFang.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbXingFang.FormattingEnabled = true;
            this.cbXingFang.Location = new System.Drawing.Point(365, 26);
            this.cbXingFang.Name = "cbXingFang";
            this.cbXingFang.Size = new System.Drawing.Size(173, 27);
            this.cbXingFang.TabIndex = 4;
            this.cbXingFang.WaterText = "";
            this.cbXingFang.SelectedIndexChanged += new System.EventHandler(this.cbXingFang_SelectedIndexChanged);
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(12, 98);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(78, 21);
            this.skinLabel4.TabIndex = 0;
            this.skinLabel4.Text = "入住日期:";
            // 
            // tbRuZhu
            // 
            this.tbRuZhu.Enabled = false;
            this.tbRuZhu.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbRuZhu.Location = new System.Drawing.Point(96, 93);
            this.tbRuZhu.Name = "tbRuZhu";
            this.tbRuZhu.Size = new System.Drawing.Size(173, 26);
            this.tbRuZhu.TabIndex = 3;
            this.tbRuZhu.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbRuZhu.WaterText = "";
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(12, 131);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(78, 21);
            this.skinLabel5.TabIndex = 0;
            this.skinLabel5.Text = "已交费用:";
            // 
            // tbYiJiao
            // 
            this.tbYiJiao.Enabled = false;
            this.tbYiJiao.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbYiJiao.Location = new System.Drawing.Point(96, 126);
            this.tbYiJiao.Name = "tbYiJiao";
            this.tbYiJiao.Size = new System.Drawing.Size(173, 26);
            this.tbYiJiao.TabIndex = 3;
            this.tbYiJiao.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbYiJiao.WaterText = "";
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(296, 62);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(62, 21);
            this.skinLabel6.TabIndex = 0;
            this.skinLabel6.Text = "新房价:";
            this.skinLabel6.Click += new System.EventHandler(this.skinLabel6_Click);
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(280, 98);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(78, 21);
            this.skinLabel7.TabIndex = 0;
            this.skinLabel7.Text = "预离时间:";
            this.skinLabel7.Click += new System.EventHandler(this.skinLabel6_Click);
            // 
            // tpYuLi
            // 
            this.tpYuLi.CalendarFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tpYuLi.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.tpYuLi.Enabled = false;
            this.tpYuLi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tpYuLi.Location = new System.Drawing.Point(365, 98);
            this.tpYuLi.Name = "tpYuLi";
            this.tpYuLi.ShowUpDown = true;
            this.tpYuLi.Size = new System.Drawing.Size(172, 21);
            this.tpYuLi.TabIndex = 5;
            // 
            // skinLabel8
            // 
            this.skinLabel8.AutoSize = true;
            this.skinLabel8.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel8.BorderColor = System.Drawing.Color.White;
            this.skinLabel8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel8.Location = new System.Drawing.Point(312, 134);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(46, 21);
            this.skinLabel8.TabIndex = 0;
            this.skinLabel8.Text = "备注:";
            // 
            // tbBeiZhu
            // 
            this.tbBeiZhu.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbBeiZhu.Location = new System.Drawing.Point(364, 128);
            this.tbBeiZhu.Name = "tbBeiZhu";
            this.tbBeiZhu.Size = new System.Drawing.Size(173, 26);
            this.tbBeiZhu.TabIndex = 3;
            this.tbBeiZhu.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbBeiZhu.WaterText = "";
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = null;
            this.skinButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton2.Location = new System.Drawing.Point(447, 164);
            this.skinButton2.MouseBack = null;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.Size = new System.Drawing.Size(90, 32);
            this.skinButton2.TabIndex = 2;
            this.skinButton2.Text = "退  出";
            this.skinButton2.UseVisualStyleBackColor = false;
            this.skinButton2.Click += new System.EventHandler(this.skinButton2_Click);
            // 
            // skinLabel9
            // 
            this.skinLabel9.AutoSize = true;
            this.skinLabel9.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel9.BorderColor = System.Drawing.Color.White;
            this.skinLabel9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel9.Location = new System.Drawing.Point(28, 164);
            this.skinLabel9.Name = "skinLabel9";
            this.skinLabel9.Size = new System.Drawing.Size(62, 21);
            this.skinLabel9.TabIndex = 0;
            this.skinLabel9.Text = "补差价:";
            // 
            // tbChaJia
            // 
            this.tbChaJia.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbChaJia.Location = new System.Drawing.Point(96, 159);
            this.tbChaJia.Name = "tbChaJia";
            this.tbChaJia.Size = new System.Drawing.Size(173, 26);
            this.tbChaJia.TabIndex = 3;
            this.tbChaJia.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbChaJia.WaterText = "";
            // 
            // cbYuanJia
            // 
            this.cbYuanJia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbYuanJia.Enabled = false;
            this.cbYuanJia.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbYuanJia.FormattingEnabled = true;
            this.cbYuanJia.Location = new System.Drawing.Point(96, 59);
            this.cbYuanJia.Name = "cbYuanJia";
            this.cbYuanJia.Size = new System.Drawing.Size(173, 27);
            this.cbYuanJia.TabIndex = 4;
            this.cbYuanJia.WaterText = "";
            // 
            // cbXinJia
            // 
            this.cbXinJia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbXinJia.Enabled = false;
            this.cbXinJia.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbXinJia.FormattingEnabled = true;
            this.cbXinJia.Location = new System.Drawing.Point(365, 62);
            this.cbXinJia.Name = "cbXinJia";
            this.cbXinJia.Size = new System.Drawing.Size(173, 27);
            this.cbXinJia.TabIndex = 4;
            this.cbXinJia.WaterText = "";
            this.cbXinJia.SelectedIndexChanged += new System.EventHandler(this.cbXingFang_SelectedIndexChanged);
            // 
            // skinButton3
            // 
            this.skinButton3.BackColor = System.Drawing.Color.Transparent;
            this.skinButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton3.DownBack = null;
            this.skinButton3.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton3.Location = new System.Drawing.Point(272, 27);
            this.skinButton3.MouseBack = null;
            this.skinButton3.Name = "skinButton3";
            this.skinButton3.NormlBack = null;
            this.skinButton3.Size = new System.Drawing.Size(24, 23);
            this.skinButton3.TabIndex = 6;
            this.skinButton3.Text = "ok";
            this.skinButton3.UseVisualStyleBackColor = false;
            this.skinButton3.Click += new System.EventHandler(this.skinButton3_Click);
            // 
            // ExchangeHouses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = global::S1Hotel.Properties.Resources.OIP4;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(105)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(561, 209);
            this.Controls.Add(this.skinButton3);
            this.Controls.Add(this.tpYuLi);
            this.Controls.Add(this.cbXinJia);
            this.Controls.Add(this.cbXingFang);
            this.Controls.Add(this.cbYuanJia);
            this.Controls.Add(this.cbYuanFang);
            this.Controls.Add(this.tbBeiZhu);
            this.Controls.Add(this.tbChaJia);
            this.Controls.Add(this.tbYiJiao);
            this.Controls.Add(this.tbRuZhu);
            this.Controls.Add(this.skinButton2);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.skinLabel8);
            this.Controls.Add(this.skinLabel9);
            this.Controls.Add(this.skinLabel5);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.skinLabel7);
            this.Controls.Add(this.skinLabel6);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ExchangeHouses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "换 房";
            this.Load += new System.EventHandler(this.ExchangeHouses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinComboBox cbYuanFang;
        private CCWin.SkinControl.SkinComboBox cbXingFang;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinWaterTextBox tbRuZhu;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinWaterTextBox tbYiJiao;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private System.Windows.Forms.DateTimePicker tpYuLi;
        private CCWin.SkinControl.SkinLabel skinLabel8;
        private CCWin.SkinControl.SkinWaterTextBox tbBeiZhu;
        private CCWin.SkinControl.SkinButton skinButton2;
        private CCWin.SkinControl.SkinLabel skinLabel9;
        private CCWin.SkinControl.SkinWaterTextBox tbChaJia;
        private CCWin.SkinControl.SkinComboBox cbYuanJia;
        private CCWin.SkinControl.SkinComboBox cbXinJia;
        private CCWin.SkinControl.SkinButton skinButton3;
    }
}