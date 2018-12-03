using ComputerStore.Services.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.FormApplication.Controller
{
    public class DtoSerializer
    {
        public static string SerializeKhachHangDto(KhachHangDto khachHangDto)
        {
            object o = new
            {
                makh = khachHangDto.MaKH,
                tenkh = khachHangDto.TenKH,
                ngaysinh = khachHangDto.NgaySinh,
                diachi = khachHangDto.DiaChi,
                email = khachHangDto.Email,
                sdt = khachHangDto.Sdt
            };
            return JsonConvert.SerializeObject(o);
        }

        public static string SerializeNhanVienDto(NhanVienDto nhanvienDto)
        {
            object o = new
            {
                manv = nhanvienDto.MaNV,
                tennv = nhanvienDto.TenNV,
                ngaysinh = nhanvienDto.NgaySinh,
                diachi = nhanvienDto.DiaChi,
                email = nhanvienDto.Email,
                sdt = nhanvienDto.SDT,
                matkhau = nhanvienDto.MatKhau,
                quyenhan = nhanvienDto.QuyenHan,
                khoataikhoan = nhanvienDto.KhoaTaiKhoan
            };
            return JsonConvert.SerializeObject(o);
        }

        public static string SerializeLoaiHangDto(LoaiHangDto loaiHangDto)
        {
            object o = new
            {
                malh = loaiHangDto.MaLH,
                tenlh = loaiHangDto.TenLH
            };
            return JsonConvert.SerializeObject(o);
        }

        public static string SerializeMatHangDto(MatHangDto matHangDto)
        {
            object o = new
            {
                mamh = matHangDto.MaMH,
                hangsanxuat = matHangDto.HangSanXuat,
                tenmathang = matHangDto.TenMatHang,
                loaihang = matHangDto.LoaiHang,
                nhaphanphoi = matHangDto.NhaPhanPhoi,
                soluong = matHangDto.SoLuong,
                gianiemyet = matHangDto.GiaNiemYet,
            };
            return JsonConvert.SerializeObject(o);
        }

        public static string SerializeNhaPhanPhoiDto(NhaPhanPhoiDto nhaPhanPhoiDto)
        {
            object o = new
            {
                manpp = nhaPhanPhoiDto.MaNPP,
                tennpp = nhaPhanPhoiDto.TenNPP,
                diachi = nhaPhanPhoiDto.DiaChi,
                sdt = nhaPhanPhoiDto.SDT,
                slmathang = nhaPhanPhoiDto.SlMatHang
            };
            return JsonConvert.SerializeObject(o);
        }

        public static string SerializeSanPhamDto(SanPhamDto sanPhamDto)
        {
            object o = new
            {
                masp = sanPhamDto.MaSP,
                serial = sanPhamDto.Serial,
                tenmh = sanPhamDto.TenMH,
                donvitinh = sanPhamDto.DonViTinh,
                ngaynhap = sanPhamDto.NgayNhap,
                ngayxuat = sanPhamDto.NgayXuat,
                tinhtrang = sanPhamDto.TinhTrang
            };
            return JsonConvert.SerializeObject(o);
        }

        public static string SerializeMHDBDto(MatHangDuocBanDto matHangDuocBanDto)
        {
            object o = new
            {
                id = matHangDuocBanDto.ID,
                tensp = matHangDuocBanDto.TenSP,
                serial = matHangDuocBanDto.Serial,
                khuyenmai = matHangDuocBanDto.KhuyenMai,
                gia = matHangDuocBanDto.KhuyenMai,
                mahd = matHangDuocBanDto.MaHD,
                masp = matHangDuocBanDto.MaSP,
                mamh = matHangDuocBanDto.MaMH
            };
            return JsonConvert.SerializeObject(o);
        }
    }
}
