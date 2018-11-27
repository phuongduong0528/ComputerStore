namespace ComputerStore.Manager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            MatHangDuocBans = new HashSet<MatHangDuocBan>();
        }

        [Key]
        [StringLength(10)]
        public string MaHD { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNV { get; set; }

        [Required]
        [StringLength(10)]
        public string MaKH { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? NgayLap { get; set; }

        public long? ThanhTien { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MatHangDuocBan> MatHangDuocBans { get; set; }
    }
}
