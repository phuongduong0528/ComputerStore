using ComputerStore.Manager.Models;
using ComputerStore.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Services.Adaptor
{
    public class MatHangAdaptor
    {
        public MatHangDto GetMatHangDto(MatHang matHang)
        {
            MatHangDto matHangDto = new MatHangDto();
            matHangDto.MaMH = matHang.MaMH;
            matHangDto.LoaiHang = matHang.LoaiHang.TenLoaiHang;
            matHangDto.HangSanXuat = matHang.HangSanXuat.TenHSX;
            matHangDto.NhaPhanPhoi = matHang.NhaPhanPhoi.TenNhaPhanPhoi;
            matHangDto.TenMatHang = matHang.TenMatHang;
            matHangDto.SoLuong = matHang.SanPhams.Count();
            matHangDto.GiaNiemYet = matHang.GiaNiemYet.Value;
            return matHangDto;
        }

        public List<MatHangDto> GetListMatHangDto(List<MatHang> matHangs)
        {
            List<MatHangDto> matHangDtos = new List<MatHangDto>();
            foreach(MatHang mh in matHangs)
            {
                matHangDtos.Add(GetMatHangDto(mh));
            }
            return matHangDtos;
        }
        
        public MatHang ToMatHangEntity(MatHangDto matHangDto)
        {
            try
            {
                MatHang matHang = new MatHang();
                matHang.MaMH = matHangDto.MaMH;
                using(ComputerStoreEntities entities = new ComputerStoreEntities())
                {
                    matHang.MaLH = entities.LoaiHangs.FirstOrDefault(lh => lh.TenLoaiHang.Equals(matHangDto.LoaiHang)).MaLH;
                    matHang.MaHSX = entities.HangSanXuats.FirstOrDefault(hsx => hsx.TenHSX.Equals(matHangDto.HangSanXuat)).MaHSX;
                    matHang.MaNPP = entities.NhaPhanPhois.FirstOrDefault(npp => npp.TenNhaPhanPhoi.Equals(matHangDto.NhaPhanPhoi)).MaNPP;
                }
                matHang.TenMatHang = matHangDto.TenMatHang;
                matHang.GiaNiemYet = matHangDto.GiaNiemYet;
                return matHang;
            }
            catch(Exception e)
            {
                return null;
            }
        }
    }
}
