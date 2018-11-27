using ComputerStore.FormApplication.Controller;
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
    public partial class XemHoaDonForm : Form
    {
        SellingController sellingController;
        public XemHoaDonForm()
        {
            InitializeComponent();
            sellingController = new SellingController(Ultilities.ip, Ultilities.port);
        }

        private void XemHoaDonForm_Load(object sender, EventArgs e)
        {
        }

        private async void txtbxMahd_TextChanged(object sender, EventArgs e)
        {
            List<Services.Dto.HoaDonDto> listHoaDon;
            try
            {
                if (!checkBox1.Checked)
                {
                    listHoaDon = 
                        await sellingController.GetHoaDonFilter(txtbxMahd.Text, @"01/01/1900 00:00:00", @"31/12/2099 00:00:00");
                    dgvHoadon.DataSource = listHoaDon;
                }
                else
                {
                    string from = dtpFrom.Value.ToString(@"dd/MM/yyyy HH\:mm\:ss", CultureInfo.InvariantCulture);
                    string to = dtpTo.Value.ToString(@"dd/MM/yyyy HH\:mm\:ss", CultureInfo.InvariantCulture);
                    listHoaDon =
                        await sellingController.GetHoaDonFilter(txtbxMahd.Text, from, to);
                    dgvHoadon.DataSource = listHoaDon;
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dtpFrom.Enabled = true;
                dtpTo.Enabled = true;
            }
            else
            {
                dtpFrom.Enabled = false;
                dtpTo.Enabled = false;
            }
        }

        private async void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                string from = dtpFrom.Value.ToString(@"dd/MM/yyyy", CultureInfo.InvariantCulture);
                string to = dtpTo.Value.ToString(@"dd/MM/yyyy", CultureInfo.InvariantCulture);
                List<Services.Dto.HoaDonDto> listHoaDon =
                    await sellingController.GetHoaDonFilter(txtbxMahd.Text, from, to);
                dgvHoadon.DataSource = listHoaDon;
            }
            catch (Exception ex)
            {
            }
        }

        private async void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                string from = dtpFrom.Value.ToString(@"dd/MM/yyyy", CultureInfo.InvariantCulture);
                string to = dtpTo.Value.ToString(@"dd/MM/yyyy", CultureInfo.InvariantCulture);
                List<Services.Dto.HoaDonDto> listHoaDon =
                    await sellingController.GetHoaDonFilter(txtbxMahd.Text, from, to);
                dgvHoadon.DataSource = listHoaDon;
            }
            catch (Exception ex)
            {
            }
        }

        private async void dgvHoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = dgvHoadon.CurrentCell.RowIndex;
                string mahd = dgvHoadon.Rows[row].Cells[0].Value.ToString();
                Services.Dto.HoaDonDto a = await sellingController.GetHoaDon(mahd);
                List<Services.Dto.MatHangDuocBanDto> b = await sellingController.GetMatHangDuocBan(mahd);
                lblMahoadon.Text = $"Mã hóa đơn: {a.MaHD}";
                lblNhanvien.Text = $"Nhân viên: {a.TenNV}";
                lblKhachhang.Text = $"Khách hàng: {a.TenKH}";
                lblTong.Text = $"TỔNG: {a.ThanhTien.ToString("N0")} VND";
                lblNgaymua.Text = $"Ngày mua: {a.NgayLap}";
                dgvSanphamban.DataSource = b;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
