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
    public class NhaPhanPhoiDto
    {
        [DataMember(Name = "manpp", Order = 0)]
        [DisplayName("Ma NPP")]
        public string MaNPP { get; set; }

        [DataMember(Name = "tennpp", Order = 1)]
        [DisplayName("Ten NPP")]
        public string TenNPP { get; set; }

        [DataMember(Name = "diachi", Order = 2)]
        [DisplayName("Dia chi")]
        public string DiaChi { get; set; }

        [DataMember(Name = "sdt", Order = 3)]
        [DisplayName("SDT")]
        public string SDT { get; set; }

        [DataMember(Name = "slmathang", Order = 4)]
        [DisplayName("So luong MH")]
        public int SlMatHang { get; set; }
    }
}
