namespace ComputerStore.Manager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixMatHangDuocBan_2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.MatHangDuocBan", "SoLuong");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MatHangDuocBan", "SoLuong", c => c.Int());
        }
    }
}
