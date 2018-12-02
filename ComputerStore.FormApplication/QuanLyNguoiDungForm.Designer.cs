namespace ComputerStore.FormApplication
{
    partial class QuanLyNguoiDungForm
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
            this.dgvNguoidung = new System.Windows.Forms.DataGridView();
            this.txtbxTen = new System.Windows.Forms.TextBox();
            this.txtbxNs = new System.Windows.Forms.TextBox();
            this.txtbxDiachi = new System.Windows.Forms.TextBox();
            this.txtbxEmail = new System.Windows.Forms.TextBox();
            this.txtbxSDT = new System.Windows.Forms.TextBox();
            this.txtbxMk = new System.Windows.Forms.TextBox();
            this.cbxQuyen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnKhoa = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoidung)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNguoidung
            // 
            this.dgvNguoidung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNguoidung.BackgroundColor = System.Drawing.Color.White;
            this.dgvNguoidung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguoidung.Location = new System.Drawing.Point(12, 158);
            this.dgvNguoidung.Name = "dgvNguoidung";
            this.dgvNguoidung.Size = new System.Drawing.Size(658, 309);
            this.dgvNguoidung.TabIndex = 0;
            this.dgvNguoidung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNguoidung_CellContentClick);
            // 
            // txtbxTen
            // 
            this.txtbxTen.Location = new System.Drawing.Point(87, 10);
            this.txtbxTen.Name = "txtbxTen";
            this.txtbxTen.Size = new System.Drawing.Size(179, 27);
            this.txtbxTen.TabIndex = 1;
            // 
            // txtbxNs
            // 
            this.txtbxNs.Location = new System.Drawing.Point(87, 43);
            this.txtbxNs.Name = "txtbxNs";
            this.txtbxNs.Size = new System.Drawing.Size(179, 27);
            this.txtbxNs.TabIndex = 1;
            // 
            // txtbxDiachi
            // 
            this.txtbxDiachi.Location = new System.Drawing.Point(87, 76);
            this.txtbxDiachi.Name = "txtbxDiachi";
            this.txtbxDiachi.Size = new System.Drawing.Size(179, 27);
            this.txtbxDiachi.TabIndex = 1;
            // 
            // txtbxEmail
            // 
            this.txtbxEmail.Location = new System.Drawing.Point(391, 10);
            this.txtbxEmail.Name = "txtbxEmail";
            this.txtbxEmail.Size = new System.Drawing.Size(179, 27);
            this.txtbxEmail.TabIndex = 1;
            // 
            // txtbxSDT
            // 
            this.txtbxSDT.Location = new System.Drawing.Point(391, 43);
            this.txtbxSDT.Name = "txtbxSDT";
            this.txtbxSDT.Size = new System.Drawing.Size(179, 27);
            this.txtbxSDT.TabIndex = 1;
            // 
            // txtbxMk
            // 
            this.txtbxMk.Location = new System.Drawing.Point(391, 76);
            this.txtbxMk.Name = "txtbxMk";
            this.txtbxMk.Size = new System.Drawing.Size(179, 27);
            this.txtbxMk.TabIndex = 1;
            // 
            // cbxQuyen
            // 
            this.cbxQuyen.FormattingEnabled = true;
            this.cbxQuyen.Location = new System.Drawing.Point(574, 76);
            this.cbxQuyen.Name = "cbxQuyen";
            this.cbxQuyen.Size = new System.Drawing.Size(90, 28);
            this.cbxQuyen.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên NV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "SĐT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mật khẩu";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(147, 109);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(116, 42);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(269, 110);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(116, 42);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa đổi";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnKhoa
            // 
            this.btnKhoa.Location = new System.Drawing.Point(391, 110);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.Size = new System.Drawing.Size(116, 42);
            this.btnKhoa.TabIndex = 4;
            this.btnKhoa.Text = "Khóa TK";
            this.btnKhoa.UseVisualStyleBackColor = true;
            this.btnKhoa.Click += new System.EventHandler(this.btnKhoa_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(572, 110);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(118, 24);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Sửa mật khẩu";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // QuanLyNguoiDungForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 479);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnKhoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxQuyen);
            this.Controls.Add(this.txtbxMk);
            this.Controls.Add(this.txtbxSDT);
            this.Controls.Add(this.txtbxEmail);
            this.Controls.Add(this.txtbxDiachi);
            this.Controls.Add(this.txtbxNs);
            this.Controls.Add(this.txtbxTen);
            this.Controls.Add(this.dgvNguoidung);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "QuanLyNguoiDungForm";
            this.Text = "Quản lý người dùng";
            this.Load += new System.EventHandler(this.QuanLyNguoiDungForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoidung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNguoidung;
        private System.Windows.Forms.TextBox txtbxTen;
        private System.Windows.Forms.TextBox txtbxNs;
        private System.Windows.Forms.TextBox txtbxDiachi;
        private System.Windows.Forms.TextBox txtbxEmail;
        private System.Windows.Forms.TextBox txtbxSDT;
        private System.Windows.Forms.TextBox txtbxMk;
        private System.Windows.Forms.ComboBox cbxQuyen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnKhoa;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}