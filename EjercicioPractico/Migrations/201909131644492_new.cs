namespace EjercicioPractico.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alquilers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        coche_Id = c.Int(),
                        user_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Coches", t => t.coche_Id)
                .ForeignKey("dbo.Users", t => t.user_Id)
                .Index(t => t.coche_Id)
                .Index(t => t.user_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Alquilers", "user_Id", "dbo.Users");
            DropForeignKey("dbo.Alquilers", "coche_Id", "dbo.Coches");
            DropIndex("dbo.Alquilers", new[] { "user_Id" });
            DropIndex("dbo.Alquilers", new[] { "coche_Id" });
            DropTable("dbo.Alquilers");
        }
    }
}
