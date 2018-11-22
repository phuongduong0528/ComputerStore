using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Services.Dto
{
    [DataContract]
    public class MatHangDuocBanDto
    {
        [DataMember(Name = "id", Order = 0)]
        public string ID { get; set; }

        [DataMember(Name = "tensp", Order = 1)]
        public string TenSP { get; set; }

        [DataMember(Name = "serial", Order = 2)]
        public string Serial { get; set; }

        [DataMember(Name = "khuyenmai", Order = 3)]
        public int KhuyenMai { get; set; }

        [DataMember(Name = "gia", Order = 4)]
        public long Gia { get; set; }

        [DataMember(Name = "mahd", Order = 5)]
        public string MaHD { get; set; }

        [DataMember(Name = "masp", Order = 6)]
        public string MaSP { get; set; }
    }
}
