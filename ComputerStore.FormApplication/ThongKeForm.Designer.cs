namespace ComputerStore.FormApplication
{
    partial class ThongKeForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.thangTab = new System.Windows.Forms.TabPage();
            this.lblSoluotmuahang = new System.Windows.Forms.Label();
            this.lblDoanhthubanhang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxNam = new System.Windows.Forms.ComboBox();
            this.cbxThang = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblSoluotmuahang2 = new System.Windows.Forms.Label();
            this.lblDoanhthubanhang2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.thangTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.thangTab);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-4, -3);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(615, 377);
            this.tabControl1.TabIndex = 0;
            // 
            // thangTab
            // 
            this.thangTab.Controls.Add(this.lblSoluotmuahang);
            this.thangTab.Controls.Add(this.lblDoanhthubanhang);
            this.thangTab.Controls.Add(this.label1);
            this.thangTab.Controls.Add(this.cbxNam);
            this.thangTab.Controls.Add(this.cbxThang);
            this.thangTab.Location = new System.Drawing.Point(4, 29);
            this.thangTab.Name = "thangTab";
            this.thangTab.Padding = new System.Windows.Forms.Padding(3);
            this.thangTab.Size = new System.Drawing.Size(607, 344);
            this.thangTab.TabIndex = 0;
            this.thangTab.Text = "Tháng";
            this.thangTab.UseVisualStyleBackColor = true;
            // 
            // lblSoluotmuahang
            // 
            this.lblSoluotmuahang.AutoSize = true;
            this.lblSoluotmuahang.Location = new System.Drawing.Point(12, 89);
            this.lblSoluotmuahang.Name = "lblSoluotmuahang";
            this.lblSoluotmuahang.Size = new System.Drawing.Size(130, 20);
            this.lblSoluotmuahang.TabIndex = 2;
            this.lblSoluotmuahang.Text = "Số lượt mua hàng:";
            // 
            // lblDoanhthubanhang
            // 
            this.lblDoanhthubanhang.AutoSize = true;
            this.lblDoanhthubanhang.Location = new System.Drawing.Point(12, 54);
            this.lblDoanhthubanhang.Name = "lblDoanhthubanhang";
            this.lblDoanhthubanhang.Size = new System.Drawing.Size(147, 20);
            this.lblDoanhthubanhang.TabIndex = 2;
            this.lblDoanhthubanhang.Text = "Doanh thu bán hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tháng";
            // 
            // cbxNam
            // 
            this.cbxNam.FormattingEnabled = true;
            this.cbxNam.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020"});
            this.cbxNam.Location = new System.Drawing.Point(128, 6);
            this.cbxNam.Name = "cbxNam";
            this.cbxNam.Size = new System.Drawing.Size(78, 28);
            this.cbxNam.TabIndex = 0;
            // 
            // cbxThang
            // 
            this.cbxThang.FormattingEnabled = true;
            this.cbxThang.Items.AddRange(new object[] {
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
            this.cbxThang.Location = new System.Drawing.Point(62, 6);
            this.cbxThang.Name = "cbxThang";
            this.cbxThang.Size = new System.Drawing.Size(60, 28);
            this.cbxThang.TabIndex = 0;
            this.cbxThang.SelectedIndexChanged += new System.EventHandler(this.cbxThang_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Controls.Add(this.lblSoluotmuahang2);
            this.tabPage2.Controls.Add(this.lblDoanhthubanhang2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(607, 344);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Năm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX2.IsMarginVisible = false;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.IsMarginVisible = false;
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY2.IsMarginVisible = false;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 100F;
            chartArea1.Position.Width = 100F;
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(3, 57);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.chart1.Size = new System.Drawing.Size(604, 25);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // lblSoluotmuahang2
            // 
            this.lblSoluotmuahang2.AutoSize = true;
            this.lblSoluotmuahang2.Location = new System.Drawing.Point(12, 102);
            this.lblSoluotmuahang2.Name = "lblSoluotmuahang2";
            this.lblSoluotmuahang2.Size = new System.Drawing.Size(130, 20);
            this.lblSoluotmuahang2.TabIndex = 4;
            this.lblSoluotmuahang2.Text = "Số lượt mua hàng:";
            // 
            // lblDoanhthubanhang2
            // 
            this.lblDoanhthubanhang2.AutoSize = true;
            this.lblDoanhthubanhang2.Location = new System.Drawing.Point(6, 34);
            this.lblDoanhthubanhang2.Name = "lblDoanhthubanhang2";
            this.lblDoanhthubanhang2.Size = new System.Drawing.Size(147, 20);
            this.lblDoanhthubanhang2.TabIndex = 3;
            this.lblDoanhthubanhang2.Text = "Doanh thu bán hàng:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020"});
            this.comboBox1.Location = new System.Drawing.Point(6, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(78, 28);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ThongKeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 368);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ThongKeForm";
            this.Text = "ThongKeForm";
            this.Load += new System.EventHandler(this.ThongKeForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.thangTab.ResumeLayout(false);
            this.thangTab.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage thangTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblSoluotmuahang;
        private System.Windows.Forms.Label lblDoanhthubanhang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxNam;
        private System.Windows.Forms.ComboBox cbxThang;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblSoluotmuahang2;
        private System.Windows.Forms.Label lblDoanhthubanhang2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}