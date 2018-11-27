namespace ComputerStore.Manager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixHoaDonTableDataTypeDateTime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.HoaDon", "NgayLap", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.HoaDon", "NgayLap", c => c.DateTime(storeType: "date"));
        }
    }
}
