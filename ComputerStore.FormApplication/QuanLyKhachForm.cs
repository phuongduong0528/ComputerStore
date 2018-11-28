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
    public partial class QuanLyKhachForm : Form
    {
        KhachHangController khachHangController;
        SellingController sellingController;

        public QuanLyKhachForm()
        {
            InitializeComponent();
        }

        private async void QuanLyKhachForm_Load(object sender, EventArgs e)
        {
            khachHangController = new KhachHangController(Ultilities.ip, Ultilities.port);
            await RefreshTableKH();
            sellingController = new SellingController(Ultilities.ip, Ultilities.port);
        }

        private async Task RefreshTableKH()
        {
            List<Services.Dto.KhachHangDto> listKh = await khachHangController.GetAllKhachHang();
            dgvKhach.DataSource = listKh;
        }

        private async void dgvKhach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = dgvKhach.CurrentCell.RowIndex;
                txtbxTen.Text = dgvKhach.Rows[row].Cells[1].Value.ToString();
                txtbxNS.Text = dgvKhach.Rows[row].Cells[2].Value.ToString();
                txtbxDiachi.Text = dgvKhach.Rows[row].Cells[3].Value.ToString();
                txtbxEmail.Text = dgvKhach.Rows[row].Cells[4].Value.ToString();
                txtbxDT.Text = dgvKhach.Rows[row].Cells[5].Value.ToString();
                await RefreshDgvTThoadonKH();
            }
            catch (Exception ex)
            {

            }
        }

        private async Task RefreshDgvTThoadonKH()
        {
            int row = dgvKhach.CurrentCell.RowIndex;
            string makh = dgvKhach.Rows[row].Cells[0].Value.ToString();
            var hd = await sellingController.GetAllHoaDon();
            dgvTTkhach.DataSource = hd.Where(h => h.MaKH.Equals(makh)).ToList();
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            DateTime x;
            if (DateTime.TryParseExact(
                txtbxNS.Text,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out x))
            {
                KhachHangDto khdto = new KhachHangDto();
                khdto.TenKH = txtbxTen.Text;
                khdto.NgaySinh = txtbxNS.Text;
                khdto.DiaChi = txtbxDiachi.Text;
                khdto.Email = txtbxEmail.Text;
                khdto.Sdt = txtbxDT.Text;
                bool respond = await khachHangController.AddKhachHang(khdto);
                if (respond)
                {
                    MessageBox.Show("Đã thêm người dùng thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshTableKH();
                }
                else
                {
                    for(int i = 0; i<10; i++)
                    {
                        respond = await khachHangController.AddKhachHang(khdto);
                        if (respond)
                        {
                            MessageBox.Show("Đã thêm người dùng thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshTableKH();
                            return;
                        }
                    }
                    MessageBox.Show("Thêm người dùng thất bại", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Date format must be [dd/MM/yyyy]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnlLichsu_Click(object sender, EventArgs e)
        {
            await RefreshDgvTThoadonKH();
        }

        private void btnBaohanh_Click(object sender, EventArgs e)
        {

        }
    }
}
