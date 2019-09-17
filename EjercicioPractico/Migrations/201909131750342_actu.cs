namespace EjercicioPractico.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class actu : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Alquilers", "Marca", c => c.String());
            AddColumn("dbo.Alquilers", "Modelo", c => c.String());
            AddColumn("dbo.Alquilers", "Color", c => c.String());
            AddColumn("dbo.Alquilers", "Name", c => c.String());
            AddColumn("dbo.Alquilers", "Cedula", c => c.String());
            DropColumn("dbo.Alquilers", "coche");
            DropColumn("dbo.Alquilers", "user");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Alquilers", "user", c => c.String());
            AddColumn("dbo.Alquilers", "coche", c => c.String());
            DropColumn("dbo.Alquilers", "Cedula");
            DropColumn("dbo.Alquilers", "Name");
            DropColumn("dbo.Alquilers", "Color");
            DropColumn("dbo.Alquilers", "Modelo");
            DropColumn("dbo.Alquilers", "Marca");
        }
    }
}
