using ComputerStore.Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Manager.Manager
{
    interface ILoaiHangManager
    {
        List<LoaiHang> GetAllLoaiHang();
        List<HangSanXuat> GetAllHangSanXuat();
        List<NhaPhanPhoi> GetAllNhaPhanPhoi();
        LoaiHang GetLoaiHang(string id);
        HangSanXuat GetHangSanXuat(string id);
        NhaPhanPhoi GetNhaPhanPhoi(string id);
        bool AddLoaiHang(LoaiHang loaiHang);
        bool AddHangSanXuat(HangSanXuat hangSanXuat);
        bool AddNhaPhanPhoi(NhaPhanPhoi nhaPhanPhoi);
    }
}
