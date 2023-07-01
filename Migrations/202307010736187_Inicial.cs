namespace Arthes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Receitas",
                c => new
                    {
                        ReceitaId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Altura = c.Int(nullable: false),
                        Dificuldade = c.Int(nullable: false),
                        RevistaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReceitaId)
                .ForeignKey("dbo.Revistas", t => t.RevistaId, cascadeDelete: true)
                .Index(t => t.RevistaId);
            
            CreateTable(
                "dbo.Revistas",
                c => new
                    {
                        RevistaId = c.Int(nullable: false, identity: true),
                        Tema = c.String(),
                        NumEdicao = c.Int(nullable: false),
                        MesEdicao = c.Int(nullable: false),
                        AnoEdicao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RevistaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Receitas", "RevistaId", "dbo.Revistas");
            DropIndex("dbo.Receitas", new[] { "RevistaId" });
            DropTable("dbo.Revistas");
            DropTable("dbo.Receitas");
        }
    }
}
