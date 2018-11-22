using System;
using System.Collections.Generic;
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
        public string MaHD { get; set; }

        [DataMember(Name = "tennv", Order = 1)]
        public string TenNV { get; set; }

        [DataMember(Name = "tenkh", Order = 2)]
        public string TenKH { get; set; }

        [DataMember(Name = "ngaylap", Order = 3)]
        public string NgayLap { get; set; }

        [DataMember(Name = "thanhtien", Order = 4)]
        public long ThanhTien { get; set; }

        [DataMember(Name = "manv", Order = 5)]
        public string MaNV { get; set; }

        [DataMember(Name = "makh", Order = 6)]
        public string MaKH { get; set; }
    }
}
