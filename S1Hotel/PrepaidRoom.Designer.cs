namespace S1Hotel
{
    partial class PrepaidRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrepaidRoom));
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.cbLeiXing = new CCWin.SkinControl.SkinComboBox();
            this.tpYuLi = new System.Windows.Forms.DateTimePicker();
            this.tpRuZhu = new System.Windows.Forms.DateTimePicker();
            this.txtBeiZhu = new CCWin.SkinControl.SkinWaterTextBox();
            this.txtXingMing = new CCWin.SkinControl.SkinWaterTextBox();
            this.txtDianHua = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinGroupBox2 = new CCWin.SkinControl.SkinGroupBox();
            this.lvKongJingFang = new CCWin.SkinControl.SkinListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.skinGroupBox3 = new CCWin.SkinControl.SkinGroupBox();
            this.lvYiXuang = new CCWin.SkinControl.SkinListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.skinGroupBox4 = new CCWin.SkinControl.SkinGroupBox();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.tbDingDanHao = new CCWin.SkinControl.SkinWaterTextBox();
            this.tbZongJia = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinGroupBox1.SuspendLayout();
            this.skinGroupBox2.SuspendLayout();
            this.skinGroupBox3.SuspendLayout();
            this.skinGroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.Black;
            this.skinGroupBox1.Controls.Add(this.cbLeiXing);
            this.skinGroupBox1.Controls.Add(this.tpYuLi);
            this.skinGroupBox1.Controls.Add(this.tpRuZhu);
            this.skinGroupBox1.Controls.Add(this.txtBeiZhu);
            this.skinGroupBox1.Controls.Add(this.txtXingMing);
            this.skinGroupBox1.Controls.Add(this.txtDianHua);
            this.skinGroupBox1.Controls.Add(this.skinLabel7);
            this.skinGroupBox1.Controls.Add(this.skinLabel6);
            this.skinGroupBox1.Controls.Add(this.skinLabel5);
            this.skinGroupBox1.Controls.Add(this.skinLabel3);
            this.skinGroupBox1.Controls.Add(this.skinLabel2);
            this.skinGroupBox1.Controls.Add(this.skinLabel1);
            this.skinGroupBox1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBox1.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBox1.Location = new System.Drawing.Point(7, 31);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(267, 324);
            this.skinGroupBox1.TabIndex = 0;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.Text = "顾客信息";
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.Black;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.DeepSkyBlue;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // cbLeiXing
            // 
            this.cbLeiXing.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLeiXing.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbLeiXing.FormattingEnabled = true;
            this.cbLeiXing.Location = new System.Drawing.Point(97, 125);
            this.cbLeiXing.Name = "cbLeiXing";
            this.cbLeiXing.Size = new System.Drawing.Size(157, 24);
            this.cbLeiXing.TabIndex = 9;
            this.cbLeiXing.WaterText = "";
            this.cbLeiXing.SelectedIndexChanged += new System.EventHandler(this.cbFangJianLeiXing_SelectedIndexChanged);
            // 
            // tpYuLi
            // 
            this.tpYuLi.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.tpYuLi.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tpYuLi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tpYuLi.Location = new System.Drawing.Point(98, 206);
            this.tpYuLi.Name = "tpYuLi";
            this.tpYuLi.Size = new System.Drawing.Size(156, 23);
            this.tpYuLi.TabIndex = 8;
            this.tpYuLi.ValueChanged += new System.EventHandler(this.tpYuLi_ValueChanged);
            // 
            // tpRuZhu
            // 
            this.tpRuZhu.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.tpRuZhu.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tpRuZhu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tpRuZhu.Location = new System.Drawing.Point(98, 163);
            this.tpRuZhu.Name = "tpRuZhu";
            this.tpRuZhu.Size = new System.Drawing.Size(156, 23);
            this.tpRuZhu.TabIndex = 8;
            this.tpRuZhu.ValueChanged += new System.EventHandler(this.tpRuZhu_ValueChanged);
            // 
            // txtBeiZhu
            // 
            this.txtBeiZhu.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBeiZhu.Location = new System.Drawing.Point(97, 248);
            this.txtBeiZhu.Multiline = true;
            this.txtBeiZhu.Name = "txtBeiZhu";
            this.txtBeiZhu.Size = new System.Drawing.Size(157, 62);
            this.txtBeiZhu.TabIndex = 7;
            this.txtBeiZhu.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtBeiZhu.WaterText = "";
            // 
            // txtXingMing
            // 
            this.txtXingMing.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtXingMing.Location = new System.Drawing.Point(98, 34);
            this.txtXingMing.Name = "txtXingMing";
            this.txtXingMing.Size = new System.Drawing.Size(156, 23);
            this.txtXingMing.TabIndex = 7;
            this.txtXingMing.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtXingMing.WaterText = "";
            // 
            // txtDianHua
            // 
            this.txtDianHua.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDianHua.Location = new System.Drawing.Point(98, 81);
            this.txtDianHua.Name = "txtDianHua";
            this.txtDianHua.Size = new System.Drawing.Size(156, 23);
            this.txtDianHua.TabIndex = 7;
            this.txtDianHua.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtDianHua.WaterText = "";
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(11, 207);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(90, 21);
            this.skinLabel7.TabIndex = 1;
            this.skinLabel7.Text = "预离时间：";
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(11, 163);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(90, 21);
            this.skinLabel6.TabIndex = 2;
            this.skinLabel6.Text = "预住时间：";
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(43, 246);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(58, 21);
            this.skinLabel5.TabIndex = 3;
            this.skinLabel5.Text = "备注：";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(11, 127);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(90, 21);
            this.skinLabel3.TabIndex = 4;
            this.skinLabel3.Text = "房间类型：";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(43, 81);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(58, 21);
            this.skinLabel2.TabIndex = 5;
            this.skinLabel2.Text = "电话：";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(45, 35);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(46, 21);
            this.skinLabel1.TabIndex = 6;
            this.skinLabel1.Text = "姓名:";
            // 
            // skinGroupBox2
            // 
            this.skinGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox2.BorderColor = System.Drawing.Color.Black;
            this.skinGroupBox2.Controls.Add(this.lvKongJingFang);
            this.skinGroupBox2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBox2.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBox2.Location = new System.Drawing.Point(280, 31);
            this.skinGroupBox2.Name = "skinGroupBox2";
            this.skinGroupBox2.RectBackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox2.Size = new System.Drawing.Size(267, 324);
            this.skinGroupBox2.TabIndex = 0;
            this.skinGroupBox2.TabStop = false;
            this.skinGroupBox2.Text = "可预定房";
            this.skinGroupBox2.TitleBorderColor = System.Drawing.Color.Black;
            this.skinGroupBox2.TitleRectBackColor = System.Drawing.Color.DeepSkyBlue;
            this.skinGroupBox2.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // lvKongJingFang
            // 
            this.lvKongJingFang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(188)))), ((int)(((byte)(254)))));
            this.lvKongJingFang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvKongJingFang.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvKongJingFang.FullRowSelect = true;
            this.lvKongJingFang.GridLines = true;
            this.lvKongJingFang.HideSelection = false;
            this.lvKongJingFang.Location = new System.Drawing.Point(7, 25);
            this.lvKongJingFang.Name = "lvKongJingFang";
            this.lvKongJingFang.OwnerDraw = true;
            this.lvKongJingFang.Size = new System.Drawing.Size(254, 293);
            this.lvKongJingFang.TabIndex = 1;
            this.lvKongJingFang.UseCompatibleStateImageBehavior = false;
            this.lvKongJingFang.View = System.Windows.Forms.View.Details;
            this.lvKongJingFang.DoubleClick += new System.EventHandler(this.lvKongJingFang_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "房间编号";
            this.columnHeader1.Width = 78;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "房间类型";
            this.columnHeader2.Width = 91;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "房间价格";
            this.columnHeader3.Width = 98;
            // 
            // skinGroupBox3
            // 
            this.skinGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox3.BorderColor = System.Drawing.Color.Black;
            this.skinGroupBox3.Controls.Add(this.lvYiXuang);
            this.skinGroupBox3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBox3.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBox3.Location = new System.Drawing.Point(553, 31);
            this.skinGroupBox3.Name = "skinGroupBox3";
            this.skinGroupBox3.RectBackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox3.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox3.Size = new System.Drawing.Size(301, 324);
            this.skinGroupBox3.TabIndex = 0;
            this.skinGroupBox3.TabStop = false;
            this.skinGroupBox3.Text = "已选预定房";
            this.skinGroupBox3.TitleBorderColor = System.Drawing.Color.Black;
            this.skinGroupBox3.TitleRectBackColor = System.Drawing.Color.DeepSkyBlue;
            this.skinGroupBox3.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // lvYiXuang
            // 
            this.lvYiXuang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(188)))), ((int)(((byte)(254)))));
            this.lvYiXuang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvYiXuang.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvYiXuang.FullRowSelect = true;
            this.lvYiXuang.GridLines = true;
            this.lvYiXuang.HideSelection = false;
            this.lvYiXuang.Location = new System.Drawing.Point(7, 25);
            this.lvYiXuang.Name = "lvYiXuang";
            this.lvYiXuang.OwnerDraw = true;
            this.lvYiXuang.Size = new System.Drawing.Size(288, 293);
            this.lvYiXuang.TabIndex = 1;
            this.lvYiXuang.UseCompatibleStateImageBehavior = false;
            this.lvYiXuang.View = System.Windows.Forms.View.Details;
            this.lvYiXuang.DoubleClick += new System.EventHandler(this.lvYiXuang_DoubleClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "房间编号";
            this.columnHeader4.Width = 82;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "房间类型";
            this.columnHeader5.Width = 101;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "房间价格";
            this.columnHeader6.Width = 98;
            // 
            // skinGroupBox4
            // 
            this.skinGroupBox4.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox4.BorderColor = System.Drawing.Color.Black;
            this.skinGroupBox4.Controls.Add(this.skinButton2);
            this.skinGroupBox4.Controls.Add(this.skinButton1);
            this.skinGroupBox4.Controls.Add(this.skinLabel8);
            this.skinGroupBox4.Controls.Add(this.skinLabel4);
            this.skinGroupBox4.Controls.Add(this.tbDingDanHao);
            this.skinGroupBox4.Controls.Add(this.tbZongJia);
            this.skinGroupBox4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBox4.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBox4.Location = new System.Drawing.Point(7, 361);
            this.skinGroupBox4.Name = "skinGroupBox4";
            this.skinGroupBox4.RectBackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox4.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox4.Size = new System.Drawing.Size(847, 63);
            this.skinGroupBox4.TabIndex = 0;
            this.skinGroupBox4.TabStop = false;
            this.skinGroupBox4.Text = "订单信息";
            this.skinGroupBox4.TitleBorderColor = System.Drawing.Color.Black;
            this.skinGroupBox4.TitleRectBackColor = System.Drawing.Color.DeepSkyBlue;
            this.skinGroupBox4.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = null;
            this.skinButton2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton2.Location = new System.Drawing.Point(757, 26);
            this.skinButton2.MouseBack = null;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.Size = new System.Drawing.Size(75, 23);
            this.skinButton2.TabIndex = 9;
            this.skinButton2.Text = "退 出";
            this.skinButton2.UseVisualStyleBackColor = false;
            this.skinButton2.Click += new System.EventHandler(this.skinButton2_Click);
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton1.Location = new System.Drawing.Point(676, 26);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(75, 23);
            this.skinButton1.TabIndex = 9;
            this.skinButton1.Text = "确 定";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // skinLabel8
            // 
            this.skinLabel8.AutoSize = true;
            this.skinLabel8.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel8.BorderColor = System.Drawing.Color.White;
            this.skinLabel8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel8.Location = new System.Drawing.Point(43, 28);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(78, 21);
            this.skinLabel8.TabIndex = 7;
            this.skinLabel8.Text = "订单编号:";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(314, 29);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(78, 21);
            this.skinLabel4.TabIndex = 8;
            this.skinLabel4.Text = "房间总价:";
            // 
            // tbDingDanHao
            // 
            this.tbDingDanHao.Enabled = false;
            this.tbDingDanHao.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbDingDanHao.Location = new System.Drawing.Point(127, 27);
            this.tbDingDanHao.Name = "tbDingDanHao";
            this.tbDingDanHao.Size = new System.Drawing.Size(156, 23);
            this.tbDingDanHao.TabIndex = 7;
            this.tbDingDanHao.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbDingDanHao.WaterText = "";
            // 
            // tbZongJia
            // 
            this.tbZongJia.Enabled = false;
            this.tbZongJia.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbZongJia.Location = new System.Drawing.Point(398, 28);
            this.tbZongJia.Name = "tbZongJia";
            this.tbZongJia.Size = new System.Drawing.Size(156, 23);
            this.tbZongJia.TabIndex = 7;
            this.tbZongJia.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbZongJia.WaterText = "";
            // 
            // PrepaidRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = global::S1Hotel.Properties.Resources.OIP__4_2;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(111)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(861, 431);
            this.Controls.Add(this.skinGroupBox4);
            this.Controls.Add(this.skinGroupBox3);
            this.Controls.Add(this.skinGroupBox2);
            this.Controls.Add(this.skinGroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PrepaidRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "预 定 房 间";
            this.Load += new System.EventHandler(this.PrepaidRoom_Load);
            this.skinGroupBox1.ResumeLayout(false);
            this.skinGroupBox1.PerformLayout();
            this.skinGroupBox2.ResumeLayout(false);
            this.skinGroupBox3.ResumeLayout(false);
            this.skinGroupBox4.ResumeLayout(false);
            this.skinGroupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private System.Windows.Forms.DateTimePicker tpYuLi;
        private System.Windows.Forms.DateTimePicker tpRuZhu;
        private CCWin.SkinControl.SkinWaterTextBox txtBeiZhu;
        private CCWin.SkinControl.SkinWaterTextBox txtXingMing;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinWaterTextBox txtDianHua;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox2;
        private CCWin.SkinControl.SkinListView lvKongJingFang;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox3;
        private CCWin.SkinControl.SkinListView lvYiXuang;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox4;
        private CCWin.SkinControl.SkinButton skinButton2;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinLabel skinLabel8;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinWaterTextBox tbDingDanHao;
        private CCWin.SkinControl.SkinWaterTextBox tbZongJia;
        private CCWin.SkinControl.SkinComboBox cbLeiXing;

    }
}