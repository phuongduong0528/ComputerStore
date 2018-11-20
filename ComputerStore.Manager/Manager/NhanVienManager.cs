using ComputerStore.Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Manager.Manager
{
    class NhanVienManager : INhanVienManager
    {
        private ComputerStoreEntities computerStoreEntities;

        public NhanVienManager() => computerStoreEntities = new ComputerStoreEntities();

        public bool AddNhanVien(NhanVien nhanVien)
        {
            try
            {
                Random random = new Random();
                string id;
                if(nhanVien != null)
                {
                    if (computerStoreEntities.NhanViens.Any(nv => nv.Email.Equals(nhanVien.Email)) && (nhanVien.Email != ""))
                        return false;
                    do
                    {
                        id = Convert.ToInt64(random.Next() + random.Next()).ToString("D10");
                    }
                    while (computerStoreEntities.NhanViens.Any(nv => nv.MaNV.Equals(id)));
                    nhanVien.MaNV = id;
                    computerStoreEntities.NhanViens.Add(nhanVien);
                    computerStoreEntities.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public int Authenticate(string id, string password)
        {
            var checkUser = computerStoreEntities.NhanViens
                .Any(nv => nv.MaNV.Equals(id) && nv.MatKhau.Equals(password));
            if (!checkUser)
                return 0;
            else
            {
                NhanVien nhanVien = computerStoreEntities.NhanViens
                    .Single(nv => nv.MaNV.Equals(id) && nv.MatKhau.Equals(password));
                return nhanVien.KhoaTK == 0 ? 1 : -1;
            }
        }

        public bool EditNhanVien(NhanVien nhanVien)
        {
            try
            {
                if (!computerStoreEntities.NhanViens.Any(nv => nv.MaNV.Equals(nhanVien.MaNV)))
                    return false;
                else
                {
                    NhanVien nvTemp = computerStoreEntities.NhanViens.Single(nv => nv.MaNV.Equals(nhanVien.MaNV));
                    nvTemp.QuyenHan = nhanVien.QuyenHan;
                    nvTemp.HoDem = nhanVien.HoDem;
                    nvTemp.Ten = nhanVien.Ten;
                    nvTemp.NgaySinh = nhanVien.NgaySinh;
                    nvTemp.DiaChi = nhanVien.DiaChi;
                    nvTemp.Email = nhanVien.Email;
                    nvTemp.SDT = nhanVien.SDT;
                    nvTemp.MatKhau = nhanVien.MatKhau;
                    computerStoreEntities.Entry(nvTemp).State = System.Data.Entity.EntityState.Modified;
                    computerStoreEntities.SaveChanges();
                    return true;
                }
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public List<NhanVien> GetAllNhanVien() => computerStoreEntities.NhanViens.OrderBy(nv => nv.Ten).ToList();

        public NhanVien GetNhanVien(string maNV) => computerStoreEntities.NhanViens.SingleOrDefault(nv => nv.MaNV.Equals(maNV));

        public bool LockAccount(string id)
        {
            if (!computerStoreEntities.NhanViens.Any(nv => nv.MaNV.Equals(id)))
                return false;
            else
            {
                NhanVien nhanVien = computerStoreEntities.NhanViens.Single(nv => nv.MaNV.Equals(id));
                nhanVien.KhoaTK = nhanVien.KhoaTK == 0 ? 1 : 0;
                computerStoreEntities.Entry(nhanVien).State = System.Data.Entity.EntityState.Modified;
                computerStoreEntities.SaveChanges();
                return true;
            }
        }
    }
}
