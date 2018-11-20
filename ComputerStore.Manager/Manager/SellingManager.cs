using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerStore.Manager.Models;

namespace ComputerStore.Manager.Manager
{
    class SellingManager : ISellingManager
    {
        private ComputerStoreEntities computerStoreEntities;
        public SellingManager() => computerStoreEntities = new ComputerStoreEntities();

        public bool AddBaoHanh(string maSP, string maKH, TimeSpan duration)
        {
            try
            {
                BaoHanh baoHanh = new BaoHanh();
                baoHanh.MaBH = (computerStoreEntities.BaoHanhs.Count() + 1).ToString("D10");
                baoHanh.MaSP = maSP;
                baoHanh.MaKH = maKH;
                baoHanh.NgayKichHoatBH = DateTime.Now;
                baoHanh.NgayKetThucBH = baoHanh.NgayKichHoatBH.Value.Add(duration);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool AddHoaDon(HoaDon hoaDon)
        {
            try
            {
                if (hoaDon != null)
                {                    
                    computerStoreEntities.HoaDons.Add(hoaDon);
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

        public bool AddMatHangDuocBan(MatHangDuocBan matHangDuocBan)
        {
            try
            {
                if (matHangDuocBan != null)
                {                    
                    computerStoreEntities.MatHangDuocBans.Add(matHangDuocBan);
                    computerStoreEntities.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        
        public bool BanHang(List<MatHangDuocBan> mhdb, string maNV, string maKH)
        {
            try
            {
                long? total = 0;
                HoaDon hoaDon = new HoaDon();
                hoaDon.MaHD = (computerStoreEntities.HoaDons.Count() + 1).ToString("D10");
                hoaDon.MaKH = maKH;
                hoaDon.MaNV = maNV;
                hoaDon.NgayLap = DateTime.Now;
                foreach (var x in mhdb)
                {
                    x.ID = (computerStoreEntities.MatHangDuocBans.Count() + 1).ToString("D10");
                    x.MaHD = hoaDon.MaHD;
                    total += x.SanPham.MatHang.GiaNiemYet - ((x.SanPham.MatHang.GiaNiemYet / 100) * x.KhuyenMai);
                    AddMatHangDuocBan(x);
                }
                hoaDon.ThanhTien = total;
                AddHoaDon(hoaDon);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public MatHangDuocBan CreateTempMatHangDuocBan(string maSP, int soLuong, int km)
        {
            try
            {
                MatHangDuocBan mhdb = new MatHangDuocBan();
                mhdb.ID = (computerStoreEntities.MatHangDuocBans.Count() + 1).ToString("D10");
                mhdb.MaSP = maSP;
                mhdb.SoLuong = soLuong;
                mhdb.KhuyenMai = km;
                return mhdb;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public List<HoaDon> GetAllHoaDon() => computerStoreEntities.HoaDons.OrderByDescending(hd => hd.NgayLap).ToList();

        public HoaDon GetHoaDon(string id) => computerStoreEntities.HoaDons.SingleOrDefault(hd => hd.MaHD.Equals(id));

        public MatHangDuocBan GetMatHangDuocBan(string id) => computerStoreEntities.MatHangDuocBans
                .SingleOrDefault(mhdb => mhdb.ID.Equals(id));

        public List<MatHangDuocBan> GetMatHangDuocBansByHoaDon(string maHD) => computerStoreEntities.MatHangDuocBans
                .Where(mhdb => mhdb.HoaDon.MaHD.Equals(maHD))
                .OrderBy(mhdb => mhdb.HoaDon.NgayLap)
                .ToList();
    }
}
