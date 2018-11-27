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
    public partial class UpdateMatHangForm : Form
    {
        MatHangController matHangController;
        string idMatHang;
        public UpdateMatHangForm()
        {
            InitializeComponent();
            matHangController = new MatHangController(Ultilities.ip, Ultilities.port);
            idMatHang = "";
        }

        public UpdateMatHangForm(string idMatHang)
        {
            InitializeComponent();
            matHangController = new MatHangController(Ultilities.ip, Ultilities.port);
            this.idMatHang = idMatHang;
        }

        private async void UpdateMatHang_Load(object sender, EventArgs e)
        {
            label5.Visible = false;
            txtbxSoluong.Visible = false;
            LoaiHangController lhc = new LoaiHangController(Ultilities.ip, Ultilities.port);
            List<string> listLH = (await lhc.GetAllLoaiHang()).Select(lh => lh.TenLH).ToList();
            List<string> listHSX = (await lhc.GetAllHangSanXuat()).Select(hsx => hsx.TenHSX).ToList();
            List<string> listNPP = (await lhc.GetAllNhaPhanPhoi()).Select(npp => npp.TenNPP).ToList();
            cbxLoaihang.DataSource = listLH;
            cbxHsx.DataSource = listHSX;
            cbxNpp.DataSource = listNPP;

            if (idMatHang != "")
            {
                MatHangDto matHangDto = await matHangController.GetMatHang(idMatHang);
                txtbxTen.Text = matHangDto.TenMatHang;
                cbxLoaihang.SelectedItem = matHangDto.LoaiHang;
                cbxHsx.SelectedItem = matHangDto.HangSanXuat;
                cbxNpp.SelectedItem = matHangDto.NhaPhanPhoi;
                txtbxGia.Text = matHangDto.GiaNiemYet.ToString();
            }
        }

        private async void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (idMatHang != "")
                {
                    MatHangDto matHangDto = await matHangController.GetMatHang(idMatHang);
                    matHangDto.MaMH = idMatHang;
                    matHangDto.TenMatHang = txtbxTen.Text;
                    matHangDto.LoaiHang = cbxLoaihang.SelectedItem.ToString();
                    matHangDto.HangSanXuat = cbxHsx.SelectedItem.ToString();
                    matHangDto.NhaPhanPhoi = cbxNpp.SelectedItem.ToString();
                    matHangDto.SoLuong = Convert.ToInt32(txtbxSoluong.Text);
                    matHangDto.GiaNiemYet = Convert.ToInt64(txtbxGia.Text);
                    bool respond = await matHangController.EditMatHang(matHangDto);
                    if (respond)
                    {
                        MessageBox.Show("Đã sửa thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa sản phẩm thất bại", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MatHangDto matHangDto = new MatHangDto();
                    matHangDto.TenMatHang = txtbxTen.Text;
                    matHangDto.LoaiHang = cbxLoaihang.SelectedItem.ToString();
                    matHangDto.HangSanXuat = cbxHsx.SelectedItem.ToString();
                    matHangDto.NhaPhanPhoi = cbxNpp.SelectedItem.ToString();
                    matHangDto.SoLuong = Convert.ToInt32(txtbxSoluong.Text);
                    matHangDto.GiaNiemYet = Convert.ToInt64(txtbxGia.Text);
                    bool respond = await matHangController.AddMatHang(matHangDto);
                    if (respond)
                    {
                        MessageBox.Show("Đã thêm sản phẩm thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        for(int i = 0; i < 10; i++)
                        {
                            respond = await matHangController.AddMatHang(matHangDto);
                            if (respond)
                            {
                                MessageBox.Show("Đã thêm sản phẩm thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                        MessageBox.Show("Thêm sản phẩm thất bại", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
