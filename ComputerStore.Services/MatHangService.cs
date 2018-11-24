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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MatHangService" in both code and config file together.
    public class MatHangService : IMatHangService
    {
        MatHangAdaptor matHangAdaptor = new MatHangAdaptor();
        SanPhamAdaptor sanPhamAdaptor = new SanPhamAdaptor();
        MatHangManager matHangManager;
        

        MatHangManager MatHangManager => matHangManager ?? (matHangManager = new MatHangManager());

        public bool AddMatHang(MatHangDto matHangDto)
        {
            return MatHangManager.AddMatHang(matHangAdaptor.ToMatHangEntity(matHangDto));
        }

        public bool AddSanPham(SanPhamDto sanPhamDto)
        {
            return MatHangManager.AddSanPham(sanPhamAdaptor.ToSanPhamEntity(sanPhamDto));
        }

        public bool EditMatHang(MatHangDto matHangDto)
        {
            return MatHangManager.EditMatHang(matHangAdaptor.ToMatHangEntity(matHangDto));
        }

        public bool EditSanPham(SanPhamDto sanPhamDto)
        {
            return MatHangManager.EditSanPham(sanPhamAdaptor.ToSanPhamEntity(sanPhamDto));
        }

        public List<MatHangDto> GetAllMatHang()
        {
            return matHangAdaptor.GetListMatHangDto(MatHangManager.GetAllMatHang());
        }

        public List<SanPhamDto> GetAllSanPham()
        {
            return sanPhamAdaptor.GetListSanPhamDto(MatHangManager.GetAllSanPham());
        }

        public MatHangDto GetMatHang(string id)
        {
            return matHangAdaptor.GetMatHangDto(MatHangManager.GetMatHang(id));
        }

        public SanPhamDto GetSanPham(string id)
        {
            return sanPhamAdaptor.GetSanPhamDto(MatHangManager.GetSanPham(id));
        }

        public List<SanPhamDto> GetSanPhamFilter(string lh, string hsx)
        {
            return sanPhamAdaptor.GetListSanPhamDto(MatHangManager.GetSanPhamFilter(lh, hsx));
        }
    }
}
