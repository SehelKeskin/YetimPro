namespace YetimPro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deneme : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.İletisim", newName: "Contacts");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Contacts", newName: "İletisim");
        }
    }
}
