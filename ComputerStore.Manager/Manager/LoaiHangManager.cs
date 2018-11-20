using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerStore.Manager.Models;

namespace ComputerStore.Manager.Manager
{
    class LoaiHangManager : ILoaiHangManager
    {
        private ComputerStoreEntities computerStoreEntities;

        public LoaiHangManager() => computerStoreEntities = new ComputerStoreEntities();

        public bool AddHangSanXuat(HangSanXuat hangSanXuat)
        {
            Random random = new Random();
            string id;
            try
            {
                if (hangSanXuat != null)
                {
                    do
                    {
                        id = id = Convert.ToInt64(random.Next() + random.Next()).ToString("D10");
                    }
                    while (computerStoreEntities.HangSanXuats.Any(hsx => hsx.MaHSX.Equals(id)));
                    hangSanXuat.MaHSX = id;
                    computerStoreEntities.HangSanXuats.Add(hangSanXuat);
                    computerStoreEntities.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AddLoaiHang(LoaiHang loaiHang)
        {
            try
            {
                Random random = new Random();
                string id;
                if (loaiHang != null)
                {
                    do
                    {
                        id = id = Convert.ToInt64(random.Next() + random.Next()).ToString("D10");
                    }
                    while (computerStoreEntities.LoaiHangs.Any(lh => lh.MaLH.Equals(id)));
                    loaiHang.MaLH = id;
                    computerStoreEntities.LoaiHangs.Add(loaiHang);
                    computerStoreEntities.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool AddNhaPhanPhoi(NhaPhanPhoi nhaPhanPhoi)
        {
            Random random = new Random();
            string id;
            try
            {
                if (nhaPhanPhoi != null)
                {
                    do
                    {
                        id = id = Convert.ToInt64(random.Next() + random.Next()).ToString("D10");
                    }
                    while (computerStoreEntities.NhaPhanPhois.Any(npp => npp.MaNPP.Equals(id)));
                    nhaPhanPhoi.MaNPP = id;
                    computerStoreEntities.NhaPhanPhois.Add(nhaPhanPhoi);
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

        public List<HangSanXuat> GetAllHangSanXuat() => computerStoreEntities.HangSanXuats.OrderBy(hsx => hsx.TenHSX).ToList();

        public List<LoaiHang> GetAllLoaiHang() => computerStoreEntities.LoaiHangs.OrderBy(lh => lh.TenLoaiHang).ToList();

        public List<NhaPhanPhoi> GetAllNhaPhanPhoi() => computerStoreEntities.NhaPhanPhois.OrderBy(npp => npp.TenNhaPhanPhoi).ToList();

        public HangSanXuat GetHangSanXuat(string id) => computerStoreEntities.HangSanXuats.SingleOrDefault(hsx => hsx.MaHSX.Equals(id));

        public LoaiHang GetLoaiHang(string id) => computerStoreEntities.LoaiHangs.SingleOrDefault(lh => lh.MaLH.Equals(id));

        public NhaPhanPhoi GetNhaPhanPhoi(string id) => computerStoreEntities.NhaPhanPhois.SingleOrDefault(npp => npp.MaNPP.Equals(id));
    }
}
