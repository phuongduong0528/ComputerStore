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
    public class HoaDonAdaptor
    {
        public HoaDonDto GetHoaDonDto(HoaDon hoaDon)
        {
            HoaDonDto hoaDonDto = new HoaDonDto();
            hoaDonDto.MaHD = hoaDon.MaHD;
            hoaDonDto.TenNV = $"{hoaDon.NhanVien.HoDem} {hoaDon.NhanVien.Ten}";
            hoaDonDto.TenKH = $"{hoaDon.KhachHang.HoDemKH} {hoaDon.KhachHang.TenKH}";
            hoaDonDto.NgayLap = hoaDon.NgayLap.Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            hoaDonDto.ThanhTien = hoaDon.ThanhTien.Value;
            return hoaDonDto;
        }

        public List<HoaDonDto> GetListHoaDonDto(List<HoaDon> hoaDons)
        {
            List<HoaDonDto> hoaDonDtos = new List<HoaDonDto>();
            foreach(HoaDon hd in hoaDons)
            {
                hoaDonDtos.Add(GetHoaDonDto(hd));
            }
            return hoaDonDtos;
        }

        public HoaDon ToHoaDonEntity(HoaDonDto hoaDonDto)
        {
            HoaDon hoaDon = new HoaDon();
            hoaDon.MaHD = hoaDonDto.MaHD;
            hoaDon.MaNV = hoaDonDto.MaNV;
            hoaDon.MaKH = hoaDonDto.MaKH;
            hoaDon.NgayLap = DateTime.ParseExact(hoaDonDto.NgayLap, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            hoaDon.ThanhTien = hoaDonDto.ThanhTien;
            return hoaDon;
        }
    }
}
