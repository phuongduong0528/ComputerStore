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
        }

        private async void RefreshData()
        {
            matHangController = new MatHangController(Ultilities.ip, Ultilities.port);
            matHangDtos = await matHangController.GetAllMatHang();
        }

        private async void RefreshTable()
        {
            dgvMatHang.DataSource = matHangDtos;
        }
    }
}
