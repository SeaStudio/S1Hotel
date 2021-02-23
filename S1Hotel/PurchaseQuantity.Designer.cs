namespace S1Hotel
{
    partial class PurchaseQuantity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseQuantity));
            this.tbShuLiang = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // tbShuLiang
            // 
            this.tbShuLiang.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbShuLiang.Location = new System.Drawing.Point(28, 31);
            this.tbShuLiang.Name = "tbShuLiang";
            this.tbShuLiang.Size = new System.Drawing.Size(133, 26);
            this.tbShuLiang.TabIndex = 1;
            this.tbShuLiang.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbShuLiang.WaterText = "请输入购买数量";
            this.tbShuLiang.TextChanged += new System.EventHandler(this.skinWaterTextBox1_TextChanged);
            this.tbShuLiang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbShuLiang_KeyPress);
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Location = new System.Drawing.Point(28, 63);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(134, 30);
            this.skinButton1.TabIndex = 2;
            this.skinButton1.Text = "确   定";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // PurchaseQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = global::S1Hotel.Properties.Resources.OIP__12_2;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(130)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(197, 111);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.tbShuLiang);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PurchaseQuantity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "购 买 数 量";
            this.Load += new System.EventHandler(this.PurchaseQuantity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinWaterTextBox tbShuLiang;
        private CCWin.SkinControl.SkinButton skinButton1;
    }
}