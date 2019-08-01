namespace YetimPro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Deneme111 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Habers", "Sayfa", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Habers", "Sayfa");
        }
    }
}
