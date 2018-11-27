namespace ComputerStore.FormApplication
{
    partial class UpdateMatHangForm
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
            this.cbxLoaihang = new System.Windows.Forms.ComboBox();
            this.cbxHsx = new System.Windows.Forms.ComboBox();
            this.cbxNpp = new System.Windows.Forms.ComboBox();
            this.txtbxTen = new System.Windows.Forms.TextBox();
            this.txtbxSoluong = new System.Windows.Forms.TextBox();
            this.txtbxGia = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxLoaihang
            // 
            this.cbxLoaihang.FormattingEnabled = true;
            this.cbxLoaihang.Location = new System.Drawing.Point(128, 47);
            this.cbxLoaihang.Name = "cbxLoaihang";
            this.cbxLoaihang.Size = new System.Drawing.Size(210, 28);
            this.cbxLoaihang.TabIndex = 1;
            // 
            // cbxHsx
            // 
            this.cbxHsx.FormattingEnabled = true;
            this.cbxHsx.Location = new System.Drawing.Point(128, 81);
            this.cbxHsx.Name = "cbxHsx";
            this.cbxHsx.Size = new System.Drawing.Size(210, 28);
            this.cbxHsx.TabIndex = 1;
            // 
            // cbxNpp
            // 
            this.cbxNpp.FormattingEnabled = true;
            this.cbxNpp.Location = new System.Drawing.Point(128, 115);
            this.cbxNpp.Name = "cbxNpp";
            this.cbxNpp.Size = new System.Drawing.Size(210, 28);
            this.cbxNpp.TabIndex = 1;
            // 
            // txtbxTen
            // 
            this.txtbxTen.Location = new System.Drawing.Point(128, 13);
            this.txtbxTen.Name = "txtbxTen";
            this.txtbxTen.Size = new System.Drawing.Size(210, 27);
            this.txtbxTen.TabIndex = 0;
            // 
            // txtbxSoluong
            // 
            this.txtbxSoluong.Location = new System.Drawing.Point(439, 13);
            this.txtbxSoluong.Name = "txtbxSoluong";
            this.txtbxSoluong.Size = new System.Drawing.Size(195, 27);
            this.txtbxSoluong.TabIndex = 0;
            this.txtbxSoluong.Text = "0";
            // 
            // txtbxGia
            // 
            this.txtbxGia.Location = new System.Drawing.Point(439, 48);
            this.txtbxGia.Name = "txtbxGia";
            this.txtbxGia.Size = new System.Drawing.Size(195, 27);
            this.txtbxGia.TabIndex = 0;
            this.txtbxGia.Text = "0";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(437, 103);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(197, 40);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loại hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hãng SX:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhà phân phối:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Giá:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên mặt hàng:";
            // 
            // UpdateMatHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 162);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cbxNpp);
            this.Controls.Add(this.cbxHsx);
            this.Controls.Add(this.cbxLoaihang);
            this.Controls.Add(this.txtbxGia);
            this.Controls.Add(this.txtbxSoluong);
            this.Controls.Add(this.txtbxTen);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UpdateMatHangForm";
            this.Text = "UpdateMatHang";
            this.Load += new System.EventHandler(this.UpdateMatHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxLoaihang;
        private System.Windows.Forms.ComboBox cbxHsx;
        private System.Windows.Forms.ComboBox cbxNpp;
        private System.Windows.Forms.TextBox txtbxTen;
        private System.Windows.Forms.TextBox txtbxSoluong;
        private System.Windows.Forms.TextBox txtbxGia;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}