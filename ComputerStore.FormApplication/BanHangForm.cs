using ComputerStore.FormApplication.Controller;
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
    public partial class BanHangForm : Form
    {
        LoaiHangController loaiHangController;
        MatHangController matHangController;
        SellingController sellingController;
        string userId;
        public BanHangForm()
        {
            InitializeComponent();
        }

        public BanHangForm(string userId)
        {
            InitializeComponent();
            loaiHangController = new LoaiHangController(Ultilities.ip, Ultilities.port);
            matHangController = new MatHangController(Ultilities.ip, Ultilities.port);
            sellingController = new SellingController(Ultilities.ip, Ultilities.port);
            this.userId = userId;
        }

        private async void BanHangForm_Load(object sender, EventArgs e)
        {
            List<Services.Dto.LoaiHangDto> listLoaiHang = await loaiHangController.GetAllLoaiHang();
            List<Services.Dto.HangSanXuatDto> listHSX = await loaiHangController.GetAllHangSanXuat();
            cbxLoaiHang.Items.Add("*");
            foreach(Services.Dto.LoaiHangDto lh in listLoaiHang)
            {
                cbxLoaiHang.Items.Add(lh.TenLH);
            }
            cbxHsx.DataSource = listHSX.Select(hsx => hsx.TenHSX).ToList();
            cbxLoaiHang.SelectedIndex = 0;
            cbxHsx.SelectedIndex = 0;
        }
    }
}
