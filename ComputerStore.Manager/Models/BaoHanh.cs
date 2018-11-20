namespace ComputerStore.Manager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaoHanh")]
    public partial class BaoHanh
    {
        [Key]
        [StringLength(10)]
        public string MaBH { get; set; }

        [Required]
        [StringLength(10)]
        public string MaSP { get; set; }

        [Required]
        [StringLength(10)]
        public string MaKH { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKichHoatBH { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKetThucBH { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
