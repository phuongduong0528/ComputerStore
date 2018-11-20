namespace ComputerStore.Manager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixNhaPhanPhoi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NhaPhanPhoi", "SDT", c => c.String(maxLength: 15));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NhaPhanPhoi", "SDT");
        }
    }
}
