namespace S1Hotel
{
    partial class CommodityManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommodityManagement));
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.lvShangPing = new CCWin.SkinControl.SkinListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmCaiDan = new CCWin.SkinControl.SkinContextMenuStrip();
            this.删除商品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skinGroupBox2 = new CCWin.SkinControl.SkinGroupBox();
            this.cbFuKuangFangShi = new CCWin.SkinControl.SkinComboBox();
            this.tbShiShou = new CCWin.SkinControl.SkinWaterTextBox();
            this.tbZhaoLing = new CCWin.SkinControl.SkinWaterTextBox();
            this.tbHeJi = new CCWin.SkinControl.SkinWaterTextBox();
            this.btJieZhang = new CCWin.SkinControl.SkinButton();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.lvGouWuChe = new CCWin.SkinControl.SkinListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.skinMenuStrip1 = new CCWin.SkinControl.SkinMenuStrip();
            this.添加商品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改商品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skinGroupBox1.SuspendLayout();
            this.cmCaiDan.SuspendLayout();
            this.skinGroupBox2.SuspendLayout();
            this.skinMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.Black;
            this.skinGroupBox1.Controls.Add(this.lvShangPing);
            this.skinGroupBox1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBox1.ForeColor = System.Drawing.Color.White;
            this.skinGroupBox1.Location = new System.Drawing.Point(4, 59);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(482, 506);
            this.skinGroupBox1.TabIndex = 1;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.Text = "商 品 信 息";
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.Black;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.DeepSkyBlue;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // lvShangPing
            // 
            this.lvShangPing.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvShangPing.ContextMenuStrip = this.cmCaiDan;
            this.lvShangPing.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvShangPing.FullRowSelect = true;
            this.lvShangPing.GridLines = true;
            this.lvShangPing.HideSelection = false;
            this.lvShangPing.Location = new System.Drawing.Point(6, 32);
            this.lvShangPing.MultiSelect = false;
            this.lvShangPing.Name = "lvShangPing";
            this.lvShangPing.OwnerDraw = true;
            this.lvShangPing.Size = new System.Drawing.Size(465, 468);
            this.lvShangPing.TabIndex = 0;
            this.lvShangPing.UseCompatibleStateImageBehavior = false;
            this.lvShangPing.View = System.Windows.Forms.View.Details;
            this.lvShangPing.SelectedIndexChanged += new System.EventHandler(this.lvShangPing_SelectedIndexChanged);
            this.lvShangPing.DoubleClick += new System.EventHandler(this.lvShangPing_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "商品名称";
            this.columnHeader1.Width = 113;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "商品类型";
            this.columnHeader2.Width = 107;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "单位";
            this.columnHeader3.Width = 73;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "库存量";
            this.columnHeader4.Width = 94;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "价格";
            this.columnHeader5.Width = 69;
            // 
            // cmCaiDan
            // 
            this.cmCaiDan.Arrow = System.Drawing.Color.Black;
            this.cmCaiDan.Back = System.Drawing.Color.White;
            this.cmCaiDan.BackRadius = 4;
            this.cmCaiDan.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.cmCaiDan.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.cmCaiDan.Fore = System.Drawing.Color.Black;
            this.cmCaiDan.HoverFore = System.Drawing.Color.White;
            this.cmCaiDan.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmCaiDan.ItemAnamorphosis = true;
            this.cmCaiDan.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.cmCaiDan.ItemBorderShow = true;
            this.cmCaiDan.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.cmCaiDan.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.cmCaiDan.ItemRadius = 4;
            this.cmCaiDan.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.cmCaiDan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除商品ToolStripMenuItem});
            this.cmCaiDan.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.cmCaiDan.Name = "cmCaiDan";
            this.cmCaiDan.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.cmCaiDan.Size = new System.Drawing.Size(125, 26);
            this.cmCaiDan.SkinAllColor = true;
            this.cmCaiDan.TitleAnamorphosis = true;
            this.cmCaiDan.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.cmCaiDan.TitleRadius = 4;
            this.cmCaiDan.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // 删除商品ToolStripMenuItem
            // 
            this.删除商品ToolStripMenuItem.Name = "删除商品ToolStripMenuItem";
            this.删除商品ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除商品ToolStripMenuItem.Text = "删除商品";
            this.删除商品ToolStripMenuItem.Click += new System.EventHandler(this.删除商品ToolStripMenuItem_Click);
            // 
            // skinGroupBox2
            // 
            this.skinGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox2.BorderColor = System.Drawing.Color.Black;
            this.skinGroupBox2.Controls.Add(this.cbFuKuangFangShi);
            this.skinGroupBox2.Controls.Add(this.tbShiShou);
            this.skinGroupBox2.Controls.Add(this.tbZhaoLing);
            this.skinGroupBox2.Controls.Add(this.tbHeJi);
            this.skinGroupBox2.Controls.Add(this.btJieZhang);
            this.skinGroupBox2.Controls.Add(this.skinLabel4);
            this.skinGroupBox2.Controls.Add(this.skinLabel2);
            this.skinGroupBox2.Controls.Add(this.skinLabel3);
            this.skinGroupBox2.Controls.Add(this.skinLabel1);
            this.skinGroupBox2.Controls.Add(this.lvGouWuChe);
            this.skinGroupBox2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBox2.ForeColor = System.Drawing.Color.White;
            this.skinGroupBox2.Location = new System.Drawing.Point(492, 59);
            this.skinGroupBox2.Name = "skinGroupBox2";
            this.skinGroupBox2.RectBackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox2.Size = new System.Drawing.Size(482, 506);
            this.skinGroupBox2.TabIndex = 1;
            this.skinGroupBox2.TabStop = false;
            this.skinGroupBox2.Text = "购 物 车";
            this.skinGroupBox2.TitleBorderColor = System.Drawing.Color.Black;
            this.skinGroupBox2.TitleRectBackColor = System.Drawing.Color.DeepSkyBlue;
            this.skinGroupBox2.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // cbFuKuangFangShi
            // 
            this.cbFuKuangFangShi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFuKuangFangShi.Enabled = false;
            this.cbFuKuangFangShi.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbFuKuangFangShi.FormattingEnabled = true;
            this.cbFuKuangFangShi.Items.AddRange(new object[] {
            "现金支付",
            "微信支付",
            "支付宝"});
            this.cbFuKuangFangShi.Location = new System.Drawing.Point(328, 428);
            this.cbFuKuangFangShi.Name = "cbFuKuangFangShi";
            this.cbFuKuangFangShi.Size = new System.Drawing.Size(143, 27);
            this.cbFuKuangFangShi.TabIndex = 4;
            this.cbFuKuangFangShi.Text = "现金支付";
            this.cbFuKuangFangShi.WaterText = "";
            // 
            // tbShiShou
            // 
            this.tbShiShou.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbShiShou.Location = new System.Drawing.Point(328, 385);
            this.tbShiShou.Name = "tbShiShou";
            this.tbShiShou.Size = new System.Drawing.Size(143, 26);
            this.tbShiShou.TabIndex = 3;
            this.tbShiShou.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbShiShou.WaterText = "";
            this.tbShiShou.TextChanged += new System.EventHandler(this.tbShiShou_TextChanged);
            this.tbShiShou.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbShiShou_KeyPress);
            // 
            // tbZhaoLing
            // 
            this.tbZhaoLing.Enabled = false;
            this.tbZhaoLing.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbZhaoLing.Location = new System.Drawing.Point(63, 431);
            this.tbZhaoLing.Name = "tbZhaoLing";
            this.tbZhaoLing.Size = new System.Drawing.Size(159, 26);
            this.tbZhaoLing.TabIndex = 3;
            this.tbZhaoLing.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbZhaoLing.WaterText = "";
            // 
            // tbHeJi
            // 
            this.tbHeJi.Enabled = false;
            this.tbHeJi.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbHeJi.Location = new System.Drawing.Point(63, 385);
            this.tbHeJi.Name = "tbHeJi";
            this.tbHeJi.Size = new System.Drawing.Size(159, 26);
            this.tbHeJi.TabIndex = 3;
            this.tbHeJi.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbHeJi.WaterText = "";
            // 
            // btJieZhang
            // 
            this.btJieZhang.BackColor = System.Drawing.Color.Transparent;
            this.btJieZhang.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btJieZhang.DownBack = null;
            this.btJieZhang.Enabled = false;
            this.btJieZhang.Location = new System.Drawing.Point(328, 461);
            this.btJieZhang.MouseBack = null;
            this.btJieZhang.Name = "btJieZhang";
            this.btJieZhang.NormlBack = null;
            this.btJieZhang.Size = new System.Drawing.Size(143, 39);
            this.btJieZhang.TabIndex = 2;
            this.btJieZhang.Text = "结 账";
            this.btJieZhang.UseVisualStyleBackColor = false;
            this.btJieZhang.Click += new System.EventHandler(this.skinButton2_Click);
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.ForeColor = System.Drawing.Color.Black;
            this.skinLabel4.Location = new System.Drawing.Point(244, 431);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(78, 21);
            this.skinLabel4.TabIndex = 1;
            this.skinLabel4.Text = "付款方式:";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.ForeColor = System.Drawing.Color.Black;
            this.skinLabel2.Location = new System.Drawing.Point(271, 387);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(51, 21);
            this.skinLabel2.TabIndex = 1;
            this.skinLabel2.Text = "实 收:";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.ForeColor = System.Drawing.Color.Black;
            this.skinLabel3.Location = new System.Drawing.Point(6, 433);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(51, 21);
            this.skinLabel3.TabIndex = 1;
            this.skinLabel3.Text = "找 零:";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.Color.Black;
            this.skinLabel1.Location = new System.Drawing.Point(6, 387);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(51, 21);
            this.skinLabel1.TabIndex = 1;
            this.skinLabel1.Text = "合 计:";
            // 
            // lvGouWuChe
            // 
            this.lvGouWuChe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lvGouWuChe.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvGouWuChe.FullRowSelect = true;
            this.lvGouWuChe.GridLines = true;
            this.lvGouWuChe.HideSelection = false;
            this.lvGouWuChe.Location = new System.Drawing.Point(6, 32);
            this.lvGouWuChe.Name = "lvGouWuChe";
            this.lvGouWuChe.OwnerDraw = true;
            this.lvGouWuChe.Size = new System.Drawing.Size(465, 343);
            this.lvGouWuChe.TabIndex = 0;
            this.lvGouWuChe.UseCompatibleStateImageBehavior = false;
            this.lvGouWuChe.View = System.Windows.Forms.View.Details;
            this.lvGouWuChe.SelectedIndexChanged += new System.EventHandler(this.lvGouWuChe_SelectedIndexChanged);
            this.lvGouWuChe.DoubleClick += new System.EventHandler(this.lvGouWuChe_DoubleClick);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "商品名称";
            this.columnHeader6.Width = 113;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "商品类型";
            this.columnHeader7.Width = 107;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "单位";
            this.columnHeader8.Width = 73;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "数量";
            this.columnHeader9.Width = 94;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "价格";
            this.columnHeader10.Width = 69;
            // 
            // skinMenuStrip1
            // 
            this.skinMenuStrip1.Arrow = System.Drawing.Color.Black;
            this.skinMenuStrip1.Back = System.Drawing.Color.White;
            this.skinMenuStrip1.BackRadius = 4;
            this.skinMenuStrip1.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.skinMenuStrip1.Base = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.skinMenuStrip1.BaseFore = System.Drawing.Color.Black;
            this.skinMenuStrip1.BaseForeAnamorphosis = false;
            this.skinMenuStrip1.BaseForeAnamorphosisBorder = 4;
            this.skinMenuStrip1.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.skinMenuStrip1.BaseHoverFore = System.Drawing.Color.White;
            this.skinMenuStrip1.BaseItemAnamorphosis = true;
            this.skinMenuStrip1.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemBorderShow = true;
            this.skinMenuStrip1.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinMenuStrip1.BaseItemDown")));
            this.skinMenuStrip1.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinMenuStrip1.BaseItemMouse")));
            this.skinMenuStrip1.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemRadius = 4;
            this.skinMenuStrip1.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinMenuStrip1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinMenuStrip1.Fore = System.Drawing.Color.Black;
            this.skinMenuStrip1.HoverFore = System.Drawing.Color.White;
            this.skinMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.skinMenuStrip1.ItemAnamorphosis = true;
            this.skinMenuStrip1.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemBorderShow = true;
            this.skinMenuStrip1.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemRadius = 4;
            this.skinMenuStrip1.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加商品ToolStripMenuItem,
            this.修改商品ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.skinMenuStrip1.Location = new System.Drawing.Point(4, 28);
            this.skinMenuStrip1.Name = "skinMenuStrip1";
            this.skinMenuStrip1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.Size = new System.Drawing.Size(979, 28);
            this.skinMenuStrip1.SkinAllColor = true;
            this.skinMenuStrip1.TabIndex = 0;
            this.skinMenuStrip1.Text = "skinMenuStrip1";
            this.skinMenuStrip1.TitleAnamorphosis = true;
            this.skinMenuStrip1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinMenuStrip1.TitleRadius = 4;
            this.skinMenuStrip1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // 添加商品ToolStripMenuItem
            // 
            this.添加商品ToolStripMenuItem.Name = "添加商品ToolStripMenuItem";
            this.添加商品ToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.添加商品ToolStripMenuItem.Text = "添加商品";
            this.添加商品ToolStripMenuItem.Click += new System.EventHandler(this.添加商品ToolStripMenuItem_Click);
            // 
            // 修改商品ToolStripMenuItem
            // 
            this.修改商品ToolStripMenuItem.Name = "修改商品ToolStripMenuItem";
            this.修改商品ToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.修改商品ToolStripMenuItem.Text = "修改商品";
            this.修改商品ToolStripMenuItem.Click += new System.EventHandler(this.修改商品ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // CommodityManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = global::S1Hotel.Properties.Resources.OIP__19_2;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(108)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(987, 596);
            this.Controls.Add(this.skinGroupBox2);
            this.Controls.Add(this.skinGroupBox1);
            this.Controls.Add(this.skinMenuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.skinMenuStrip1;
            this.MaximizeBox = false;
            this.Name = "CommodityManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "商 品 管 理";
            this.Load += new System.EventHandler(this.CommodityManagement_Load);
            this.skinGroupBox1.ResumeLayout(false);
            this.cmCaiDan.ResumeLayout(false);
            this.skinGroupBox2.ResumeLayout(false);
            this.skinGroupBox2.PerformLayout();
            this.skinMenuStrip1.ResumeLayout(false);
            this.skinMenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinMenuStrip skinMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加商品ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改商品ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private CCWin.SkinControl.SkinListView lvShangPing;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox2;
        private CCWin.SkinControl.SkinWaterTextBox tbShiShou;
        private CCWin.SkinControl.SkinWaterTextBox tbHeJi;
        private CCWin.SkinControl.SkinButton btJieZhang;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinListView lvGouWuChe;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private CCWin.SkinControl.SkinWaterTextBox tbZhaoLing;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinContextMenuStrip cmCaiDan;
        private System.Windows.Forms.ToolStripMenuItem 删除商品ToolStripMenuItem;
        private CCWin.SkinControl.SkinComboBox cbFuKuangFangShi;
        private CCWin.SkinControl.SkinLabel skinLabel4;
    }
}