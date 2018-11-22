using ComputerStore.Manager.Models;
using ComputerStore.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Services.Adaptor
{
    public class LoaiHangAdaptor
    {
        public LoaiHangDto GetLoaiHangDto(LoaiHang loaiHang)
        {
            LoaiHangDto loaiHangDto = new LoaiHangDto();
            loaiHangDto.MaLH = loaiHang.MaLH;
            loaiHangDto.TenLH = loaiHang.TenLoaiHang;
            return loaiHangDto;
        }

        public List<LoaiHangDto> GetListLoaiHangDto(List<LoaiHang> loaiHangs)
        {
            List<LoaiHangDto> loaiHangDtos = new List<LoaiHangDto>();
            foreach(LoaiHang lh in loaiHangs)
            {
                loaiHangDtos.Add(GetLoaiHangDto(lh));
            }
            return loaiHangDtos;
        }
    }
}
