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
    public class LoaiHangDto
    {
        [DataMember(Name = "malh", Order = 0)]
        [DisplayName("Mã LH")]
        public string MaLH { get; set; }

        [DataMember(Name = "tenlh", Order = 1)]
        [DisplayName("Tên LH")]
        public string TenLH { get; set; }
    }
}
