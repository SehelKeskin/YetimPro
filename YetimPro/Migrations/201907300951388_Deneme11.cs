namespace YetimPro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Deneme11 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Habers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tarih = c.DateTime(nullable: false),
                        Foto = c.String(),
                        Ad = c.String(),
                        Baslik = c.String(),
                        Gövde = c.String(),
                    })
                .PrimaryKey(t => t.Id);   
        }
        public override void Down()
        {
            DropTable("dbo.Habers");
        }
    }
}
