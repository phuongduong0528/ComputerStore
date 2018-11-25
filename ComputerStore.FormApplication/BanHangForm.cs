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
    public partial class BanHangForm : Form
    {
        LoaiHangController loaiHangController;
        MatHangController matHangController;
        SellingController sellingController;
        string userId;
        string mathangid;
        long tongThanhToan;
        List<MatHangDuocBanDto> listTempMHDB;
        List<MatHangDto> tempMatHang;
        List<MatHangDto> mathangDisplay;
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
            listTempMHDB = new List<MatHangDuocBanDto>();
            mathangDisplay = new List<MatHangDto>();
            tongThanhToan = 0;
        }

        private void grpbChonhang_Enter(object sender, EventArgs e)
        {
            lstboxMatHang.Visible = false;
        }

        private async void txtbxTenHang_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lstboxMatHang.Visible = true;
                 tempMatHang = await matHangController.GetMatHangFilter(
                        txtbxTenHang.Text.ToLower(),
                        cbxLoaiHang.SelectedItem.ToString(), 
                        cbxHsx.SelectedItem.ToString());
                lstboxMatHang.DataSource = tempMatHang.Select(spp => spp.TenMatHang).Take(10).ToList();
                lstboxMatHang.SelectedIndex = 0;
            }
            catch(Exception ex)
            {

            }
        }

        private void BanHangForm_Click(object sender, EventArgs e)
        {
            lstboxMatHang.Visible = false;
        }

        private void lstboxMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                MatHangDuocBanDto tempMHDB;
                int sl = int.Parse(txtbxSoluong.Text);
                int km = int.Parse(txtbxKhuyenMai.Text);
                int skip = 0;
                tempMHDB = new MatHangDuocBanDto();
                List<SanPhamDto> sp = await matHangController.GetSanPhamByMatHang(mathangid, 1);

                skip = mathangDisplay.Count(mhd => mhd.MaMH.Equals(mathangid));
                if(sp.Count < (skip + sl))
                {
                    MessageBox.Show($"Số lượng hàng không đủ\nHiện có: {sp.Count - skip}", "",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    return;
                }

                for(int i = 0; i < sl; i++)
                {
                    sp = sp.Skip(skip).ToList();
                    tempMHDB.ID = "";
                    tempMHDB.MaSP = sp[i].MaSP;
                    tempMHDB.KhuyenMai = km;
                    listTempMHDB.Add(tempMHDB);
                    var z = await matHangController.GetMatHang(mathangid);
                    z.GiaNiemYet = z.GiaNiemYet - ((z.GiaNiemYet / 100) * km);
                    mathangDisplay.Add(z);
                }
                dgvMhdb.DataSource = null;
                dgvMhdb.DataSource = mathangDisplay;
                dgvMhdb.Columns[0].Visible = false;
                dgvMhdb.Columns[5].Visible = false;
            }
            catch(Exception ex)
            {

            }
        }

        private void lstboxMatHang_Click(object sender, EventArgs e)
        {

            txtbxTenHang.Text = lstboxMatHang.SelectedItem.ToString();
            mathangid = tempMatHang.FirstOrDefault(mh => mh.TenMatHang.Equals(lstboxMatHang.SelectedItem.ToString())).MaMH;
            lstboxMatHang.Visible = false;
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dgvMhdb.CurrentCell.RowIndex;
                string ten = dgvMhdb.Rows[row].Cells[4].Value.ToString();
                int index = 0;
                for (int i = listTempMHDB.Count - 1; i >= 0; i--)
                {
                    var b = await matHangController.GetSanPham(listTempMHDB[i].MaSP);
                    if(b.TenMH.Equals(ten))
                    {
                        index = i;
                        break;
                    }
                }
                listTempMHDB.RemoveAt(index);
                mathangDisplay.Remove(mathangDisplay.Where(mh=>mh.TenMatHang.Equals(ten)).FirstOrDefault());
                dgvMhdb.DataSource = null;
                dgvMhdb.DataSource = mathangDisplay;
                dgvMhdb.Columns[0].Visible = false;
                dgvMhdb.Columns[5].Visible = false;
            }
            catch(Exception ex)
            {

            }
        }

        private async void buttonToHd_Click(object sender, EventArgs e)
        {
            dgvHoadon.DataSource = mathangDisplay;
            dgvHoadon.Columns[5].Visible = false;
            NhanVienController nvc = new NhanVienController(Ultilities.ip, Ultilities.port);
            NhanVienDto nvTemp = await nvc.GetNhanVien(userId);
            lblNV.Text = $"Nhân viên: {nvTemp.TenNV}";
            lblNgay.Text = $"Ngày lập: {DateTime.Now.ToString("dd/MM/yyyy")}";
            long tongTien = 0;
            foreach(var a in mathangDisplay)
            {
                tongTien += a.GiaNiemYet;
            }
            lblTong.Text = $"Tổng:  {tongTien.ToString("N0")} VND";
        }

        private async void btnBanHang_Click(object sender, EventArgs e)
        {
            try
            {
                string khachHangId;
                if (checkBox1.CheckState == CheckState.Checked)
                {
                    khachHangId = "0000000000";
                }
                else
                {
                    khachHangId = txtbxMKH.Text.Trim();
                }
                bool result = await sellingController.BanHangAsync(listTempMHDB, userId, khachHangId);
                if (result)
                {
                    MessageBox.Show("Giao dịch thành công", "",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Giao dịch thất bại", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
