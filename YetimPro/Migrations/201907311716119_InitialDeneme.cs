namespace YetimPro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDeneme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "HaberId", c => c.Int());
            CreateIndex("dbo.Comments", "HaberId");
            AddForeignKey("dbo.Comments", "HaberId", "dbo.Habers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "HaberId", "dbo.Habers");
            DropIndex("dbo.Comments", new[] { "HaberId" });
            DropColumn("dbo.Comments", "HaberId");
        }
    }
}
