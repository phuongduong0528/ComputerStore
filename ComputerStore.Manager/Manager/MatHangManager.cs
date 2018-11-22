using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerStore.Manager.Models;

namespace ComputerStore.Manager.Manager
{
    public class MatHangManager : IMatHangManager
    {
        private ComputerStoreEntities computerStoreEntities;
        public MatHangManager() => computerStoreEntities = new ComputerStoreEntities();

        public bool AddMatHang(MatHang matHang)
        {
            Random random = new Random();
            string id;
            try
            {
                if (matHang != null)
                {
                    do
                    {
                        id = Convert.ToInt64(random.Next() + random.Next()).ToString("D10");
                    }
                    while (computerStoreEntities.MatHangs.Any(mh => mh.MaMH.Equals(id)));
                    matHang.MaMH = id;
                    computerStoreEntities.MatHangs.Add(matHang);
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

        public bool AddSanPham(SanPham sanPham)
        {
            Random random = new Random();
            string id;
            try
            {
                if (sanPham != null)
                {
                    do
                    {
                        id = Convert.ToInt64(random.Next() + random.Next()).ToString("D10");
                    }
                    while (computerStoreEntities.SanPhams.Any(sp => sp.MaSP.Equals(id)));
                    sanPham.MaSP = id;
                    computerStoreEntities.SanPhams.Add(sanPham);
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

        public bool EditMatHang(MatHang matHang)
        {
            try
            {
                if (matHang != null)
                {
                    if (!computerStoreEntities.MatHangs.Any(mh => mh.MaMH.Equals(matHang.MaMH)))
                        return false;
                    else
                    {
                        computerStoreEntities.Entry(matHang).State = System.Data.Entity.EntityState.Modified;
                        computerStoreEntities.SaveChanges();
                        return true;
                    }
                }
                else
                    return false;
                
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool EditSanPham(SanPham sanPham)
        {
            try
            {
                if (sanPham != null)
                {
                    if (!computerStoreEntities.SanPhams.Any(sp=>sp.MaSP.Equals(sanPham.MaSP)))
                        return false;
                    else
                    {
                        computerStoreEntities.Entry(sanPham).State = System.Data.Entity.EntityState.Modified;
                        computerStoreEntities.SaveChanges();
                        return true;
                    }
                }
                else
                    return false;

            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<MatHang> GetAllMatHang() => computerStoreEntities.MatHangs.OrderBy(mh => mh.TenMatHang).ToList();

        public List<SanPham> GetAllSanPham() => computerStoreEntities.SanPhams.OrderBy(sp => sp.Serial).ToList();

        public MatHang GetMatHang(string id) => computerStoreEntities.MatHangs.SingleOrDefault(mh => mh.MaMH.Equals(id));

        public SanPham GetSanPham(string id) => computerStoreEntities.SanPhams.SingleOrDefault(sp => sp.MaSP.Equals(id));
    }
}
