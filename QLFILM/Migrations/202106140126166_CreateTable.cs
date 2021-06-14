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
                "dbo.FilmActors",
                c => new
                    {
                        Film_FID = c.String(nullable: false, maxLength: 128),
                        Actor_AID = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Film_FID, t.Actor_AID })
                .ForeignKey("dbo.Films", t => t.Film_FID, cascadeDelete: true)
                .ForeignKey("dbo.Actors", t => t.Actor_AID, cascadeDelete: true)
                .Index(t => t.Film_FID)
                .Index(t => t.Actor_AID);
            
            CreateTable(
                "dbo.CategoryFilms",
                c => new
                    {
                        Category_CID = c.String(nullable: false, maxLength: 128),
                        Film_FID = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Category_CID, t.Film_FID })
                .ForeignKey("dbo.Categories", t => t.Category_CID, cascadeDelete: true)
                .ForeignKey("dbo.Films", t => t.Film_FID, cascadeDelete: true)
                .Index(t => t.Category_CID)
                .Index(t => t.Film_FID);
            
            CreateTable(
                "dbo.DirectorFilms",
                c => new
                    {
                        Director_DID = c.String(nullable: false, maxLength: 128),
                        Film_FID = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Director_DID, t.Film_FID })
                .ForeignKey("dbo.Directors", t => t.Director_DID, cascadeDelete: true)
                .ForeignKey("dbo.Films", t => t.Film_FID, cascadeDelete: true)
                .Index(t => t.Director_DID)
                .Index(t => t.Film_FID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DirectorFilms", "Film_FID", "dbo.Films");
            DropForeignKey("dbo.DirectorFilms", "Director_DID", "dbo.Directors");
            DropForeignKey("dbo.CategoryFilms", "Film_FID", "dbo.Films");
            DropForeignKey("dbo.CategoryFilms", "Category_CID", "dbo.Categories");
            DropForeignKey("dbo.FilmActors", "Actor_AID", "dbo.Actors");
            DropForeignKey("dbo.FilmActors", "Film_FID", "dbo.Films");
            DropIndex("dbo.DirectorFilms", new[] { "Film_FID" });
            DropIndex("dbo.DirectorFilms", new[] { "Director_DID" });
            DropIndex("dbo.CategoryFilms", new[] { "Film_FID" });
            DropIndex("dbo.CategoryFilms", new[] { "Category_CID" });
            DropIndex("dbo.FilmActors", new[] { "Actor_AID" });
            DropIndex("dbo.FilmActors", new[] { "Film_FID" });
            DropTable("dbo.DirectorFilms");
            DropTable("dbo.CategoryFilms");
            DropTable("dbo.FilmActors");
            DropTable("dbo.Directors");
            DropTable("dbo.Categories");
            DropTable("dbo.Films");
            DropTable("dbo.Actors");
        }
    }
}
