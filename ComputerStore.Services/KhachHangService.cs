using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ComputerStore.Services.Adaptor;
using ComputerStore.Services.Dto;
using ComputerStore.Manager.Manager;

namespace ComputerStore.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "KhachHangService" in both code and config file together.
    public class KhachHangService : IKhachHangService
    {
        KhachHangAdaptor khachHangAdaptor = new KhachHangAdaptor();
        KhachHangManager khachHangManager;

        KhachHangManager KhachHangManager => khachHangManager ?? (khachHangManager = new KhachHangManager());

        public bool AddKhachHang(KhachHangDto khachHangDto)
        {
            return KhachHangManager.AddKhachHang(khachHangAdaptor.ToKhachHangEntity(khachHangDto));
        }

        public List<KhachHangDto> GetAllKhachHang()
        {
            return khachHangAdaptor.GetListKhachHangDto(KhachHangManager.GetAllKhachHang());
        }

        public KhachHangDto GetKhachHang(string id)
        {
            return khachHangAdaptor.GetKhachHangDto(KhachHangManager.GetKhachHang(id));
        }
    }
}
