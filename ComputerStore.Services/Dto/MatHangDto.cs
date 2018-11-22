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
    public class MatHangDto
    {
        [DataMember(Name = "mamh", Order = 0)]
        [DisplayName("Ma MH")]
        public string MaMH { get; set; }

        [DataMember(Name = "loaihang", Order = 1)]
        [DisplayName("Loai hang")]
        public string LoaiHang { get; set; }

        [DataMember(Name = "hangsanxuat", Order = 2)]
        [DisplayName("Hang sx")]
        public string HangSanXuat { get; set; }

        [DataMember(Name = "nhaphanphoi", Order = 3)]
        [DisplayName("Nha phan phoi")]
        public string NhaPhanPhoi { get; set; }

        [DataMember(Name = "tenmathang", Order = 4)]
        [DisplayName("Ten")]
        public string TenMatHang { get; set; }

        [DataMember(Name = "soluong", Order = 5)]
        [DisplayName("So luong")]
        public int SoLuong { get; set; }

        [DataMember(Name = "gianiemyet", Order = 6)]
        [DisplayName("Gia")]
        public long GiaNiemYet { get; set; }

    }
}
