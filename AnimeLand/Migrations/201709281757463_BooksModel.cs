namespace AnimeLand.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BooksModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                        TitleEng = c.String(nullable: false, maxLength: 100),
                        Discription = c.String(nullable: false, maxLength: 1000),
                        CountriesId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountriesId, cascadeDelete: true)
                .Index(t => t.CountriesId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "CountriesId", "dbo.Countries");
            DropIndex("dbo.Books", new[] { "CountriesId" });
            DropTable("dbo.Books");
        }
    }
}
