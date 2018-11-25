namespace ComputerStore.Manager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixMatHangTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.MatHang", "SoLuong");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MatHang", "SoLuong", c => c.Int());
        }
    }
}
