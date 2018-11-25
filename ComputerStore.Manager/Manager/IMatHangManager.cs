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
        List<MatHang> GetMatHangFilter(string name, string loaiHang, string hsx);
        List<SanPham> GetAllSanPham();
        List<SanPham> GetSanPhamByMatHang(string idmh, int status);
        MatHang GetMatHang(string id);
        SanPham GetSanPham(string id);
        bool AddMatHang(MatHang matHang);
        bool AddSanPham(SanPham sanPham);
        bool EditMatHang(MatHang matHang);
        bool EditSanPham(SanPham sanPham);
    }
}
