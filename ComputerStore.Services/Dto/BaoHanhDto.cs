using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Services.Dto
{
    [DataContract]
    public class BaoHanhDto
    {
        [DataMember(Name = "mabh", Order = 0)]
        public string MaBH { get; set; }

        [DataMember(Name = "makh", Order = 6)]
        public string MaKH { get; set; }

        [DataMember(Name = "masp", Order = 1)]
        public string MaSP { get; set; }

        [DataMember(Name = "serial", Order = 2)]
        public string Serial { get; set; }

        [DataMember(Name = "tenkhachhang", Order = 3)]
        public string TenKhachHang { get; set; }

        [DataMember(Name = "ngaykichhoatbh", Order = 4)]
        public string NgayKichHoatBH { get; set; }

        [DataMember(Name = "ngayketthucbaohanh", Order = 5)]
        public string NgayKetThucBH { get; set; }
    }
}
