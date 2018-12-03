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
    public class HoaDonDto
    {
        [DataMember(Name = "mahd", Order = 0)]
        [DisplayName("Mã hóa đơn")]
        public string MaHD { get; set; }

        [DataMember(Name = "tennv", Order = 1)]
        [DisplayName("Tên NV")]
        public string TenNV { get; set; }

        [DataMember(Name = "tenkh", Order = 2)]
        [DisplayName("Tên KH")]
        public string TenKH { get; set; }

        [DataMember(Name = "ngaylap", Order = 3)]
        [DisplayName("Ngày lập")]
        public string NgayLap { get; set; }

        [DataMember(Name = "thanhtien", Order = 4)]
        [DisplayName("Thành tiền")]
        public long ThanhTien { get; set; }

        [DataMember(Name = "tienkhachtra", Order = 5)]
        [DisplayName("Tiền khách trả")]
        public long TienKhachtra { get; set; }

        [DataMember(Name = "manv", Order = 5)]
        [DisplayName("Mã NV")]
        public string MaNV { get; set; }

        [DataMember(Name = "makh", Order = 6)]
        [DisplayName("Mã KH")]
        public string MaKH { get; set; }
    }
}
