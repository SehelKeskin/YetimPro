namespace YetimPro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dd : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Comments", "Mail");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Comments", "Mail", c => c.String());
        }
    }
}
