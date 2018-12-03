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
    public class SanPhamDto
    {
        [DataMember(Name = "masp", Order = 0)]
        [DisplayName("Mã SP")]
        public string MaSP { get; set; }

        [DataMember(Name = "serial", Order = 1)]
        [DisplayName("Serial")]
        public string Serial { get; set; }

        [DataMember(Name = "tenmh", Order = 2)]
        [DisplayName("Tên MH")]
        public string TenMH { get; set; }

        [DataMember(Name = "donvitinh", Order = 3)]
        [DisplayName("Đơn vị tính")]
        public string DonViTinh { get; set; }

        [DataMember(Name = "ngaynhap", Order = 4)]
        [DisplayName("Ngày nhập")]
        public string NgayNhap { get; set; }

        [DataMember(Name = "ngayxuat", Order = 5)]
        [DisplayName("Ngày xuất")]
        public string NgayXuat { get; set; }

        [DataMember(Name = "tinhtrang", Order = 6)]
        [DisplayName("Tình trạng")]
        public string TinhTrang { get; set; }
    }
}
