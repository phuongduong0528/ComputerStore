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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LoaiHangService" in both code and config file together.
    public class LoaiHangService : ILoaiHangService
    {
        LoaiHangAdaptor loaiHangAdaptor = new LoaiHangAdaptor();
        HangSanXuatAdaptor hangSanXuatAdaptor = new HangSanXuatAdaptor();
        NhaPhanPhoiAdaptor nhaPhanPhoiAdaptor = new NhaPhanPhoiAdaptor();
        LoaiHangManager loaiHangManager;

        LoaiHangManager LoaiHangManager => loaiHangManager ?? (loaiHangManager = new LoaiHangManager());

        public bool AddNhaPhanPhoi(NhaPhanPhoiDto nhaPhanPhoiDto)
        {
            return loaiHangManager.AddNhaPhanPhoi(nhaPhanPhoiAdaptor.ToNhaPhanPhoiEntity(nhaPhanPhoiDto));
        }

        public List<HangSanXuatDto> GetAllHangSanXuat()
        {
            return hangSanXuatAdaptor.GetListHangSanXuatDto(LoaiHangManager.GetAllHangSanXuat());
        }

        public List<LoaiHangDto> GetAllLoaiHang()
        {
            return loaiHangAdaptor.GetListLoaiHangDto(LoaiHangManager.GetAllLoaiHang());
        }

        public List<NhaPhanPhoiDto> GetAllNhaPhanPhoi()
        {
            return nhaPhanPhoiAdaptor.GetListNhaPhanPhoiDto(LoaiHangManager.GetAllNhaPhanPhoi());
        }

        public HangSanXuatDto GetHangSanXuat(string id)
        {
            return hangSanXuatAdaptor.GetHangSanXuatDto(LoaiHangManager.GetHangSanXuat(id));
        }

        public LoaiHangDto GetLoaiHang(string id)
        {
            return loaiHangAdaptor.GetLoaiHangDto(LoaiHangManager.GetLoaiHang(id));
        }

        public NhaPhanPhoiDto GetNhaPhanPhoi(string id)
        {
            return nhaPhanPhoiAdaptor.GetNhaPhanPhoiDto(LoaiHangManager.GetNhaPhanPhoi(id));
        }
    }
}
