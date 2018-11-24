﻿using System;
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
    }
}