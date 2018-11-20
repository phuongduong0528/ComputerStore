namespace ComputerStore.Manager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MatHang")]
    public partial class MatHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MatHang()
        {
            SanPhams = new HashSet<SanPham>();
        }

        [Key]
        [StringLength(10)]
        public string MaMH { get; set; }

        [Required]
        [StringLength(10)]
        public string MaLH { get; set; }

        [Required]
        [StringLength(10)]
        public string MaHSX { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNPP { get; set; }

        [Required]
        [StringLength(50)]
        public string TenMatHang { get; set; }

        public int? SoLuong { get; set; }

        public long? GiaNiemYet { get; set; }

        public virtual HangSanXuat HangSanXuat { get; set; }

        public virtual LoaiHang LoaiHang { get; set; }

        public virtual NhaPhanPhoi NhaPhanPhoi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
