using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ComputerStore.Manager.Manager;
using ComputerStore.Services.Adaptor;
using ComputerStore.Services.Dto;

namespace ComputerStore.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SellingService" in both code and config file together.
    public class SellingService : ISellingService
    {
        MatHangDuocBanAdaptor matHangDuocBanAdaptor = new MatHangDuocBanAdaptor();
        HoaDonAdaptor hoaDonAdaptor = new HoaDonAdaptor();
        BaoHanhAdaptor baoHanhAdaptor = new BaoHanhAdaptor();
        SellingManager sellingManager;

        SellingManager SellingManager => sellingManager ?? (sellingManager = new SellingManager());

        public bool BanHang(List<MatHangDuocBanDto> mhdbDtos, string idNV, string idKH, long tienkhachtra)
        {
            return SellingManager.BanHang(matHangDuocBanAdaptor.ToListMatHangDuocBanEntity(mhdbDtos), idNV, idKH, tienkhachtra);
        }

        //public MatHangDuocBanDto CreateTempMatHangDuocBan(string id, int km)
        //{
        //    return matHangDuocBanAdaptor.GetMatHangDuocBanDto(SellingManager.CreateTempMatHangDuocBan(id, km));
        //}

        public List<HoaDonDto> GetAllHoaDon()
        {
            return hoaDonAdaptor.GetListHoaDonDto(SellingManager.GetAllHoaDon());
        }

        public List<BaoHanhDto> GetBaoHanhByKhachHang(string makh)
        {
            return baoHanhAdaptor.GetListBaoHanhDto(SellingManager.GetBaoHanhByKhachHang(makh));
        }

        public HoaDonDto GetHoaDon(string id)
        {
            return hoaDonAdaptor.GetHoaDonDto(SellingManager.GetHoaDon(id));
        }

        public List<HoaDonDto> GetHoaDonFilter(string mahd, string from, string to)
        {
            return hoaDonAdaptor.GetListHoaDonDto(SellingManager.GetHoaDonFilter(mahd, from, to));
        }

        public List<MatHangDuocBanDto> GetMatHangDuocBan(string idHD)
        {
            return matHangDuocBanAdaptor.GetListMatHangDuocBanDto(SellingManager.GetMatHangDuocBansByHoaDon(idHD));
        }

        public List<MatHangDuocBanDto> GetMatHangDuocBanByTime(int month, int year)
        {
            return matHangDuocBanAdaptor.GetListMatHangDuocBanDto(SellingManager.GetMatHangDuocBanByTime(month, year));
        }
    }
}
