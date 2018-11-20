namespace ComputerStore.Manager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixNhanVienTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NhanVien", "HoDem", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.NhanVien", "Ten", c => c.String(nullable: false, maxLength: 20));
            DropColumn("dbo.NhanVien", "HoTen");
            DropColumn("dbo.NhanVien", "TenDangNhap");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NhanVien", "TenDangNhap", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.NhanVien", "HoTen", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.NhanVien", "Ten");
            DropColumn("dbo.NhanVien", "HoDem");
        }
    }
}
