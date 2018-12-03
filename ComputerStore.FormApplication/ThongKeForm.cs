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
        MatHangController matHangController = new MatHangController(Ultilities.ip, Ultilities.port);
        public ThongKeForm()
        {
            InitializeComponent();
        }

        private void ThongKeForm_Load(object sender, EventArgs e)
        {
            cbxThang.SelectedIndex = DateTime.Now.Month - 2;
            comboBox1.SelectedIndex = 0;
            dataGridView1.Columns.Add("tenMh", "Tên MH");
            dataGridView1.Columns.Add("soluong", "Số lượng bán");
            dataGridView2.Columns.Add("tenMh", "Tên MH");
            dataGridView2.Columns.Add("soluong", "Số lượng bán");
        }
        
        private async void cbxThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();

                int month = Convert.ToInt32(cbxThang.SelectedItem.ToString());
                List<Services.Dto.HoaDonDto> a = await sellingController.GetAllHoaDon();
                List<Services.Dto.HoaDonDto> b = a.Where(hd => DateTime.ParseExact(hd.NgayLap, @"dd/MM/yyyy HH\:mm\:ss", CultureInfo.InvariantCulture).Month == month).ToList();
                lblDoanhthubanhang.Text = $"Doanh thu bán hàng: {b.Sum(hd => hd.ThanhTien).ToString("N0")}";
                lblSoluotmuahang.Text = $"Số lượt mua hàng: {b.Count()}";


                Series series;
                double total = 0;
                double percent_total = 0;
                double percent_item = 0;
                chart2.Series.Clear();

                List<MatHangDuocBanDto> listMhdbByTime = await sellingController.GetMatHangDuocBanByTime(month, DateTime.Now.Year);
                lblSosanphamban.Text = $"Số sản phẩm bán: {listMhdbByTime.Count()}";
                string[] distinctMatHang = listMhdbByTime.Select(mhdb => mhdb.MaMH).Distinct().ToArray();

                total = listMhdbByTime.Count();
                for(int i = 0; i < distinctMatHang.Count(); i++)
                {
                    MatHangDto matHang = await matHangController.GetMatHang(distinctMatHang[i]);
                    int countSp = listMhdbByTime.Where(mhdb => mhdb.MaMH.Equals(distinctMatHang[i])).Count();
                    if (i == distinctMatHang.Count() - 1)
                    {
                        percent_item = 100 - percent_total;
                    }
                    else
                    {
                        percent_item = (countSp / total) * 100;
                        percent_total += percent_item;
                    }
                    series = chart2.Series.Add($"Sp: {i+1}");
                    series.ChartType = SeriesChartType.StackedBar100;
                    series.Points.Add(new DataPoint()
                    {
                        YValues = new[] { percent_item },
                        ToolTip = $"{matHang.TenMatHang} - {countSp} - {percent_item:F1} %"
                    });

                    dataGridView1.Rows.Add(matHang.TenMatHang, countSp);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();

            //CHART DOANH THU HANH THANG
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

            lblDoanhthubanhang2.Text = "Doanh thu bán hàng: " + total.ToString("N0") + " VND";
            lblSoluotmuahang2.Text = "Số lượt mua hàng: " + b.Count().ToString();

            //CHART SAN PHAM BAN
            List<MatHangDuocBanDto> listMhdbByTime = await sellingController.GetMatHangDuocBanByTime(0, year);
            lblSosanphamban2.Text = $"Số sản phẩm bán: {listMhdbByTime.Count()}";
            string[] distinctMatHang = listMhdbByTime.Select(mhdb => mhdb.MaMH).Distinct().ToArray();

            Series series2;
            double total2 = 0;
            double percent_total2 = 0;
            double percent_item2 = 0;
            chart3.Series.Clear();
            total2 = listMhdbByTime.Count();
            for (int i = 0;i<distinctMatHang.Count();i++)
            {
                MatHangDto matHang = await matHangController.GetMatHang(distinctMatHang[i]);
                int countSp = listMhdbByTime.Where(mhdb => mhdb.MaMH.Equals(distinctMatHang[i])).Count();
                if (i == distinctMatHang.Count() - 1)
                {
                    percent_item2 = 100 - percent_total2;
                }
                else
                {
                    percent_item2 = (countSp / total2) * 100;
                }
                percent_total2 += percent_item2;
                series2 = chart3.Series.Add($"Sp: {i+1}");
                series2.ChartType = SeriesChartType.StackedBar100;
                series2.Points.Add(new DataPoint()
                {
                    YValues = new[] { percent_item2 },
                    ToolTip = $"{matHang.TenMatHang} - {countSp} - {percent_item2:F1} %"
                });

                dataGridView2.Rows.Add(matHang.TenMatHang, countSp);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
