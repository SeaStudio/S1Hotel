namespace S1Hotel
{
    partial class StatisticalChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticalChart));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.skinGroupBox2 = new CCWin.SkinControl.SkinGroupBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.rbRi = new CCWin.SkinControl.SkinRadioButton();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.rbNian = new CCWin.SkinControl.SkinRadioButton();
            this.cbYue = new CCWin.SkinControl.SkinComboBox();
            this.rbYue = new CCWin.SkinControl.SkinRadioButton();
            this.textNian = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinGroupBox3 = new CCWin.SkinControl.SkinGroupBox();
            this.pbDaChengLv = new CCWin.SkinControl.SkinProgressBar();
            this.textShangPing = new CCWin.SkinControl.SkinWaterTextBox();
            this.textRiMuBiao = new CCWin.SkinControl.SkinWaterTextBox();
            this.textMuBiao = new CCWin.SkinControl.SkinWaterTextBox();
            this.txtYinLi = new CCWin.SkinControl.SkinWaterTextBox();
            this.textHeJi = new CCWin.SkinControl.SkinWaterTextBox();
            this.textChongZhi = new CCWin.SkinControl.SkinWaterTextBox();
            this.textFangJian = new CCWin.SkinControl.SkinWaterTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.skinGroupBox1.SuspendLayout();
            this.skinGroupBox2.SuspendLayout();
            this.skinGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 29);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(430, 453);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Angle = 45;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(6, 63);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(847, 419);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.Black;
            this.skinGroupBox1.Controls.Add(this.chart1);
            this.skinGroupBox1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBox1.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBox1.Location = new System.Drawing.Point(7, 31);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(447, 499);
            this.skinGroupBox1.TabIndex = 2;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.Text = "营收占比";
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.Black;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.DeepSkyBlue;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // skinGroupBox2
            // 
            this.skinGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox2.BorderColor = System.Drawing.Color.Black;
            this.skinGroupBox2.Controls.Add(this.skinLabel2);
            this.skinGroupBox2.Controls.Add(this.rbRi);
            this.skinGroupBox2.Controls.Add(this.skinLabel1);
            this.skinGroupBox2.Controls.Add(this.rbNian);
            this.skinGroupBox2.Controls.Add(this.cbYue);
            this.skinGroupBox2.Controls.Add(this.rbYue);
            this.skinGroupBox2.Controls.Add(this.textNian);
            this.skinGroupBox2.Controls.Add(this.chart2);
            this.skinGroupBox2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBox2.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBox2.Location = new System.Drawing.Point(460, 31);
            this.skinGroupBox2.Name = "skinGroupBox2";
            this.skinGroupBox2.RectBackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox2.Size = new System.Drawing.Size(859, 499);
            this.skinGroupBox2.TabIndex = 2;
            this.skinGroupBox2.TabStop = false;
            this.skinGroupBox2.Text = "条件查询";
            this.skinGroupBox2.TitleBorderColor = System.Drawing.Color.Black;
            this.skinGroupBox2.TitleRectBackColor = System.Drawing.Color.DeepSkyBlue;
            this.skinGroupBox2.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox2.Enter += new System.EventHandler(this.skinGroupBox2_Enter);
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(299, 30);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(26, 21);
            this.skinLabel2.TabIndex = 5;
            this.skinLabel2.Text = "月";
            // 
            // rbRi
            // 
            this.rbRi.AutoSize = true;
            this.rbRi.BackColor = System.Drawing.Color.Transparent;
            this.rbRi.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.rbRi.DownBack = null;
            this.rbRi.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbRi.Location = new System.Drawing.Point(615, 29);
            this.rbRi.MouseBack = null;
            this.rbRi.Name = "rbRi";
            this.rbRi.NormlBack = null;
            this.rbRi.SelectedDownBack = null;
            this.rbRi.SelectedMouseBack = null;
            this.rbRi.SelectedNormlBack = null;
            this.rbRi.Size = new System.Drawing.Size(97, 24);
            this.rbRi.TabIndex = 2;
            this.rbRi.Text = "按日度查询";
            this.rbRi.UseVisualStyleBackColor = false;
            this.rbRi.CheckedChanged += new System.EventHandler(this.rbRi_CheckedChanged);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(168, 30);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(26, 21);
            this.skinLabel1.TabIndex = 5;
            this.skinLabel1.Text = "年";
            // 
            // rbNian
            // 
            this.rbNian.AutoSize = true;
            this.rbNian.BackColor = System.Drawing.Color.Transparent;
            this.rbNian.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.rbNian.DownBack = null;
            this.rbNian.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbNian.Location = new System.Drawing.Point(365, 29);
            this.rbNian.MouseBack = null;
            this.rbNian.Name = "rbNian";
            this.rbNian.NormlBack = null;
            this.rbNian.SelectedDownBack = null;
            this.rbNian.SelectedMouseBack = null;
            this.rbNian.SelectedNormlBack = null;
            this.rbNian.Size = new System.Drawing.Size(97, 24);
            this.rbNian.TabIndex = 2;
            this.rbNian.Text = "按年度查询";
            this.rbNian.UseVisualStyleBackColor = false;
            this.rbNian.CheckedChanged += new System.EventHandler(this.rbNian_CheckedChanged);
            // 
            // cbYue
            // 
            this.cbYue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbYue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYue.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbYue.FormattingEnabled = true;
            this.cbYue.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbYue.Location = new System.Drawing.Point(198, 29);
            this.cbYue.Name = "cbYue";
            this.cbYue.Size = new System.Drawing.Size(95, 24);
            this.cbYue.TabIndex = 4;
            this.cbYue.WaterText = "";
            this.cbYue.SelectedIndexChanged += new System.EventHandler(this.cbYue_SelectedIndexChanged);
            // 
            // rbYue
            // 
            this.rbYue.AutoSize = true;
            this.rbYue.BackColor = System.Drawing.Color.Transparent;
            this.rbYue.Checked = true;
            this.rbYue.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.rbYue.DownBack = null;
            this.rbYue.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbYue.Location = new System.Drawing.Point(491, 29);
            this.rbYue.MouseBack = null;
            this.rbYue.Name = "rbYue";
            this.rbYue.NormlBack = null;
            this.rbYue.SelectedDownBack = null;
            this.rbYue.SelectedMouseBack = null;
            this.rbYue.SelectedNormlBack = null;
            this.rbYue.Size = new System.Drawing.Size(97, 24);
            this.rbYue.TabIndex = 2;
            this.rbYue.TabStop = true;
            this.rbYue.Text = "按月度查询";
            this.rbYue.UseVisualStyleBackColor = false;
            this.rbYue.CheckedChanged += new System.EventHandler(this.skinRadioButton1_CheckedChanged);
            // 
            // textNian
            // 
            this.textNian.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textNian.Location = new System.Drawing.Point(63, 30);
            this.textNian.Name = "textNian";
            this.textNian.Size = new System.Drawing.Size(100, 23);
            this.textNian.TabIndex = 3;
            this.textNian.Text = "2021";
            this.textNian.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textNian.WaterText = "";
            // 
            // skinGroupBox3
            // 
            this.skinGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox3.BorderColor = System.Drawing.Color.Black;
            this.skinGroupBox3.Controls.Add(this.pbDaChengLv);
            this.skinGroupBox3.Controls.Add(this.textShangPing);
            this.skinGroupBox3.Controls.Add(this.textRiMuBiao);
            this.skinGroupBox3.Controls.Add(this.textMuBiao);
            this.skinGroupBox3.Controls.Add(this.txtYinLi);
            this.skinGroupBox3.Controls.Add(this.textHeJi);
            this.skinGroupBox3.Controls.Add(this.textChongZhi);
            this.skinGroupBox3.Controls.Add(this.textFangJian);
            this.skinGroupBox3.Controls.Add(this.label7);
            this.skinGroupBox3.Controls.Add(this.label6);
            this.skinGroupBox3.Controls.Add(this.label5);
            this.skinGroupBox3.Controls.Add(this.label8);
            this.skinGroupBox3.Controls.Add(this.label4);
            this.skinGroupBox3.Controls.Add(this.label3);
            this.skinGroupBox3.Controls.Add(this.label2);
            this.skinGroupBox3.Controls.Add(this.label1);
            this.skinGroupBox3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBox3.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBox3.Location = new System.Drawing.Point(7, 536);
            this.skinGroupBox3.Name = "skinGroupBox3";
            this.skinGroupBox3.RectBackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox3.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox3.Size = new System.Drawing.Size(1306, 141);
            this.skinGroupBox3.TabIndex = 2;
            this.skinGroupBox3.TabStop = false;
            this.skinGroupBox3.Text = "目标达成";
            this.skinGroupBox3.TitleBorderColor = System.Drawing.Color.Black;
            this.skinGroupBox3.TitleRectBackColor = System.Drawing.Color.DeepSkyBlue;
            this.skinGroupBox3.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // pbDaChengLv
            // 
            this.pbDaChengLv.Back = null;
            this.pbDaChengLv.BackColor = System.Drawing.Color.Transparent;
            this.pbDaChengLv.BarBack = null;
            this.pbDaChengLv.BarRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.pbDaChengLv.ForeColor = System.Drawing.Color.Red;
            this.pbDaChengLv.Location = new System.Drawing.Point(1104, 88);
            this.pbDaChengLv.Name = "pbDaChengLv";
            this.pbDaChengLv.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.pbDaChengLv.Size = new System.Drawing.Size(167, 23);
            this.pbDaChengLv.TabIndex = 2;
            // 
            // textShangPing
            // 
            this.textShangPing.Enabled = false;
            this.textShangPing.Location = new System.Drawing.Point(466, 31);
            this.textShangPing.Name = "textShangPing";
            this.textShangPing.Size = new System.Drawing.Size(169, 30);
            this.textShangPing.TabIndex = 1;
            this.textShangPing.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textShangPing.WaterText = "";
            // 
            // textRiMuBiao
            // 
            this.textRiMuBiao.Enabled = false;
            this.textRiMuBiao.Location = new System.Drawing.Point(1104, 33);
            this.textRiMuBiao.Name = "textRiMuBiao";
            this.textRiMuBiao.Size = new System.Drawing.Size(169, 30);
            this.textRiMuBiao.TabIndex = 1;
            this.textRiMuBiao.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textRiMuBiao.WaterText = "";
            // 
            // textMuBiao
            // 
            this.textMuBiao.Location = new System.Drawing.Point(792, 31);
            this.textMuBiao.Name = "textMuBiao";
            this.textMuBiao.Size = new System.Drawing.Size(169, 30);
            this.textMuBiao.TabIndex = 1;
            this.textMuBiao.Text = "150000";
            this.textMuBiao.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textMuBiao.WaterText = "";
            this.textMuBiao.TextChanged += new System.EventHandler(this.textMuBiao_TextChanged);
            // 
            // txtYinLi
            // 
            this.txtYinLi.Enabled = false;
            this.txtYinLi.Location = new System.Drawing.Point(792, 88);
            this.txtYinLi.Name = "txtYinLi";
            this.txtYinLi.Size = new System.Drawing.Size(169, 30);
            this.txtYinLi.TabIndex = 1;
            this.txtYinLi.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtYinLi.WaterText = "";
            // 
            // textHeJi
            // 
            this.textHeJi.Enabled = false;
            this.textHeJi.Location = new System.Drawing.Point(466, 84);
            this.textHeJi.Name = "textHeJi";
            this.textHeJi.Size = new System.Drawing.Size(169, 30);
            this.textHeJi.TabIndex = 1;
            this.textHeJi.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textHeJi.WaterText = "";
            // 
            // textChongZhi
            // 
            this.textChongZhi.Enabled = false;
            this.textChongZhi.Location = new System.Drawing.Point(140, 87);
            this.textChongZhi.Name = "textChongZhi";
            this.textChongZhi.Size = new System.Drawing.Size(169, 30);
            this.textChongZhi.TabIndex = 1;
            this.textChongZhi.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textChongZhi.WaterText = "";
            // 
            // textFangJian
            // 
            this.textFangJian.Enabled = false;
            this.textFangJian.Location = new System.Drawing.Point(140, 31);
            this.textFangJian.Name = "textFangJian";
            this.textFangJian.Size = new System.Drawing.Size(169, 30);
            this.textFangJian.TabIndex = 1;
            this.textFangJian.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textFangJian.WaterText = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(1006, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "达成率:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(982, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "单日目标:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(669, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "营收目标:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(666, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "合计盈利:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(347, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "合计营收:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(347, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "商品营收:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(25, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "充值营收:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "房间营收:";
            // 
            // StatisticalChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1326, 684);
            this.Controls.Add(this.skinGroupBox2);
            this.Controls.Add(this.skinGroupBox3);
            this.Controls.Add(this.skinGroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatisticalChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "统 计 信 息";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.skinGroupBox1.ResumeLayout(false);
            this.skinGroupBox2.ResumeLayout(false);
            this.skinGroupBox2.PerformLayout();
            this.skinGroupBox3.ResumeLayout(false);
            this.skinGroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox2;
        private CCWin.SkinControl.SkinRadioButton rbRi;
        private CCWin.SkinControl.SkinRadioButton rbNian;
        private CCWin.SkinControl.SkinRadioButton rbYue;
        private CCWin.SkinControl.SkinWaterTextBox textNian;
        private CCWin.SkinControl.SkinComboBox cbYue;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CCWin.SkinControl.SkinWaterTextBox textShangPing;
        private CCWin.SkinControl.SkinWaterTextBox textHeJi;
        private CCWin.SkinControl.SkinWaterTextBox textChongZhi;
        private CCWin.SkinControl.SkinWaterTextBox textFangJian;
        private System.Windows.Forms.Label label4;
        private CCWin.SkinControl.SkinWaterTextBox textMuBiao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private CCWin.SkinControl.SkinProgressBar pbDaChengLv;
        private CCWin.SkinControl.SkinWaterTextBox textRiMuBiao;
        private System.Windows.Forms.Label label7;
        private CCWin.SkinControl.SkinWaterTextBox txtYinLi;
        private System.Windows.Forms.Label label8;

    }
}