using ComputerStore.Manager.Models;
using ComputerStore.Services.Dto;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Services.Adaptor
{
    public class BaoHanhAdaptor
    {
        public BaoHanhDto GetBaoHanhDto(BaoHanh baoHanh)
        {
            BaoHanhDto baoHanhDto = new BaoHanhDto();
            baoHanhDto.MaBH = baoHanh.MaBH;
            baoHanhDto.MaKH = baoHanh.MaKH;
            baoHanhDto.MaSP = baoHanh.MaSP;
            baoHanhDto.Serial = baoHanh.SanPham.Serial;
            baoHanhDto.TenKhachHang = baoHanh.KhachHang.TenKH;
            baoHanhDto.NgayKichHoatBH = baoHanh.NgayKichHoatBH.Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            baoHanhDto.NgayKetThucBH = baoHanh.NgayKetThucBH.Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            return baoHanhDto;
        }

        public List<BaoHanhDto> GetListBaoHanhDto(List<BaoHanh> baoHanhs)
        {
            List<BaoHanhDto> baoHanhDtos = new List<BaoHanhDto>();
            foreach(BaoHanh bh in baoHanhs)
            {
                baoHanhDtos.Add(GetBaoHanhDto(bh));
            }
            return baoHanhDtos;
        }
    }
}
