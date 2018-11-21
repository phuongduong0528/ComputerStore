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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "NhanVienService" in both code and config file together.
    public class NhanVienService : INhanVienService
    {
        NhanVienAdaptor nhanVienAdaptor = new NhanVienAdaptor();
        NhanVienManager nhanVienManager;

        NhanVienManager NhanVienManager => nhanVienManager ?? (nhanVienManager = new NhanVienManager());

        public bool AddNhanVien(NhanVienDto nhanVien)
        {
            return NhanVienManager.AddNhanVien(nhanVienAdaptor.ToNhanVienEntity(nhanVien));
        }

        public int Authenticate(string id, string pass)
        {
            return NhanVienManager.Authenticate(id, pass);
        }

        public bool EditNhanVien(NhanVienDto nhanVien)
        {
            return NhanVienManager.EditNhanVien(nhanVienAdaptor.ToNhanVienEntity(nhanVien));
        }

        public List<NhanVienDto> GetAllNhanVien()
        {
            return nhanVienAdaptor.GetListNhanVienDto(NhanVienManager.GetAllNhanVien());
        }

        public NhanVienDto GetNhanVien(string id)
        {
            return nhanVienAdaptor.GetNhanVienDto(NhanVienManager.GetNhanVien(id));
        }

        public bool LockAccount(string id)
        {
            return NhanVienManager.LockAccount(id);
        }
    }
}
