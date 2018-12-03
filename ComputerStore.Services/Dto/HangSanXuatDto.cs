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
    public class HangSanXuatDto
    {
        [DataMember(Name = "mahsx", Order = 0)]
        [DisplayName("Mã HSX")]
        public string MaHSX { get; set; }

        [DataMember(Name = "tenhsx", Order = 1)]
        [DisplayName("Tên HSX")]
        public string TenHSX { get; set; }
    }
}
