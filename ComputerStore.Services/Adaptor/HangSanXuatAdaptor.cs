using ComputerStore.Manager.Models;
using ComputerStore.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Services.Adaptor
{
    public class HangSanXuatAdaptor
    {
        public HangSanXuatDto GetHangSanXuatDto(HangSanXuat hangSanXuat)
        {
            HangSanXuatDto hangSanXuatDto = new HangSanXuatDto();
            hangSanXuatDto.MaHSX = hangSanXuat.MaHSX;
            hangSanXuatDto.TenHSX = hangSanXuat.TenHSX;
            return hangSanXuatDto;
        }

        public List<HangSanXuatDto> GetListHangSanXuatDto(List<HangSanXuat> hangSanXuats)
        {
            List<HangSanXuatDto> hangSanXuatDtos = new List<HangSanXuatDto>();
            foreach(HangSanXuat hsx in hangSanXuats)
            {
                hangSanXuatDtos.Add(GetHangSanXuatDto(hsx));
            }
            return hangSanXuatDtos;
        }
    }
}
