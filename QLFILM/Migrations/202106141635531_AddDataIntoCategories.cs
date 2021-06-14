namespace QLFILM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataIntoCategories : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Categories (CID, CategoryName) VALUES (N'C001', N'Romance');");
            Sql("INSERT INTO Categories (CID, CategoryName) VALUES (N'C002', N'Adventure');");
            Sql("INSERT INTO Categories (CID, CategoryName) VALUES (N'C003', N'Mystery');");
            Sql("INSERT INTO Categories (CID, CategoryName) VALUES (N'C004', N'Drama');");
            Sql("INSERT INTO Categories (CID, CategoryName) VALUES (N'C005', N'Horror');");
            Sql("INSERT INTO Categories (CID, CategoryName) VALUES (N'C006', N'Sport');");
            Sql("INSERT INTO Categories (CID, CategoryName) VALUES (N'C007', N'Comedy');");
            Sql("INSERT INTO Categories (CID, CategoryName) VALUES (N'C008', N'War');");
            Sql("INSERT INTO Categories (CID, CategoryName) VALUES (N'C009', N'History');");
            Sql("INSERT INTO Categories (CID, CategoryName) VALUES (N'C010', N'Crime');");
            Sql("INSERT INTO Categories (CID, CategoryName) VALUES (N'C011', N'Fantasy');");
            Sql("INSERT INTO Categories (CID, CategoryName) VALUES (N'C012', N'Sci-Fi');");
            Sql("INSERT INTO Categories (CID, CategoryName) VALUES (N'C013', N'Musical');");
            Sql("INSERT INTO Categories (CID, CategoryName) VALUES (N'C014', N'Music');");
            Sql("INSERT INTO Categories (CID, CategoryName) VALUES (N'C015', N'Family');");
            Sql("INSERT INTO Categories (CID, CategoryName) VALUES (N'C016', N'Thriller');");
            Sql("INSERT INTO Categories (CID, CategoryName) VALUES (N'C017', N'Action');");
        }
        
        public override void Down()
        {
        }
    }
}
