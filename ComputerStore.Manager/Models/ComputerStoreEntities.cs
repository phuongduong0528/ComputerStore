namespace ComputerStore.Manager.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ComputerStoreEntities : DbContext
    {
        public ComputerStoreEntities()
            : base("name=ComputerStoreEntities")
        {
        }

        public virtual DbSet<BaoHanh> BaoHanhs { get; set; }
        public virtual DbSet<HangSanXuat> HangSanXuats { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiHang> LoaiHangs { get; set; }
        public virtual DbSet<MatHang> MatHangs { get; set; }
        public virtual DbSet<MatHangDuocBan> MatHangDuocBans { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<NhaPhanPhoi> NhaPhanPhois { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaoHanh>()
                .Property(e => e.MaBH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BaoHanh>()
                .Property(e => e.MaSP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BaoHanh>()
                .Property(e => e.MaKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HangSanXuat>()
                .Property(e => e.MaHSX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HangSanXuat>()
                .HasMany(e => e.MatHangs)
                .WithRequired(e => e.HangSanXuat)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaNV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.MatHangDuocBans)
                .WithRequired(e => e.HoaDon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.BaoHanhs)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiHang>()
                .Property(e => e.MaLH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LoaiHang>()
                .HasMany(e => e.MatHangs)
                .WithRequired(e => e.LoaiHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MatHang>()
                .Property(e => e.MaMH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MatHang>()
                .Property(e => e.MaLH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MatHang>()
                .Property(e => e.MaHSX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MatHang>()
                .Property(e => e.MaNPP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MatHang>()
                .HasMany(e => e.SanPhams)
                .WithRequired(e => e.MatHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MatHangDuocBan>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MatHangDuocBan>()
                .Property(e => e.MaHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MatHangDuocBan>()
                .Property(e => e.MaSP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MatKhau)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhaPhanPhoi>()
                .Property(e => e.MaNPP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhaPhanPhoi>()
                .HasMany(e => e.MatHangs)
                .WithRequired(e => e.NhaPhanPhoi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MaSP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MaMH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.BaoHanhs)
                .WithRequired(e => e.SanPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.MatHangDuocBans)
                .WithRequired(e => e.SanPham)
                .WillCascadeOnDelete(false);
        }
    }
}
