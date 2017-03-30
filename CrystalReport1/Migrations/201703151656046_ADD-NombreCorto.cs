namespace CrystalReport1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ADDNombreCorto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Productos", "sNombreCorto", c => c.String(nullable: false, maxLength: 50, storeType: "nvarchar"));
            DropColumn("dbo.Productos", "sNombreCosto");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Productos", "sNombreCosto", c => c.String(nullable: false, maxLength: 50, storeType: "nvarchar"));
            DropColumn("dbo.Productos", "sNombreCorto");
        }
    }
}
