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
        [DisplayName("Mã MH")]
        public string MaMH { get; set; }

        [DataMember(Name = "hangsanxuat", Order = 1)]
        [DisplayName("Hãng sx")]
        public string HangSanXuat { get; set; }

        [DataMember(Name = "tenmathang", Order = 2)]
        [DisplayName("Tên")]
        public string TenMatHang { get; set; }

        [DataMember(Name = "loaihang", Order = 3)]
        [DisplayName("Loại hàng")]
        public string LoaiHang { get; set; }

        [DataMember(Name = "nhaphanphoi", Order = 4)]
        [DisplayName("Nhà phân phối")]
        public string NhaPhanPhoi { get; set; }

        [DataMember(Name = "soluong", Order = 5)]
        [DisplayName("Số lượng")]
        public int SoLuong { get; set; }

        [DataMember(Name = "gianiemyet", Order = 6)]
        [DisplayName("Giá")]
        public long GiaNiemYet { get; set; }

    }
}
