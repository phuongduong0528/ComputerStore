using ComputerStore.FormApplication.Controller;
using OfficeOpenXml;
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
        private SellingController sellingController;
        private string maHd;

        public XemHoaDonForm()
        {
            InitializeComponent();
            sellingController = new SellingController(Ultilities.ip, Ultilities.port);
            this.maHd = "";
        }

        public XemHoaDonForm(string mahd)
        {
            InitializeComponent();
            sellingController = new SellingController(Ultilities.ip, Ultilities.port);
            this.maHd = mahd;
            LoadHoaDon(mahd);
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
            catch (Exception)
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
            catch (Exception)
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
            catch (Exception)
            {
            }
        }

        private async void dgvHoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = dgvHoadon.CurrentCell.RowIndex;
                string mahd = dgvHoadon.Rows[row].Cells[0].Value.ToString();
                await LoadHoaDon(mahd);
            }
            catch (Exception)
            {

            }
        }

        private async Task LoadHoaDon(string mahd)
        {
            Services.Dto.HoaDonDto a = await sellingController.GetHoaDon(mahd);
            List<Services.Dto.MatHangDuocBanDto> matHangDuocBan = await sellingController.GetMatHangDuocBan(mahd);
            lblMahoadon.Text = $"Mã hóa đơn: {a.MaHD}";
            lblNhanvien.Text = $"Nhân viên: {a.TenNV}";
            lblKhachhang.Text = $"Khách hàng: {a.TenKH}";
            lblTong.Text = $"TỔNG: {a.ThanhTien.ToString("N0")} VND";
            lblNgaymua.Text = $"Ngày mua: {a.NgayLap}";
            dgvSanphamban.DataSource = matHangDuocBan;
            dgvSanphamban.Columns[5].Visible = false;
            dgvSanphamban.Columns[6].Visible = false;
            dgvSanphamban.Columns[7].Visible = false;
        }

        private async void btnExportExcel_Click(object sender, EventArgs e)
        {
            string mahd = "";
            if (this.maHd.Equals(""))
            {
                int row = dgvHoadon.CurrentCell.RowIndex;
                mahd = dgvHoadon.Rows[row].Cells[0].Value.ToString();
            }
            else
            {
                mahd = this.maHd;
            }

            Services.Dto.HoaDonDto a = await sellingController.GetHoaDon(mahd);
            List<Services.Dto.MatHangDuocBanDto> b = await sellingController.GetMatHangDuocBan(mahd);

            ExcelPackage package = new ExcelPackage();
            ExcelWorksheet ws = package.Workbook.Worksheets.Add("hd");

            ws.Column(1).Width = 18.0;
            ws.Column(2).Width = 24.0;
            ws.Column(3).Width = 11.7;
            ws.Column(4).Width = 5.0;
            ws.Column(5).Width = 15.0;

            ws.Cells["A1"].Value = "Mã hóa đơn";
            ws.Cells["B1"].Value = a.MaHD;

            ws.Cells["B3"].Value = "HÓA ĐƠN MUA HÀNG";
            ws.Cells["B3:D3"].Merge = true;
            ws.Cells["B3:D3"].Style.Font.Bold = true;
            ws.Cells["B3:D3"].Style.Font.Size = 14.0f;
            ws.Cells["B3:D3"].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

            ws.Cells["A5"].Value = "Mã SP";
            ws.Cells["B5"].Value = "Tên SP";
            ws.Cells["C5"].Value = "Serial";
            ws.Cells["D5"].Value = "KM";
            ws.Cells["E5"].Value = "Giá";
            ws.Cells["A5:E5"].Style.Font.Bold = true;

            for (int i = 0; i < dgvSanphamban.ColumnCount - 3; i++)
            {
                for (int j = 0; j < dgvSanphamban.RowCount; j++)
                {
                    ws.Cells[j + 6, i + 1].Value =
                        dgvSanphamban.Rows[j].Cells[i].Value.ToString();
                }
            }

            ws.Cells[dgvSanphamban.RowCount + 8, 1].Value = "Tên khách hàng";
            ws.Cells[dgvSanphamban.RowCount + 8, 2].Value = a.TenKH;
            ws.Cells[dgvSanphamban.RowCount + 8, 2].Style.Font.Bold = true;

            ws.Cells[dgvSanphamban.RowCount + 8, 4].Value = "Tổng";
            ws.Cells[dgvSanphamban.RowCount + 8, 5].Value = $"{a.ThanhTien.ToString("N0")} VND";
            ws.Cells[dgvSanphamban.RowCount + 8, 5].Style.Font.Bold = true;

            ws.Cells[dgvSanphamban.RowCount + 9, 1].Value = a.NgayLap;
            ws.Cells[dgvSanphamban.RowCount + 10, 1, dgvSanphamban.RowCount + 10, 2].Merge = true;

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            package.SaveAs(new System.IO.FileInfo(path + $"\\HoaDon{DateTime.Now.ToString("yyyyMMddHHmmss")}{mahd}.xlsx"));
        }
    }
}
