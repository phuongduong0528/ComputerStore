using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerStore.Manager.Models;

namespace ComputerStore.Manager.Manager
{
    public class SellingManager : ISellingManager
    {
        private ComputerStoreEntities computerStoreEntities;
        private readonly MatHangManager matHangManager = new MatHangManager();
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
                    HoaDon newHD = new HoaDon();
                    newHD.MaHD = hoaDon.MaHD;
                    newHD.MaNV = hoaDon.MaNV;
                    newHD.MaKH = hoaDon.MaKH;
                    newHD.NgayLap = hoaDon.NgayLap;
                    newHD.ThanhTien = hoaDon.ThanhTien;
                    computerStoreEntities.HoaDons.Add(newHD);
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
                    MatHangDuocBan newMHDB = new MatHangDuocBan();
                    newMHDB.ID = matHangDuocBan.ID;
                    newMHDB.MaHD = matHangDuocBan.MaHD;
                    newMHDB.KhuyenMai = matHangDuocBan.KhuyenMai;
                    newMHDB.MaSP = matHangDuocBan.MaSP;
                    computerStoreEntities.MatHangDuocBans.Add(newMHDB);
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
            HoaDon hoaDon = new HoaDon();
            long? total = 0;
            try
            {
                hoaDon.MaHD = (computerStoreEntities.HoaDons.Count() + 1).ToString("D10");
                hoaDon.MaKH = maKH;
                hoaDon.MaNV = maNV;
                hoaDon.NgayLap = DateTime.Now;
                AddHoaDon(hoaDon);
                foreach (MatHangDuocBan mh in mhdb)
                {
                    SanPham tempSp = matHangManager.GetSanPham(mh.MaSP);
                    tempSp.TinhTrang = "Sold";
                    tempSp.NgayXuat = DateTime.Now;
                    matHangManager.EditSanPham(tempSp);

                    mh.ID = (computerStoreEntities.MatHangDuocBans.Count() + 1).ToString("D10");
                    mh.MaHD = hoaDon.MaHD;
                    AddMatHangDuocBan(mh);
                }

                computerStoreEntities = new ComputerStoreEntities();
                var test = computerStoreEntities.MatHangDuocBans.Where(mh=>mh.MaHD.Equals(hoaDon.MaHD));
                foreach (var a in test)
                {
                    total += a.SanPham.MatHang.GiaNiemYet - ((a.SanPham.MatHang.GiaNiemYet/100) * a.KhuyenMai);
                }
                var ab = GetHoaDon(hoaDon.MaHD);
                ab.ThanhTien = total;
                computerStoreEntities.Entry(ab).State = System.Data.Entity.EntityState.Modified;
                computerStoreEntities.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                for(int i = 0; i < 10; i++)
                {
                    try
                    {
                        total = 0;
                        computerStoreEntities = new ComputerStoreEntities();
                        var test = computerStoreEntities.MatHangDuocBans.Where(mh => mh.MaHD.Equals(hoaDon.MaHD));
                        foreach (var a in test)
                        {
                            total += a.SanPham.MatHang.GiaNiemYet - ((a.SanPham.MatHang.GiaNiemYet / 100) * a.KhuyenMai);
                        }
                        var ab = GetHoaDon(hoaDon.MaHD);
                        ab.ThanhTien = total;
                        computerStoreEntities.Entry(ab).State = System.Data.Entity.EntityState.Modified;
                        computerStoreEntities.SaveChanges();
                        return true;
                    }
                    catch(Exception ex2)
                    {
                    }
                }
                return false;
            }
        }

        public MatHangDuocBan CreateTempMatHangDuocBan(string maSP, int km)
        {
            try
            {
                MatHangDuocBan mhdb = new MatHangDuocBan();
                mhdb.ID = (computerStoreEntities.MatHangDuocBans.Count() + 1).ToString("D10");
                mhdb.MaHD = "0000000000";
                mhdb.MaSP = maSP;
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

        public List<HoaDon> GetHoaDonFilter(string mahd, string from, string to)
        {
            DateTime dtFrom = DateTime.ParseExact(from, @"dd/MM/yyyy HH\:mm\:ss", CultureInfo.InvariantCulture);
            DateTime dtTo = DateTime.ParseExact(to, @"dd/MM/yyyy HH\:mm\:ss", CultureInfo.InvariantCulture);
            return mahd.Equals("") ? computerStoreEntities.HoaDons.Where(hd => hd.NgayLap >= dtFrom &&
                                                             hd.NgayLap <= dtTo).ToList() :

                                     computerStoreEntities.HoaDons.Where(hd => hd.MaHD.Contains(mahd) &&
                                                             (hd.NgayLap >= dtFrom &&
                                                             hd.NgayLap <= dtTo)).ToList();
        }
    }
}
