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
    class NhanVienAdaptor
    {
        public NhanVienDto GetNhanVienDto(NhanVien nhanVien)
        {
            NhanVienDto x = new NhanVienDto();
            x.MaNV = nhanVien.MaNV;
            x.TenNV = $"{nhanVien.HoDem} {nhanVien.Ten}";
            x.NgaySinh = nhanVien.NgaySinh.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            x.DiaChi = nhanVien.DiaChi;
            x.Email = nhanVien.Email;
            x.SDT = nhanVien.SDT;
            x.MatKhau = nhanVien.MatKhau;
            x.QuyenHan = nhanVien.QuyenHan;
            x.KhoaTaiKhoan = nhanVien.KhoaTK;
            return x;
        }

        public List<NhanVienDto> GetListNhanVienDto(List<NhanVien> nhanViens)
        {
            List<NhanVienDto> nhanVienDtos = new List<NhanVienDto>();
            foreach(NhanVien nv in nhanViens)
            {
                nhanVienDtos.Add(GetNhanVienDto(nv));
            }
            return nhanVienDtos;
        }

        public NhanVien ToNhanVienEntity(NhanVienDto nhanVienDto)
        {
            NhanVien nhanVien = new NhanVien();
            string[] name = nhanVienDto.TenNV.Split(' ');
            string hodem = "";
            foreach (string a in name.Take(name.Length - 1))
            {
                hodem += a + " ";
            }
            string ten = name.Last();

            nhanVien.MaNV = nhanVienDto.MaNV;
            nhanVien.HoDem = hodem;
            nhanVien.Ten = ten;
            nhanVien.NgaySinh = DateTime.ParseExact(nhanVienDto.NgaySinh, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            nhanVien.DiaChi = nhanVienDto.DiaChi;
            nhanVien.Email = nhanVienDto.Email;
            nhanVien.SDT = nhanVienDto.SDT;
            nhanVien.QuyenHan = nhanVienDto.QuyenHan;
            nhanVien.MatKhau = nhanVienDto.MatKhau;
            nhanVien.KhoaTK = nhanVienDto.KhoaTaiKhoan;
            return nhanVien;
        }
    }
}
