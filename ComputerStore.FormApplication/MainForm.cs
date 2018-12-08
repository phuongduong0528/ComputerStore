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
    public partial class MainForm : Form
    {
        BanHangForm banHangForm;
        QuanLyHangForm quanLyHangForm;
        XemHoaDonForm xemHoaDonForm;
        QuanLyKhachForm quanLyKhachForm;
        QuanLyNguoiDungForm quanLyNguoiDungForm;
        ThongKeForm thongKeForm;
        string idUser;
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(string idUser)
        {
            InitializeComponent();
            this.idUser = idUser;
        }
        
        private async void MainForm_Load(object sender, EventArgs e)
        {
            NhanVienController nhanVienController = new NhanVienController(Ultilities.ip,Ultilities.port);
            Services.Dto.NhanVienDto nv = await nhanVienController.GetNhanVien(Ultilities.idUser);
            if (nv.QuyenHan.Equals("Normal"))
            {
                ngườiQuảnTrịToolStripMenuItem.Visible = false;
            }
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (banHangForm == null)
            {
                banHangForm = new BanHangForm(idUser);
                banHangForm.FormClosed += BanHangForm_FormClosed;
                banHangForm.MdiParent = this;
                banHangForm.Show();
            }
            else
                banHangForm.BringToFront();
        }

        private void BanHangForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            banHangForm = null;
        }

        private void qlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(quanLyHangForm == null)
            {
                quanLyHangForm = new QuanLyHangForm();
                quanLyHangForm.MdiParent = this;
                quanLyHangForm.FormClosed += QuanLyHangForm_FormClosed;
                quanLyHangForm.Show();
            }
            else
            {
                quanLyHangForm.BringToFront();
            }
        }

        private void QuanLyHangForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            quanLyHangForm = null;
        }

        private void qLHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(xemHoaDonForm == null)
            {
                xemHoaDonForm = new XemHoaDonForm();
                xemHoaDonForm.MdiParent = this;
                xemHoaDonForm.FormClosed += XemHoaDonForm_FormClosed;
                xemHoaDonForm.Show();
            }
            else
            {
                xemHoaDonForm.BringToFront();
            }
        }

        private void XemHoaDonForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            xemHoaDonForm = null;
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(quanLyKhachForm == null)
            {
                quanLyKhachForm = new QuanLyKhachForm();
                quanLyKhachForm.FormClosed += QuanLyKhachForm_FormClosed;
                quanLyKhachForm.MdiParent = this;
                quanLyKhachForm.Show();
            }
            else
            {
                quanLyKhachForm.BringToFront();
            }
        }

        private void QuanLyKhachForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            quanLyKhachForm = null;
        }

        private void ngườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (quanLyNguoiDungForm == null)
            {
                quanLyNguoiDungForm = new QuanLyNguoiDungForm();
                quanLyNguoiDungForm.MdiParent = this;
                quanLyNguoiDungForm.FormClosed += QuanLyNguoiDungForm_FormClosed;
                quanLyNguoiDungForm.Show();
            }
            else
            {
                quanLyNguoiDungForm.BringToFront();
            }
            
        }

        private void QuanLyNguoiDungForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            quanLyNguoiDungForm = null;
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(thongKeForm == null)
            {
                thongKeForm = new ThongKeForm();
                thongKeForm.MdiParent = this;
                thongKeForm.FormClosed += ThongKeForm_FormClosed;
                thongKeForm.Show();
            }
            else
            {
                thongKeForm.BringToFront();
            }
        }

        private void ThongKeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            thongKeForm = null;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
