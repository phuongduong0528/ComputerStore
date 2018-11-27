using ComputerStore.FormApplication.Controller;
using ComputerStore.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerStore.FormApplication
{
    public partial class UpdateSanPhamForm : Form
    {
        public string sanphamId;
        public string tenmathang;

        public UpdateSanPhamForm(string sanphamId, string tenmathang)
        {
            InitializeComponent();
            this.sanphamId = sanphamId;
            this.tenmathang = tenmathang;
        }

        private async void UpdateSanPhamForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("OK");
            comboBox1.Items.Add("Stop");
            comboBox1.SelectedIndex = 0;
            MatHangController matHangController = new MatHangController(Ultilities.ip, Ultilities.port);
            if (sanphamId != null)
            {
                Services.Dto.SanPhamDto x = await matHangController.GetSanPham(sanphamId);
                txtbxSerial.Text = x.Serial;
                txtbxDonViTinh.Text = x.DonViTinh;
                comboBox1.SelectedIndex = x.TinhTrang.Equals("OK") ? 0 : 1; 
            }
        }

        private async void btnOk_Click(object sender, EventArgs e)
        {
            if(sanphamId == null)
            {
                MatHangController matHangController = new MatHangController(Ultilities.ip, Ultilities.port);
                SanPhamDto x = new SanPhamDto();
                x.Serial = txtbxSerial.Text;
                x.TenMH = tenmathang;
                x.DonViTinh = txtbxDonViTinh.Text;
                x.NgayNhap = dtpNgaynhap.Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                x.NgayXuat = "01/01/1900";
                x.TinhTrang = comboBox1.SelectedItem.ToString();
                bool respond = await matHangController.AddSanPham(x);
                if (respond)
                {
                    MessageBox.Show("OK", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    for(int i = 0; i < 10; i++)
                    {
                        respond = await matHangController.AddSanPham(x);
                        if (respond)
                        {
                            MessageBox.Show("OK", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    MessageBox.Show("Failed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MatHangController matHangController = new MatHangController(Ultilities.ip, Ultilities.port);
                Services.Dto.SanPhamDto spDto = await matHangController.GetSanPham(sanphamId);
                spDto.Serial = txtbxSerial.Text;
                spDto.DonViTinh = txtbxDonViTinh.Text;
                spDto.TinhTrang = comboBox1.SelectedItem.ToString();
                if( await matHangController.EditSanPham(spDto))
                {
                    MessageBox.Show("OK", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
