namespace ComputerStore.Manager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixKhachHangTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.KhachHang", "HoDemKH", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.KhachHang", "TenKH", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.KhachHang", "TenKH", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.KhachHang", "HoDemKH");
        }
    }
}
