using ComputerStore.Manager.Models;
using ComputerStore.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Services.Adaptor
{
    public class MatHangDuocBanAdaptor
    {
        public MatHangDuocBanDto GetMatHangDuocBanDto(MatHangDuocBan matHangDuocBan)
        {
            MatHangDuocBanDto matHangDuocBanDto = new MatHangDuocBanDto();
            matHangDuocBanDto.ID = matHangDuocBan.ID;
            matHangDuocBanDto.TenSP = matHangDuocBan.SanPham.MatHang.TenMatHang;
            matHangDuocBanDto.Serial = matHangDuocBan.SanPham.Serial;
            matHangDuocBanDto.KhuyenMai = matHangDuocBan.KhuyenMai.Value;
            matHangDuocBanDto.Gia = matHangDuocBan.SanPham.MatHang.GiaNiemYet.Value -
                ((matHangDuocBan.SanPham.MatHang.GiaNiemYet.Value / 100) * matHangDuocBanDto.KhuyenMai);
            matHangDuocBanDto.MaHD = matHangDuocBan.MaHD;
            matHangDuocBanDto.MaSP = matHangDuocBan.MaSP;
            matHangDuocBanDto.MaMH = matHangDuocBan.SanPham.MaMH;
            return matHangDuocBanDto;
        }

        public List<MatHangDuocBanDto> GetListMatHangDuocBanDto(List<MatHangDuocBan> matHangDuocBans)
        {
            List<MatHangDuocBanDto> matHangDuocBanDtos = new List<MatHangDuocBanDto>();
            foreach(MatHangDuocBan mhdb in matHangDuocBans)
            {
                matHangDuocBanDtos.Add(GetMatHangDuocBanDto(mhdb));
            }
            return matHangDuocBanDtos;
        }

        public MatHangDuocBan ToMatHangDuocBanEntity(MatHangDuocBanDto matHangDuocBanDto)
        {
            MatHangDuocBan x = new MatHangDuocBan();
            x.ID = matHangDuocBanDto.ID;
            x.MaSP = matHangDuocBanDto.MaSP;
            x.MaHD = matHangDuocBanDto.MaHD;
            x.KhuyenMai = matHangDuocBanDto.KhuyenMai;
            return x;
        }

        public List<MatHangDuocBan> ToListMatHangDuocBanEntity(List<MatHangDuocBanDto> matHangDuocBanDtos)
        {
            List<MatHangDuocBan> matHangDuocBans = new List<MatHangDuocBan>();
            foreach(MatHangDuocBanDto mh in matHangDuocBanDtos)
            {
                matHangDuocBans.Add(ToMatHangDuocBanEntity(mh));
            }
            return matHangDuocBans;
        }
    }
}
