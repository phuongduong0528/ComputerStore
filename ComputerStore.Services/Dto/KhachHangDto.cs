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
    public class KhachHangDto
    {
        [DataMember(Name = "makh", Order = 0)]
        [DisplayName("Mã KH")]
        public string MaKH { get; set; }

        [DataMember(Name = "tenkh", Order = 1)]
        [DisplayName("Tên khách hàng")]
        public string TenKH { get; set; }

        [DataMember(Name = "ngaysinh", Order = 2)]
        [DisplayName("Ngày sinh")]
        public string NgaySinh { get; set; }

        [DataMember(Name = "diachi", Order = 3)]
        [DisplayName("Địa chỉ")]
        public string DiaChi { get; set; }

        [DataMember(Name = "email", Order = 4)]
        [DisplayName("Email")]
        public string Email { get; set; }

        [DataMember(Name = "sdt", Order = 5)]
        [DisplayName("SĐT")]
        public string Sdt { get; set; }
    }
}
