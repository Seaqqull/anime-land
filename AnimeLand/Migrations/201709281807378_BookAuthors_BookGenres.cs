namespace AnimeLand.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookAuthors_BookGenres : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BookAuthors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BooksId = c.Int(nullable: false),
                        AuthorsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.AuthorsId, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.BooksId, cascadeDelete: true)
                .Index(t => t.BooksId)
                .Index(t => t.AuthorsId);
            
            CreateTable(
                "dbo.BookGenres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BooksId = c.Int(nullable: false),
                        GenresId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BooksId, cascadeDelete: true)
                .ForeignKey("dbo.Genres", t => t.GenresId, cascadeDelete: true)
                .Index(t => t.BooksId)
                .Index(t => t.GenresId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BookGenres", "GenresId", "dbo.Genres");
            DropForeignKey("dbo.BookGenres", "BooksId", "dbo.Books");
            DropForeignKey("dbo.BookAuthors", "BooksId", "dbo.Books");
            DropForeignKey("dbo.BookAuthors", "AuthorsId", "dbo.Authors");
            DropIndex("dbo.BookGenres", new[] { "GenresId" });
            DropIndex("dbo.BookGenres", new[] { "BooksId" });
            DropIndex("dbo.BookAuthors", new[] { "AuthorsId" });
            DropIndex("dbo.BookAuthors", new[] { "BooksId" });
            DropTable("dbo.BookGenres");
            DropTable("dbo.BookAuthors");
        }
    }
}
