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
        [DisplayName("Ma KH")]
        public string MaKH { get; set; }

        [DataMember(Name = "tenkh", Order = 1)]
        [DisplayName("Ten KH")]
        public string TenKH { get; set; }

        [DataMember(Name = "ngaysinh", Order = 2)]
        [DisplayName("Ngay Sinh")]
        public string NgaySinh { get; set; }

        [DataMember(Name = "diachi", Order = 3)]
        [DisplayName("Dia Chi")]
        public string DiaChi { get; set; }

        [DataMember(Name = "email", Order = 4)]
        [DisplayName("Email")]
        public string Email { get; set; }

        [DataMember(Name = "sdt", Order = 5)]
        [DisplayName("SDT")]
        public string Sdt { get; set; }
    }
}
