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
    public partial class QuanLyNguoiDungForm : Form
    {
        NhanVienController nhanVienController;
        public QuanLyNguoiDungForm()
        {
            InitializeComponent();
        }

        private async void QuanLyNguoiDungForm_Load(object sender, EventArgs e)
        {
            cbxQuyen.Items.Add("Normal");
            cbxQuyen.Items.Add("Admin");
            cbxQuyen.SelectedIndex = 0;
            await RefreshDgv();
        }

        private async Task RefreshDgv()
        {
            nhanVienController = new NhanVienController(Ultilities.ip, Ultilities.port);
            List<Services.Dto.NhanVienDto> nv = await nhanVienController.GetAllNhanVien();
            dgvNguoidung.DataSource = nv;
            dgvNguoidung.Columns[6].Visible = false;
        }

        private void dgvNguoidung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = dgvNguoidung.CurrentCell.RowIndex;
                txtbxTen.Text = dgvNguoidung.Rows[row].Cells[1].Value.ToString();
                txtbxNs.Text = dgvNguoidung.Rows[row].Cells[2].Value.ToString();
                txtbxDiachi.Text = dgvNguoidung.Rows[row].Cells[3].Value.ToString();
                txtbxEmail.Text = dgvNguoidung.Rows[row].Cells[4].Value.ToString();
                txtbxSDT.Text = dgvNguoidung.Rows[row].Cells[5].Value.ToString();
                //txtbxMk.Text = dgvNguoidung.Rows[row].Cells[6].Value.ToString();
                cbxQuyen.SelectedItem = dgvNguoidung.Rows[row].Cells[7].Value.ToString();
            }
            catch(Exception ex)
            {

            }
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            DateTime test;
            if (!DateTime.TryParseExact(txtbxNs.Text,"dd/MM/yyyy",CultureInfo.InvariantCulture,DateTimeStyles.None, out test))
            {
                MessageBox.Show("DateTime format must be dd/MM/yyyy", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            NhanVienDto nvDto = new NhanVienDto();
            nvDto.TenNV = txtbxTen.Text;
            nvDto.NgaySinh = txtbxNs.Text;
            nvDto.DiaChi = txtbxDiachi.Text;
            nvDto.Email = txtbxEmail.Text;
            nvDto.SDT = txtbxSDT.Text;
            nvDto.MatKhau = Ultilities.ToHashString(txtbxMk.Text);
            nvDto.QuyenHan = cbxQuyen.SelectedItem.ToString();
            bool result = await nhanVienController.AddNhanVien(nvDto);
            if (result)
            {
                MessageBox.Show("Thêm người dùng thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await RefreshDgv();
            }
            else
            {
                for(int i = 0; i < 10; i++)
                {
                    result = await nhanVienController.AddNhanVien(nvDto);
                    if (result)
                    {
                        MessageBox.Show("Thêm người dùng thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await RefreshDgv();
                        return;
                    }
                }
                MessageBox.Show("Thêm người dùng thất bại", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime test;
                if (!DateTime.TryParseExact(txtbxNs.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out test))
                {
                    MessageBox.Show("DateTime format must be dd/MM/yyyy", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                int row = dgvNguoidung.CurrentCell.RowIndex;
                string id = dgvNguoidung.Rows[row].Cells[0].Value.ToString();
                NhanVienDto nvDto = await nhanVienController.GetNhanVien(id);
                nvDto.TenNV = txtbxTen.Text;
                nvDto.NgaySinh = txtbxNs.Text;
                nvDto.DiaChi = txtbxDiachi.Text;
                nvDto.Email = txtbxEmail.Text;
                nvDto.SDT = txtbxSDT.Text;
                if (checkBox1.Checked)
                {
                    nvDto.MatKhau = Ultilities.ToHashString(txtbxMk.Text);
                }
                nvDto.QuyenHan = cbxQuyen.SelectedItem.ToString();
                bool respond = await nhanVienController.EditNhanVien(nvDto);
                if (respond)
                {
                    MessageBox.Show("Sửa thông tin thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await RefreshDgv();
                }
                else
                {
                    MessageBox.Show("Sửa thông tin thất bại", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception)
            {

            }
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dgvNguoidung.CurrentCell.RowIndex;
                string id = dgvNguoidung.Rows[row].Cells[0].Value.ToString();
                if(id == Ultilities.idUser)
                {
                    MessageBox.Show("Không thể xóa tài khoản hiện tại", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                nhanVienController.LockAccount(id);
                RefreshDgv();
            }
            catch (Exception)
            {

            }
        }
    }
}
