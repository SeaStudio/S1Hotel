namespace S1Hotel
{
    partial class ModifyRoomStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyRoomStatus));
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.cbZhuangTai = new CCWin.SkinControl.SkinComboBox();
            this.cbFangHao = new CCWin.SkinControl.SkinComboBox();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(22, 63);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(55, 25);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "房号:";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(22, 115);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(55, 25);
            this.skinLabel2.TabIndex = 0;
            this.skinLabel2.Text = "状态:";
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Location = new System.Drawing.Point(47, 164);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton1.Size = new System.Drawing.Size(181, 46);
            this.skinButton1.TabIndex = 3;
            this.skinButton1.Text = "修    改";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // cbZhuangTai
            // 
            this.cbZhuangTai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbZhuangTai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbZhuangTai.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbZhuangTai.FormattingEnabled = true;
            this.cbZhuangTai.Items.AddRange(new object[] {
            "空净",
            "占用",
            "空脏",
            "预定",
            "停用"});
            this.cbZhuangTai.Location = new System.Drawing.Point(82, 116);
            this.cbZhuangTai.Name = "cbZhuangTai";
            this.cbZhuangTai.Size = new System.Drawing.Size(146, 30);
            this.cbZhuangTai.TabIndex = 2;
            this.cbZhuangTai.WaterText = "";
            // 
            // cbFangHao
            // 
            this.cbFangHao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFangHao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFangHao.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbFangHao.FormattingEnabled = true;
            this.cbFangHao.Location = new System.Drawing.Point(82, 63);
            this.cbFangHao.Name = "cbFangHao";
            this.cbFangHao.Size = new System.Drawing.Size(146, 30);
            this.cbFangHao.TabIndex = 1;
            this.cbFangHao.WaterText = "";
            // 
            // ModifyRoomStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = global::S1Hotel.Properties.Resources.OIP__29_;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(91)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(268, 242);
            this.Controls.Add(this.cbFangHao);
            this.Controls.Add(this.cbZhuangTai);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ModifyRoomStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改房间状态";
            this.Load += new System.EventHandler(this.ModifyRoomStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinComboBox cbZhuangTai;
        private CCWin.SkinControl.SkinComboBox cbFangHao;
    }
}