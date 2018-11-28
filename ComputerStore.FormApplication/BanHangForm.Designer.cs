namespace ComputerStore.FormApplication
{
    partial class BanHangForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpbChonhang = new System.Windows.Forms.GroupBox();
            this.lstboxMatHang = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxKhuyenMai = new System.Windows.Forms.TextBox();
            this.txtbxSoluong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.buttonToHd = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cbxHsx = new System.Windows.Forms.ComboBox();
            this.txtbxTenHang = new System.Windows.Forms.TextBox();
            this.cbxLoaiHang = new System.Windows.Forms.ComboBox();
            this.dgvMhdb = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTong = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblNV = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvHoadon = new System.Windows.Forms.DataGridView();
            this.txtbxMKH = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.txtbxTienkhachtra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTienkhachtra = new System.Windows.Forms.Label();
            this.txtbxTralaikhach = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpbChonhang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMhdb)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(1, 1);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpbChonhang);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 495);
            this.splitContainer1.SplitterDistance = 402;
            this.splitContainer1.TabIndex = 2;
            // 
            // grpbChonhang
            // 
            this.grpbChonhang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbChonhang.Controls.Add(this.label5);
            this.grpbChonhang.Controls.Add(this.txtbxTienkhachtra);
            this.grpbChonhang.Controls.Add(this.lstboxMatHang);
            this.grpbChonhang.Controls.Add(this.label3);
            this.grpbChonhang.Controls.Add(this.txtbxKhuyenMai);
            this.grpbChonhang.Controls.Add(this.txtbxSoluong);
            this.grpbChonhang.Controls.Add(this.label2);
            this.grpbChonhang.Controls.Add(this.label9);
            this.grpbChonhang.Controls.Add(this.label8);
            this.grpbChonhang.Controls.Add(this.label1);
            this.grpbChonhang.Controls.Add(this.btnAdd);
            this.grpbChonhang.Controls.Add(this.buttonToHd);
            this.grpbChonhang.Controls.Add(this.btnXoa);
            this.grpbChonhang.Controls.Add(this.cbxHsx);
            this.grpbChonhang.Controls.Add(this.txtbxTenHang);
            this.grpbChonhang.Controls.Add(this.cbxLoaiHang);
            this.grpbChonhang.Controls.Add(this.dgvMhdb);
            this.grpbChonhang.Location = new System.Drawing.Point(3, 3);
            this.grpbChonhang.Name = "grpbChonhang";
            this.grpbChonhang.Size = new System.Drawing.Size(396, 489);
            this.grpbChonhang.TabIndex = 1;
            this.grpbChonhang.TabStop = false;
            this.grpbChonhang.Text = "Chọn hàng";
            this.grpbChonhang.Enter += new System.EventHandler(this.grpbChonhang_Enter);
            // 
            // lstboxMatHang
            // 
            this.lstboxMatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lstboxMatHang.FormattingEnabled = true;
            this.lstboxMatHang.ItemHeight = 20;
            this.lstboxMatHang.Location = new System.Drawing.Point(110, 78);
            this.lstboxMatHang.Name = "lstboxMatHang";
            this.lstboxMatHang.Size = new System.Drawing.Size(280, 84);
            this.lstboxMatHang.TabIndex = 8;
            this.lstboxMatHang.Visible = false;
            this.lstboxMatHang.Click += new System.EventHandler(this.lstboxMatHang_Click);
            this.lstboxMatHang.SelectedIndexChanged += new System.EventHandler(this.lstboxMatHang_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Khuyến mại:";
            // 
            // txtbxKhuyenMai
            // 
            this.txtbxKhuyenMai.Location = new System.Drawing.Point(110, 142);
            this.txtbxKhuyenMai.Name = "txtbxKhuyenMai";
            this.txtbxKhuyenMai.Size = new System.Drawing.Size(100, 27);
            this.txtbxKhuyenMai.TabIndex = 6;
            // 
            // txtbxSoluong
            // 
            this.txtbxSoluong.Location = new System.Drawing.Point(110, 110);
            this.txtbxSoluong.Name = "txtbxSoluong";
            this.txtbxSoluong.Size = new System.Drawing.Size(100, 27);
            this.txtbxSoluong.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số lượng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Tên hàng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Loại hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên mặt hàng:";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Green;
            this.btnAdd.Location = new System.Drawing.Point(6, 174);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 27);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // buttonToHd
            // 
            this.buttonToHd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonToHd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonToHd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonToHd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToHd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToHd.ForeColor = System.Drawing.Color.Teal;
            this.buttonToHd.Location = new System.Drawing.Point(310, 174);
            this.buttonToHd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonToHd.Name = "buttonToHd";
            this.buttonToHd.Size = new System.Drawing.Size(80, 27);
            this.buttonToHd.TabIndex = 4;
            this.buttonToHd.Text = "OK ";
            this.buttonToHd.UseVisualStyleBackColor = true;
            this.buttonToHd.Click += new System.EventHandler(this.buttonToHd_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(86, 174);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 27);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cbxHsx
            // 
            this.cbxHsx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxHsx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxHsx.FormattingEnabled = true;
            this.cbxHsx.Location = new System.Drawing.Point(288, 51);
            this.cbxHsx.Margin = new System.Windows.Forms.Padding(0);
            this.cbxHsx.Name = "cbxHsx";
            this.cbxHsx.Size = new System.Drawing.Size(102, 28);
            this.cbxHsx.TabIndex = 3;
            // 
            // txtbxTenHang
            // 
            this.txtbxTenHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxTenHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxTenHang.Location = new System.Drawing.Point(110, 50);
            this.txtbxTenHang.Margin = new System.Windows.Forms.Padding(0);
            this.txtbxTenHang.Name = "txtbxTenHang";
            this.txtbxTenHang.Size = new System.Drawing.Size(179, 29);
            this.txtbxTenHang.TabIndex = 2;
            this.txtbxTenHang.TextChanged += new System.EventHandler(this.txtbxTenHang_TextChanged);
            // 
            // cbxLoaiHang
            // 
            this.cbxLoaiHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxLoaiHang.FormattingEnabled = true;
            this.cbxLoaiHang.Location = new System.Drawing.Point(110, 23);
            this.cbxLoaiHang.Margin = new System.Windows.Forms.Padding(0);
            this.cbxLoaiHang.Name = "cbxLoaiHang";
            this.cbxLoaiHang.Size = new System.Drawing.Size(280, 28);
            this.cbxLoaiHang.TabIndex = 1;
            // 
            // dgvMhdb
            // 
            this.dgvMhdb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMhdb.BackgroundColor = System.Drawing.Color.White;
            this.dgvMhdb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMhdb.Location = new System.Drawing.Point(6, 200);
            this.dgvMhdb.Name = "dgvMhdb";
            this.dgvMhdb.Size = new System.Drawing.Size(384, 253);
            this.dgvMhdb.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtbxTralaikhach);
            this.groupBox2.Controls.Add(this.lblTienkhachtra);
            this.groupBox2.Controls.Add(this.lblTong);
            this.groupBox2.Controls.Add(this.lblNgay);
            this.groupBox2.Controls.Add(this.lblNV);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dgvHoadon);
            this.groupBox2.Controls.Add(this.txtbxMKH);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btnBanHang);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 492);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóa đơn";
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTong.Location = new System.Drawing.Point(207, 126);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(45, 20);
            this.lblTong.TabIndex = 8;
            this.lblTong.Text = "Tổng";
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(6, 126);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(69, 20);
            this.lblNgay.TabIndex = 8;
            this.lblNgay.Text = "Ngày lập";
            // 
            // lblNV
            // 
            this.lblNV.AutoSize = true;
            this.lblNV.Location = new System.Drawing.Point(8, 93);
            this.lblNV.Name = "lblNV";
            this.lblNV.Size = new System.Drawing.Size(78, 20);
            this.lblNV.TabIndex = 8;
            this.lblNV.Text = "Nhân viên:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(228, 25);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 24);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Không có";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã khách hàng";
            // 
            // dgvHoadon
            // 
            this.dgvHoadon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHoadon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoadon.Location = new System.Drawing.Point(6, 200);
            this.dgvHoadon.Name = "dgvHoadon";
            this.dgvHoadon.Size = new System.Drawing.Size(376, 286);
            this.dgvHoadon.TabIndex = 0;
            // 
            // txtbxMKH
            // 
            this.txtbxMKH.Location = new System.Drawing.Point(122, 23);
            this.txtbxMKH.Name = "txtbxMKH";
            this.txtbxMKH.Size = new System.Drawing.Size(100, 27);
            this.txtbxMKH.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(122, 53);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "Tạo mới ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.BackColor = System.Drawing.Color.Teal;
            this.btnBanHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnBanHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanHang.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanHang.ForeColor = System.Drawing.Color.White;
            this.btnBanHang.Location = new System.Drawing.Point(6, 155);
            this.btnBanHang.Margin = new System.Windows.Forms.Padding(0);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(137, 42);
            this.btnBanHang.TabIndex = 4;
            this.btnBanHang.Text = "Bán hàng ";
            this.btnBanHang.UseVisualStyleBackColor = false;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // txtbxTienkhachtra
            // 
            this.txtbxTienkhachtra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxTienkhachtra.Location = new System.Drawing.Point(117, 457);
            this.txtbxTienkhachtra.Name = "txtbxTienkhachtra";
            this.txtbxTienkhachtra.Size = new System.Drawing.Size(273, 27);
            this.txtbxTienkhachtra.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tiền khách trả";
            // 
            // lblTienkhachtra
            // 
            this.lblTienkhachtra.AutoSize = true;
            this.lblTienkhachtra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienkhachtra.Location = new System.Drawing.Point(144, 149);
            this.lblTienkhachtra.Name = "lblTienkhachtra";
            this.lblTienkhachtra.Size = new System.Drawing.Size(108, 20);
            this.lblTienkhachtra.TabIndex = 8;
            this.lblTienkhachtra.Text = "Tiền khách trả";
            // 
            // txtbxTralaikhach
            // 
            this.txtbxTralaikhach.AutoSize = true;
            this.txtbxTralaikhach.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxTralaikhach.Location = new System.Drawing.Point(156, 174);
            this.txtbxTralaikhach.Name = "txtbxTralaikhach";
            this.txtbxTralaikhach.Size = new System.Drawing.Size(96, 20);
            this.txtbxTralaikhach.TabIndex = 8;
            this.txtbxTralaikhach.Text = "Trả lại khách";
            // 
            // BanHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(810, 505);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BanHangForm";
            this.Text = "BanHangForm";
            this.Load += new System.EventHandler(this.BanHangForm_Load);
            this.Click += new System.EventHandler(this.BanHangForm_Click);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpbChonhang.ResumeLayout(false);
            this.grpbChonhang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMhdb)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpbChonhang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxKhuyenMai;
        private System.Windows.Forms.TextBox txtbxSoluong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button buttonToHd;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cbxHsx;
        private System.Windows.Forms.TextBox txtbxTenHang;
        private System.Windows.Forms.ComboBox cbxLoaiHang;
        private System.Windows.Forms.DataGridView dgvMhdb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblNV;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvHoadon;
        private System.Windows.Forms.TextBox txtbxMKH;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstboxMatHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbxTienkhachtra;
        private System.Windows.Forms.Label lblTienkhachtra;
        private System.Windows.Forms.Label txtbxTralaikhach;
    }
}