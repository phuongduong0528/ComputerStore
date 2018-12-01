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
using System.Windows.Forms.DataVisualization.Charting;

namespace ComputerStore.FormApplication
{
    public partial class ThongKeForm : Form
    {
        SellingController sellingController = new SellingController(Ultilities.ip, Ultilities.port);
        public ThongKeForm()
        {
            InitializeComponent();
        }

        private void ThongKeForm_Load(object sender, EventArgs e)
        {
            cbxThang.SelectedIndex = DateTime.Now.Month - 2;
            cbxNam.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
        }
        
        private async void cbxThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int month = Convert.ToInt32(cbxThang.SelectedItem.ToString());
                List<Services.Dto.HoaDonDto> a = await sellingController.GetAllHoaDon();
                List<Services.Dto.HoaDonDto> b = a.Where(hd => DateTime.ParseExact(hd.NgayLap, @"dd/MM/yyyy HH\:mm\:ss", CultureInfo.InvariantCulture).Month == month).ToList();
                lblDoanhthubanhang.Text = $"Doanh thu bán hàng: {b.Sum(hd => hd.ThanhTien).ToString("N0")}";
                lblSoluotmuahang.Text = $"Số lượt mua hàng: {b.Count()}";
            }
            catch (Exception ex)
            {

            }
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Series series;
            double total = 0;
            double percent_total = 0;
            double percent_item = 0;
            chart1.Series.Clear();


            int year = Convert.ToInt32(comboBox1.SelectedItem.ToString());
            List<Services.Dto.HoaDonDto> a = await sellingController.GetAllHoaDon();
            List<Services.Dto.HoaDonDto> b = a.Where(hd => DateTime.ParseExact(hd.NgayLap, @"dd/MM/yyyy HH\:mm\:ss", CultureInfo.InvariantCulture).Year == year).ToList();
            total = b.Sum(hd => hd.ThanhTien);
            for(int i = 0; i < 12; i++)
            {
                b = a.Where(hd => DateTime.ParseExact(hd.NgayLap, @"dd/MM/yyyy HH\:mm\:ss", CultureInfo.InvariantCulture).Month == (i + 1)).ToList();
                if (i == 11)
                {
                    percent_item = 100 - percent_total;
                }
                else
                {
                    percent_item = (b.Sum(hd => hd.ThanhTien) / total) * 100;
                }
                percent_total += percent_item;
                series = chart1.Series.Add($"Thang {i + 1}");
                series.ChartType = SeriesChartType.StackedBar100;
                series.Points.Add(new DataPoint()
                {
                    YValues = new[] { percent_item },
                    ToolTip = $"Tháng {i+1} - {b.Sum(hd=>hd.ThanhTien).ToString("N0")} VND - {percent_item:F1}%"
                });
            }

            lblDoanhthubanhang2.Text = b.Sum(hd => hd.ThanhTien).ToString("N0") + " VND";
            lblSoluotmuahang2.Text = b.Count().ToString();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
