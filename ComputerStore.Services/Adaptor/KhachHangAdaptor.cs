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
    public class KhachHangAdaptor
    {
        public KhachHangDto GetKhachHangDto(KhachHang khachHang)
        {
            KhachHangDto khachHangDto = new KhachHangDto();
            khachHangDto.MaKH = khachHang.MaKH;
            khachHangDto.TenKH = $"{khachHang.HoDemKH} {khachHang.TenKH}";
            khachHangDto.NgaySinh = khachHang.NgaySinh.Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            khachHangDto.DiaChi = khachHang.DiaChi;
            khachHangDto.Email = khachHang.Email;
            khachHangDto.Sdt = khachHang.SDT;
            return khachHangDto;
        }

        public List<KhachHangDto> GetListKhachHangDto(List<KhachHang> khachHangs)
        {
            List<KhachHangDto> khacHangDtos = new List<KhachHangDto>();
            foreach(KhachHang kh in khachHangs)
            {
                khacHangDtos.Add(GetKhachHangDto(kh));
            }
            return khacHangDtos;
        }

        public KhachHang ToKhachHangEntity(KhachHangDto khachHangDto)
        {
            string[] name = khachHangDto.TenKH.Split(' ');
            string hodem = "";
            foreach(string a in name.Take(name.Length - 1))
            {
                hodem += a + " ";
            }
            string ten = name.Last();
            KhachHang x = new KhachHang();
            x.MaKH = khachHangDto.MaKH;
            x.HoDemKH = hodem;
            x.TenKH = ten;
            x.NgaySinh = DateTime.ParseExact(khachHangDto.NgaySinh, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            x.DiaChi = khachHangDto.DiaChi;
            x.Email = khachHangDto.Email;
            x.SDT = khachHangDto.Sdt;
            return x;
        }
    }
}
