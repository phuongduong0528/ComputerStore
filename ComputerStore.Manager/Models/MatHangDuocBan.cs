namespace ComputerStore.Manager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MatHangDuocBan")]
    public partial class MatHangDuocBan
    {
        [StringLength(10)]
        public string ID { get; set; }

        [Required]
        [StringLength(10)]
        public string MaHD { get; set; }

        [Required]
        [StringLength(10)]
        public string MaSP { get; set; }
        
        public int? KhuyenMai { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
