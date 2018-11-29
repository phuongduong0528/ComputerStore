using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Services.Dto
{
    [DataContract]
    public class NhanVienDto
    {
        [DataMember(Name = "manv", Order = 0)]
        [DisplayName("Ma NV")]
        public string MaNV { get; set; }

        [DataMember(Name = "tennv", Order = 1)]
        [DisplayName("Ten NV")]
        public string TenNV { get; set; }

        [DataMember(Name = "ngaysinh", Order = 2)]
        [DisplayName("Ngay sinh")]
        public string NgaySinh { get; set; }

        [DataMember(Name = "diachi", Order = 3)]
        [DisplayName("Dia chi")]
        public string DiaChi { get; set; }

        [DataMember(Name = "Email", Order = 4)]
        public string Email { get; set; }

        [DataMember(Name = "sdt", Order = 5)]
        [DisplayName("SĐT")]
        public string SDT { get; set; }

        [DataMember(Name = "matkhau", Order = 6)]
        [DisplayName("Mật khẩu")]
        public string MatKhau { get; set; }

        [DataMember(Name = "quyenhan", Order = 7)]
        [DisplayName("Quyền hạn")]
        public string QuyenHan { get; set; }

        [DataMember(Name = "khoataikhoan", Order = 8)]
        [DisplayName("Khóa tài khoản")]
        public int KhoaTaiKhoan { get; set; }
    }
}
