namespace QLFILM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        AID = c.String(nullable: false, maxLength: 128),
                        ActorName = c.String(),
                    })
                .PrimaryKey(t => t.AID);
            
            CreateTable(
                "dbo.Films",
                c => new
                    {
                        FID = c.String(nullable: false, maxLength: 128),
                        EnglishTitle = c.String(),
                        VietnameseTitle = c.String(),
                        Year = c.Int(nullable: false),
                        Length = c.Double(),
                        Rating = c.Double(),
                        Gross = c.Double(),
                    })
                .PrimaryKey(t => t.FID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CID = c.String(nullable: false, maxLength: 128),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CID);
            
            CreateTable(
                "dbo.Directors",
                c => new
                    {
                        DID = c.String(nullable: false, maxLength: 128),
                        DirectorName = c.String(),
                    })
                .PrimaryKey(t => t.DID);
            
            CreateTable(
                "dbo.CategoryFilms",
                c => new
                    {
                        FID = c.String(nullable: false, maxLength: 128),
                        CID = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.FID, t.CID })
                .ForeignKey("dbo.Categories", t => t.CID, cascadeDelete: true)
                .ForeignKey("dbo.Films", t => t.FID, cascadeDelete: true)
                .Index(t => t.FID)
                .Index(t => t.CID);
            
            CreateTable(
                "dbo.DirectorFilms",
                c => new
                    {
                        FID = c.String(nullable: false, maxLength: 128),
                        DID = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.FID, t.DID })
                .ForeignKey("dbo.Directors", t => t.DID, cascadeDelete: true)
                .ForeignKey("dbo.Films", t => t.FID, cascadeDelete: true)
                .Index(t => t.FID)
                .Index(t => t.DID);
            
            CreateTable(
                "dbo.FilmActors",
                c => new
                    {
                        FID = c.String(nullable: false, maxLength: 128),
                        AID = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.FID, t.AID })
                .ForeignKey("dbo.Actors", t => t.AID, cascadeDelete: true)
                .ForeignKey("dbo.Films", t => t.FID, cascadeDelete: true)
                .Index(t => t.FID)
                .Index(t => t.AID);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FilmActors", "FID", "dbo.Films");
            DropForeignKey("dbo.FilmActors", "AID", "dbo.Actors");
            DropForeignKey("dbo.DirectorFilms", "FID", "dbo.Films");
            DropForeignKey("dbo.DirectorFilms", "DID", "dbo.Directors");
            DropForeignKey("dbo.CategoryFilms", "FID", "dbo.Films");
            DropForeignKey("dbo.CategoryFilms", "CID", "dbo.Categories");
            DropIndex("dbo.FilmActors", new[] { "AID" });
            DropIndex("dbo.FilmActors", new[] { "FID" });
            DropIndex("dbo.DirectorFilms", new[] { "DID" });
            DropIndex("dbo.DirectorFilms", new[] { "FID" });
            DropIndex("dbo.CategoryFilms", new[] { "CID" });
            DropIndex("dbo.CategoryFilms", new[] { "FID" });
            DropTable("dbo.FilmActors");
            DropTable("dbo.DirectorFilms");
            DropTable("dbo.CategoryFilms");
            DropTable("dbo.Directors");
            DropTable("dbo.Categories");
            DropTable("dbo.Films");
            DropTable("dbo.Actors");
        }
    }
}
