using ComputerStore.FormApplication.Controller;
using ComputerStore.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerStore.FormApplication
{
    public partial class QuanLyHangForm : Form
    {
        List<MatHangDto> matHangDtos;
        List<SanPhamDto> sanPhamDtos;
        MatHangController matHangController;
        public QuanLyHangForm()
        {
            InitializeComponent();
        }

        private async void QuanLyHangForm_Load(object sender, EventArgs e)
        {
            matHangController = new MatHangController(Ultilities.ip, Ultilities.port);
            matHangDtos = await matHangController.GetAllMatHang();
            dgvMatHang.DataSource = matHangDtos;
            cbxHsx.Items.Add("All");
            LoaiHangController lhc = new LoaiHangController(Ultilities.ip, Ultilities.port);
            List<HangSanXuatDto> listHsx = await lhc.GetAllHangSanXuat();
            foreach(HangSanXuatDto hsx in listHsx)
            {
                cbxHsx.Items.Add(hsx.TenHSX);
            }
            cbxHsx.SelectedIndex = 0;
        }

        private async void RefreshData()
        {
            matHangController = new MatHangController(Ultilities.ip, Ultilities.port);
            matHangDtos = await matHangController.GetAllMatHang();
        }

        private async void RefreshDgvMatHang()
        {
            dgvMatHang.DataSource = matHangDtos;
        }

        private async void dgvMatHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                await RefreshDgvSanPham();
            }
            catch (Exception ex)
            {

            }
        }

        private async Task RefreshDgvSanPham()
        {
            dgvSanPham.DataSource = null;
            int row = dgvMatHang.CurrentCell.RowIndex;
            string item = dgvMatHang.Rows[row].Cells[0].Value.ToString();
            sanPhamDtos = await matHangController.GetSanPhamByMatHang(item, 0);
            dgvSanPham.DataSource = sanPhamDtos;
        }

        private void ctnThem_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                UpdateMatHangForm umhf = new UpdateMatHangForm();
                umhf.FormClosed += Umhf_FormClosed;
                umhf.ShowDialog();
            }
            else
            {
                int row = dgvSanPham.CurrentCell.RowIndex;
                string item = dgvSanPham.Rows[row].Cells[2].Value.ToString();
                UpdateSanPhamForm uspf = new UpdateSanPhamForm(null, item);
                uspf.FormClosed += Uspf_FormClosed;
                uspf.ShowDialog();
            }
        }

        private async void Uspf_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshData();
            RefreshDgvMatHang();
            await RefreshDgvSanPham();
        }

        private async void Umhf_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshData();
            RefreshDgvMatHang();
            await RefreshDgvSanPham();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                int row = dgvMatHang.CurrentCell.RowIndex;
                string item = dgvMatHang.Rows[row].Cells[0].Value.ToString();
                UpdateMatHangForm upf = new UpdateMatHangForm(item);
                upf.FormClosed += Umhf_FormClosed;
                upf.ShowDialog();
            }
            else
            {
                int row = dgvSanPham.CurrentCell.RowIndex;
                string item = dgvSanPham.Rows[row].Cells[0].Value.ToString();
                UpdateSanPhamForm uspf = new UpdateSanPhamForm(item, null);
                uspf.FormClosed += Uspf_FormClosed;
                uspf.ShowDialog();
            }
        }

        private async void cbxHsx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxHsx.SelectedIndex == 0)
            {
                RefreshData();
                RefreshDgvMatHang();
            }
            else
            {
                List<MatHangDto> z = await matHangController.GetAllMatHang();
                z = z.Where(mh => mh.HangSanXuat.Equals(cbxHsx.SelectedItem.ToString())).ToList();
                dgvMatHang.DataSource = z;
            }
        }
    }
}
