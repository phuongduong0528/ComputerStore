using ComputerStore.Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Manager.Manager
{
    interface ISellingManager
    {
        List<HoaDon> GetAllHoaDon();
        List<MatHangDuocBan> GetMatHangDuocBansByHoaDon(string maHD);
        HoaDon GetHoaDon(string id);
        MatHangDuocBan GetMatHangDuocBan(string id);
        bool AddHoaDon(HoaDon hoaDon);
        bool AddMatHangDuocBan(MatHangDuocBan matHangDuocBan);
        MatHangDuocBan CreateTempMatHangDuocBan(string maSP, int km);
        bool BanHang(List<MatHangDuocBan> mhdb, string maNV, string maKH);
        bool AddBaoHanh(string maSP, string maKH, TimeSpan duration);
    }
}
