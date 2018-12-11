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
    public class SanPhamAdaptor
    {
        public SanPhamDto GetSanPhamDto(SanPham sanPham)
        {
            SanPhamDto sanPhamDto = new SanPhamDto();
            sanPhamDto.MaSP = sanPham.MaSP;
            sanPhamDto.Serial = sanPham.Serial;
            sanPhamDto.TenMH = sanPham.MatHang.TenMatHang;
            sanPhamDto.DonViTinh = sanPham.DonViTinh;
            sanPhamDto.NgayNhap = sanPham.NgayNhap.Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            if (sanPham.NgayXuat.Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture).Equals("01/01/1900"))
            {
                sanPhamDto.NgayXuat = "";
            }
            else
            {
                sanPhamDto.NgayXuat = sanPham.NgayXuat.Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            sanPhamDto.TinhTrang = sanPham.TinhTrang;
            return sanPhamDto;
        }

        public List<SanPhamDto> GetListSanPhamDto(List<SanPham> sanPhams)
        {
            List<SanPhamDto> sanPhamDtos = new List<SanPhamDto>();
            foreach(SanPham sp in sanPhams)
            {
                sanPhamDtos.Add(GetSanPhamDto(sp));
            }
            return sanPhamDtos;
        }

        public SanPham ToSanPhamEntity(SanPhamDto sanPhamDto)
        {
            SanPham sanPham = new SanPham();
            sanPham.MaSP = sanPhamDto.MaSP;
            sanPham.Serial = sanPhamDto.Serial;
            using(ComputerStoreEntities c = new ComputerStoreEntities())
            {
                sanPham.MaMH = c.MatHangs.FirstOrDefault(mh => mh.TenMatHang.Equals(sanPhamDto.TenMH)).MaMH;
            }
            sanPham.DonViTinh = sanPhamDto.DonViTinh;
            sanPham.NgayNhap = DateTime.ParseExact(sanPhamDto.NgayNhap, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            sanPham.NgayXuat = DateTime.ParseExact(sanPhamDto.NgayXuat, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            sanPham.TinhTrang = sanPhamDto.TinhTrang;
            return sanPham;
        }
    }
}
