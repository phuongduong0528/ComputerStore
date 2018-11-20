namespace ComputerStore.Manager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewPropertiesNhanVienTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NhanVien", "QuyenHan", c => c.String(nullable: false, maxLength: 10));
            AddColumn("dbo.NhanVien", "KhoaTK", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NhanVien", "KhoaTK");
            DropColumn("dbo.NhanVien", "QuyenHan");
        }
    }
}
