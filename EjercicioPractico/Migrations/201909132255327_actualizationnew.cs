namespace EjercicioPractico.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class actualizationnew : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Alquilers", "IdUser", c => c.Int(nullable: false));
            AddColumn("dbo.Alquilers", "IdCoche", c => c.Int(nullable: false));
            DropColumn("dbo.Alquilers", "Marca");
            DropColumn("dbo.Alquilers", "Modelo");
            DropColumn("dbo.Alquilers", "Color");
            DropColumn("dbo.Alquilers", "Name");
            DropColumn("dbo.Alquilers", "Cedula");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Alquilers", "Cedula", c => c.String());
            AddColumn("dbo.Alquilers", "Name", c => c.String());
            AddColumn("dbo.Alquilers", "Color", c => c.String());
            AddColumn("dbo.Alquilers", "Modelo", c => c.String());
            AddColumn("dbo.Alquilers", "Marca", c => c.String());
            DropColumn("dbo.Alquilers", "IdCoche");
            DropColumn("dbo.Alquilers", "IdUser");
        }
    }
}
