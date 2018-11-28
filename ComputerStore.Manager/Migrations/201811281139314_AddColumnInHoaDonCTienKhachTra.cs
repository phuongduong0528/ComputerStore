namespace ComputerStore.Manager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnInHoaDonCTienKhachTra : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HoaDon", "TienKhachTra", c => c.Long());
        }
        
        public override void Down()
        {
            DropColumn("dbo.HoaDon", "TienKhachTra");
        }
    }
}
