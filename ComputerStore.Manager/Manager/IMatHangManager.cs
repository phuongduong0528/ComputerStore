using ComputerStore.Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Manager.Manager
{
    interface IMatHangManager
    {
        List<MatHang> GetAllMatHang();
        List<SanPham> GetAllSanPham();
        List<SanPham> GetSanPhamFilter(string loaiHang, string hsx);
        MatHang GetMatHang(string id);
        SanPham GetSanPham(string id);
        bool AddMatHang(MatHang matHang);
        bool AddSanPham(SanPham sanPham);
        bool EditMatHang(MatHang matHang);
        bool EditSanPham(SanPham sanPham);
    }
}
