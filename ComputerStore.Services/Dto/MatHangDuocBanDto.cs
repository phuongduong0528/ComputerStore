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
    public class MatHangDuocBanDto
    {
        [DataMember(Name = "id", Order = 0)]
        [DisplayName("ID")]
        public string ID { get; set; }

        [DataMember(Name = "tensp", Order = 1)]
        [DisplayName("Tên sp")]
        public string TenSP { get; set; }

        [DataMember(Name = "serial", Order = 2)]
        [DisplayName("Serial")]
        public string Serial { get; set; }

        [DataMember(Name = "khuyenmai", Order = 3)]
        [DisplayName("Khuyến mại")]
        public int KhuyenMai { get; set; }

        [DataMember(Name = "gia", Order = 4)]
        [DisplayName("Giá")]
        public long Gia { get; set; }

        [DataMember(Name = "mahd", Order = 5)]
        [DisplayName("Mã HD")]
        public string MaHD { get; set; }

        [DataMember(Name = "masp", Order = 6)]
        [DisplayName("Mã SP")]
        public string MaSP { get; set; }

        [DataMember(Name = "mamh", Order = 7)]
        [DisplayName("Mã MH")]
        public string MaMH { get; set; }
    }
}
