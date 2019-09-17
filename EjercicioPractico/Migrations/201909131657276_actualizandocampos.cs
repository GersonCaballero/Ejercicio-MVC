namespace EjercicioPractico.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class actualizandocampos : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Alquilers", "coche_Id", "dbo.Coches");
            DropForeignKey("dbo.Alquilers", "user_Id", "dbo.Users");
            DropIndex("dbo.Alquilers", new[] { "coche_Id" });
            DropIndex("dbo.Alquilers", new[] { "user_Id" });
            AddColumn("dbo.Alquilers", "coche", c => c.String());
            AddColumn("dbo.Alquilers", "user", c => c.String());
            DropColumn("dbo.Alquilers", "coche_Id");
            DropColumn("dbo.Alquilers", "user_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Alquilers", "user_Id", c => c.Int());
            AddColumn("dbo.Alquilers", "coche_Id", c => c.Int());
            DropColumn("dbo.Alquilers", "user");
            DropColumn("dbo.Alquilers", "coche");
            CreateIndex("dbo.Alquilers", "user_Id");
            CreateIndex("dbo.Alquilers", "coche_Id");
            AddForeignKey("dbo.Alquilers", "user_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Alquilers", "coche_Id", "dbo.Coches", "Id");
        }
    }
}
