using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Services.Dto
{
    [DataContract]
    public class SanPhamDto
    {
        [DataMember(Name = "masp", Order = 0)]
        public string MaSP { get; set; }

        [DataMember(Name = "serial", Order = 1)]
        public string Serial { get; set; }

        [DataMember(Name = "tenmh", Order = 2)]
        public string TenMH { get; set; }

        [DataMember(Name = "donvitinh", Order = 3)]
        public string DonViTinh { get; set; }

        [DataMember(Name = "ngaynhap", Order = 4)]
        public string NgayNhap { get; set; }

        [DataMember(Name = "ngayxuat", Order = 5)]
        public string NgayXuat { get; set; }

        [DataMember(Name = "tinhtrang", Order = 6)]
        public string TinhTrang { get; set; }
    }
}
