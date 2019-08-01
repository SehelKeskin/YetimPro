namespace YetimPro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstVersion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BagisSinifs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tur = c.Int(nullable: false),
                        Ad = c.String(nullable: false, maxLength: 50),
                        Soyad = c.String(nullable: false, maxLength: 50),
                        Mail = c.String(nullable: false, maxLength: 50),
                        Tel = c.String(),
                        Mesaj = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.İletisim",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false, maxLength: 50),
                        Soyad = c.String(nullable: false, maxLength: 50),
                        Tel = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Mesaj = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.İletisim");
            DropTable("dbo.BagisSinifs");
        }
    }
}
