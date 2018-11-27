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
                    computerStoreEntities = new ComputerStoreEntities();
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
                    computerStoreEntities = new ComputerStoreEntities();
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
                        computerStoreEntities = new ComputerStoreEntities();
                        MatHang x = computerStoreEntities.MatHangs.Single(mh => mh.MaMH.Equals(matHang.MaMH));
                        x.MaLH = matHang.MaLH;
                        x.MaHSX = matHang.MaHSX;
                        x.MaNPP = matHang.MaNPP;
                        x.TenMatHang = matHang.TenMatHang;
                        x.GiaNiemYet = matHang.GiaNiemYet;
                        computerStoreEntities.Entry(x).State = System.Data.Entity.EntityState.Modified;
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
                        computerStoreEntities = new ComputerStoreEntities();
                        SanPham sanPhamTemp = computerStoreEntities.SanPhams.Single(sp => sp.MaSP.Equals(sanPham.MaSP));
                        sanPhamTemp.Serial = sanPham.Serial;
                        sanPhamTemp.DonViTinh = sanPham.DonViTinh;
                        sanPhamTemp.NgayNhap = sanPham.NgayNhap;
                        sanPhamTemp.NgayXuat = sanPham.NgayXuat;
                        sanPhamTemp.TinhTrang = sanPhamTemp.TinhTrang;
                        computerStoreEntities.Entry(sanPhamTemp).State = System.Data.Entity.EntityState.Modified;
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

        public List<MatHang> GetMatHangFilter(string name, string loaiHang, string hsx)
        {
            return loaiHang.Equals("*") ?
                GetAllMatHang().Where(sp => sp.HangSanXuat.TenHSX.Equals(hsx))
                               .Where(sp2 => sp2.TenMatHang.ToLower().Contains(name)).ToList() :
                (
                GetAllMatHang().Where(sp => sp.LoaiHang.TenLoaiHang.Equals(loaiHang) &&
                                            sp.HangSanXuat.Equals(hsx))
                               .Where(sp2 => sp2.TenMatHang.ToLower().Contains(name)).ToList()
                               
                );
        }

        public List<SanPham> GetSanPhamByMatHang(string idmh, int status)
        {
            if(status == 1)
                return computerStoreEntities.SanPhams.Where(sp => sp.MatHang.MaMH.Equals(idmh) && sp.TinhTrang.Equals("OK")).ToList();
            if(status == 2)
                return computerStoreEntities.SanPhams.Where(sp => sp.MatHang.MaMH.Equals(idmh) && sp.TinhTrang.Equals("Sold")).ToList();
            if(status == 3)
                return computerStoreEntities.SanPhams.Where(sp => sp.MatHang.MaMH.Equals(idmh) && sp.TinhTrang.Equals("Stop")).ToList();
            return computerStoreEntities.SanPhams.Where(sp => sp.MatHang.MaMH.Equals(idmh)).ToList();
        }
    }
}
