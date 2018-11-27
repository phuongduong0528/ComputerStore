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
        
        private void MainForm_Load(object sender, EventArgs e)
        {

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
    }
}
