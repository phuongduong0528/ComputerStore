﻿namespace ComputerStore.FormApplication
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.thangTab = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblSosanphamban = new System.Windows.Forms.Label();
            this.lblSoluotmuahang = new System.Windows.Forms.Label();
            this.lblDoanhthubanhang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxThang = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblSosanphamban2 = new System.Windows.Forms.Label();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblSoluotmuahang2 = new System.Windows.Forms.Label();
            this.lblDoanhthubanhang2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.thangTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.thangTab.Controls.Add(this.dataGridView1);
            this.thangTab.Controls.Add(this.chart2);
            this.thangTab.Controls.Add(this.lblSosanphamban);
            this.thangTab.Controls.Add(this.lblSoluotmuahang);
            this.thangTab.Controls.Add(this.lblDoanhthubanhang);
            this.thangTab.Controls.Add(this.label1);
            this.thangTab.Controls.Add(this.cbxThang);
            this.thangTab.Location = new System.Drawing.Point(4, 29);
            this.thangTab.Name = "thangTab";
            this.thangTab.Padding = new System.Windows.Forms.Padding(3);
            this.thangTab.Size = new System.Drawing.Size(607, 344);
            this.thangTab.TabIndex = 0;
            this.thangTab.Text = "Tháng";
            this.thangTab.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea6.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea6.AxisX.IsMarginVisible = false;
            chartArea6.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea6.AxisX2.IsMarginVisible = false;
            chartArea6.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea6.AxisY.IsMarginVisible = false;
            chartArea6.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea6.AxisY2.IsMarginVisible = false;
            chartArea6.Name = "ChartArea1";
            chartArea6.Position.Auto = false;
            chartArea6.Position.Height = 100F;
            chartArea6.Position.Width = 100F;
            this.chart2.ChartAreas.Add(chartArea6);
            this.chart2.Location = new System.Drawing.Point(0, 146);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.chart2.Size = new System.Drawing.Size(604, 25);
            this.chart2.TabIndex = 6;
            this.chart2.Text = "chart2";
            // 
            // lblSosanphamban
            // 
            this.lblSosanphamban.AutoSize = true;
            this.lblSosanphamban.Location = new System.Drawing.Point(12, 123);
            this.lblSosanphamban.Name = "lblSosanphamban";
            this.lblSosanphamban.Size = new System.Drawing.Size(126, 20);
            this.lblSosanphamban.TabIndex = 3;
            this.lblSosanphamban.Text = "Số sản phẩm bán:";
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
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.lblSosanphamban2);
            this.tabPage2.Controls.Add(this.chart3);
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
            // lblSosanphamban2
            // 
            this.lblSosanphamban2.AutoSize = true;
            this.lblSosanphamban2.Location = new System.Drawing.Point(12, 134);
            this.lblSosanphamban2.Name = "lblSosanphamban2";
            this.lblSosanphamban2.Size = new System.Drawing.Size(126, 20);
            this.lblSosanphamban2.TabIndex = 8;
            this.lblSosanphamban2.Text = "Số sản phẩm bán:";
            // 
            // chart3
            // 
            this.chart3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea4.AxisX.IsMarginVisible = false;
            chartArea4.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea4.AxisX2.IsMarginVisible = false;
            chartArea4.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea4.AxisY.IsMarginVisible = false;
            chartArea4.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea4.AxisY2.IsMarginVisible = false;
            chartArea4.Name = "ChartArea1";
            chartArea4.Position.Auto = false;
            chartArea4.Position.Height = 100F;
            chartArea4.Position.Width = 100F;
            this.chart3.ChartAreas.Add(chartArea4);
            this.chart3.Location = new System.Drawing.Point(0, 157);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.chart3.Size = new System.Drawing.Size(604, 25);
            this.chart3.TabIndex = 7;
            this.chart3.Text = "chart3";
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
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea5.AxisX.IsMarginVisible = false;
            chartArea5.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea5.AxisX2.IsMarginVisible = false;
            chartArea5.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea5.AxisY.IsMarginVisible = false;
            chartArea5.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea5.AxisY2.IsMarginVisible = false;
            chartArea5.Name = "ChartArea1";
            chartArea5.Position.Auto = false;
            chartArea5.Position.Height = 100F;
            chartArea5.Position.Width = 100F;
            this.chart1.ChartAreas.Add(chartArea5);
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
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(607, 167);
            this.dataGridView1.TabIndex = 7;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 183);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(607, 161);
            this.dataGridView2.TabIndex = 9;
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
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.ThongKeForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.thangTab.ResumeLayout(false);
            this.thangTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage thangTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblSoluotmuahang;
        private System.Windows.Forms.Label lblDoanhthubanhang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxThang;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblSoluotmuahang2;
        private System.Windows.Forms.Label lblDoanhthubanhang2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblSosanphamban;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label lblSosanphamban2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}