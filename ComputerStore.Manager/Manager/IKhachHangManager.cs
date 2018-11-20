using ComputerStore.Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Manager.Manager
{
    interface IKhachHangManager
    {
        List<KhachHang> GetAllKhachHang();
        KhachHang GetKhachHang(string maKH);
        bool AddKhachHang(KhachHang khach);
    }
}
