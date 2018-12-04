using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerStoreServiceHost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Starting Services";

            ServiceHost khachHangService = new ServiceHost(typeof(ComputerStore.Services.KhachHangService));
            ServiceHost loaiHangService = new ServiceHost(typeof(ComputerStore.Services.LoaiHangService));
            ServiceHost matHangService = new ServiceHost(typeof(ComputerStore.Services.MatHangService));
            ServiceHost nhanVienService = new ServiceHost(typeof(ComputerStore.Services.NhanVienService));
            ServiceHost sellingService = new ServiceHost(typeof(ComputerStore.Services.SellingService));

            try
            {
                khachHangService.Open();
                loaiHangService.Open();
                matHangService.Open();
                nhanVienService.Open();
                sellingService.Open();

                richTextBox1.Text += "\n\nAll Services started";
            }
            catch (Exception ex)
            {
                richTextBox1.Text += "\n\n" + ex.Message;
            }

        }
    }
}
