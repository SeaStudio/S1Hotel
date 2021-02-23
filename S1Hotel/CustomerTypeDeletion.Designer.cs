namespace S1Hotel
{
    partial class CustomerTypeDeletion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerTypeDeletion));
            this.skinGroupBox2 = new CCWin.SkinControl.SkinGroupBox();
            this.cbZheKou = new CCWin.SkinControl.SkinComboBox();
            this.cbLeiXing = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.skinButton4 = new CCWin.SkinControl.SkinButton();
            this.skinGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinGroupBox2
            // 
            this.skinGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox2.BorderColor = System.Drawing.Color.Black;
            this.skinGroupBox2.Controls.Add(this.cbZheKou);
            this.skinGroupBox2.Controls.Add(this.cbLeiXing);
            this.skinGroupBox2.Controls.Add(this.skinLabel7);
            this.skinGroupBox2.Controls.Add(this.skinLabel8);
            this.skinGroupBox2.Controls.Add(this.skinButton4);
            this.skinGroupBox2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBox2.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBox2.Location = new System.Drawing.Point(7, 31);
            this.skinGroupBox2.Name = "skinGroupBox2";
            this.skinGroupBox2.RectBackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox2.Size = new System.Drawing.Size(223, 163);
            this.skinGroupBox2.TabIndex = 1;
            this.skinGroupBox2.TabStop = false;
            this.skinGroupBox2.Text = "删 除 类 型";
            this.skinGroupBox2.TitleBorderColor = System.Drawing.Color.Black;
            this.skinGroupBox2.TitleRectBackColor = System.Drawing.Color.DeepSkyBlue;
            this.skinGroupBox2.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // cbZheKou
            // 
            this.cbZheKou.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbZheKou.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbZheKou.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbZheKou.FormattingEnabled = true;
            this.cbZheKou.Location = new System.Drawing.Point(70, 85);
            this.cbZheKou.Name = "cbZheKou";
            this.cbZheKou.Size = new System.Drawing.Size(138, 27);
            this.cbZheKou.TabIndex = 1;
            this.cbZheKou.WaterText = "";
            // 
            // cbLeiXing
            // 
            this.cbLeiXing.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLeiXing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLeiXing.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbLeiXing.FormattingEnabled = true;
            this.cbLeiXing.Location = new System.Drawing.Point(70, 42);
            this.cbLeiXing.Name = "cbLeiXing";
            this.cbLeiXing.Size = new System.Drawing.Size(138, 27);
            this.cbLeiXing.TabIndex = 0;
            this.cbLeiXing.WaterText = "";
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(18, 46);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(46, 21);
            this.skinLabel7.TabIndex = 7;
            this.skinLabel7.Text = "类型:";
            // 
            // skinLabel8
            // 
            this.skinLabel8.AutoSize = true;
            this.skinLabel8.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel8.BorderColor = System.Drawing.Color.White;
            this.skinLabel8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel8.Location = new System.Drawing.Point(18, 88);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(46, 21);
            this.skinLabel8.TabIndex = 6;
            this.skinLabel8.Text = "折扣:";
            // 
            // skinButton4
            // 
            this.skinButton4.BackColor = System.Drawing.Color.Transparent;
            this.skinButton4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton4.DownBack = null;
            this.skinButton4.Location = new System.Drawing.Point(70, 118);
            this.skinButton4.MouseBack = null;
            this.skinButton4.Name = "skinButton4";
            this.skinButton4.NormlBack = null;
            this.skinButton4.Radius = 20;
            this.skinButton4.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton4.Size = new System.Drawing.Size(138, 35);
            this.skinButton4.TabIndex = 2;
            this.skinButton4.Text = "删  除";
            this.skinButton4.UseVisualStyleBackColor = false;
            this.skinButton4.Click += new System.EventHandler(this.skinButton4_Click);
            // 
            // CustomerTypeDeletion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = global::S1Hotel.Properties.Resources.OIP__14_1;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(128)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(244, 207);
            this.Controls.Add(this.skinGroupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CustomerTypeDeletion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "删 除 类 型";
            this.Load += new System.EventHandler(this.CustomerTypeDeletion_Load);
            this.skinGroupBox2.ResumeLayout(false);
            this.skinGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinGroupBox skinGroupBox2;
        private CCWin.SkinControl.SkinComboBox cbZheKou;
        private CCWin.SkinControl.SkinComboBox cbLeiXing;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.SkinLabel skinLabel8;
        private CCWin.SkinControl.SkinButton skinButton4;
    }
}