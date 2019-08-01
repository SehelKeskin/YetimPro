namespace YetimPro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Bos : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Comments", "Ad", c => c.String(nullable: false));
            AlterColumn("dbo.Comments", "Mesaj", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Comments", "Mesaj", c => c.String());
            AlterColumn("dbo.Comments", "Ad", c => c.String());
        }
    }
}
