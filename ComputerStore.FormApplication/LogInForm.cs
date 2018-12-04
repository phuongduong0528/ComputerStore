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
    public partial class LogInForm : Form
    {
        private NhanVienController nhanVienController;
        private MainForm mainForm;

        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            Ultilities.ip = txtbxIp.Text;
            Ultilities.port = Convert.ToInt32(txtbxPort.Text);
            nhanVienController = new NhanVienController(Ultilities.ip, Ultilities.port);
        }

        private void btnChangeConn_Click(object sender, EventArgs e)
        {
            Ultilities.ip = txtbxIp.Text;
            try
            {
                Ultilities.port = Convert.ToInt32(txtbxPort.Text);
                nhanVienController = new NhanVienController(Ultilities.ip, Ultilities.port);
            }
            catch(FormatException ex)
            {

            }
        }

        private async void btnTestConn_Click(object sender, EventArgs e)
        {
            string ip = txtbxIp.Text;
            int port = 0;
            try
            {
                port = Convert.ToInt32(txtbxPort.Text);
            }
            catch (FormatException ex)
            {

            }
            NhanVienController a = new NhanVienController(ip, port);
            try
            {
                lblStatus.Text = $"Connecting to {ip}:{port}";
                lblStatus.Visible = true;
                var x = await a.GetNhanVien("0000000001"); //FOR TESTING ONLY
                if (x != null)
                    MessageBox.Show("Test success!", "Test connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Test failed!", "Test connection", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                lblStatus.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Visible = false;
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Authenticating";
            lblStatus.Visible = true;
            int respond = await 
                nhanVienController.Authenticate(txtbxId.Text,Ultilities.ToHashString(txtbxPass.Text));
            if(respond == 1)
            {
                Ultilities.idUser = txtbxId.Text;
                mainForm = new MainForm(txtbxId.Text);
                mainForm.FormClosed += new FormClosedEventHandler(mainform_Closed);
                mainForm.Show();
                lblStatus.Visible = false;
                this.Visible = false;
            }
            else
            {
                if (respond == 0)
                    MessageBox.Show("Sai ten dang nhap hoac mat khau", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Tai khoan bi khoa", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void mainform_Closed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
