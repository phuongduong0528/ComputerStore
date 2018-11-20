using ComputerStore.Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Manager.Manager
{
    interface INhanVienManager
    {
        int Authenticate(string userName, string password);
        bool AddNhanVien(NhanVien nhanVien);
        bool EditNhanVien(NhanVien nhanVien);
        bool LockAccount(string id);
        List<NhanVien> GetAllNhanVien();
        NhanVien GetNhanVien(string maNV);
    }
}
