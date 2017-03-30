namespace CrystalReport1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ADDsDepartamento : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Productos", "sDepartamento", c => c.String(nullable: false, maxLength: 40, storeType: "nvarchar"));
            DropColumn("dbo.Productos", "sClacificacion");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Productos", "sClacificacion", c => c.String(nullable: false, maxLength: 40, storeType: "nvarchar"));
            DropColumn("dbo.Productos", "sDepartamento");
        }
    }
}
