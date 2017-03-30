namespace CrystalReport1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class INICIAL : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Productos",
                c => new
                    {
                        pkProducto = c.Int(nullable: false, identity: true),
                        sNombreCosto = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        sDescripcion = c.String(nullable: false, maxLength: 150, storeType: "nvarchar"),
                        sClacificacion = c.String(nullable: false, maxLength: 40, storeType: "nvarchar"),
                        dPrecio = c.Double(nullable: false),
                        dCosto = c.Double(nullable: false),
                        bStock = c.Int(nullable: false),
                        bStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.pkProducto);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Productos");
        }
    }
}
