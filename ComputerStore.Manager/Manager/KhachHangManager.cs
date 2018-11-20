using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerStore.Manager.Models;

namespace ComputerStore.Manager.Manager
{
    class KhachHangManager : IKhachHangManager
    {
        private ComputerStoreEntities computerStoreEntities;

        public KhachHangManager() => computerStoreEntities = new ComputerStoreEntities();

        public bool AddKhachHang(KhachHang khach)
        {
            try
            {
                Random random = new Random();
                string id;
                if (khach != null)
                {
                    if (computerStoreEntities.KhachHangs.Any(kh => kh.Email.Equals(khach.Email)) && (khach.Email != ""))
                        return false;
                    do
                    {
                        id = Convert.ToInt64(random.Next() + random.Next()).ToString("D10");
                    }
                    while (computerStoreEntities.KhachHangs.Any(kh => kh.MaKH.Equals(id)));
                    khach.MaKH = id;
                    computerStoreEntities.KhachHangs.Add(khach);
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

        public List<KhachHang> GetAllKhachHang() => computerStoreEntities.KhachHangs.OrderBy(kh => kh.TenKH).ToList();

        public KhachHang GetKhachHang(string maKH) => computerStoreEntities.KhachHangs.SingleOrDefault(kh => kh.MaKH.Equals(maKH));
    }
}
