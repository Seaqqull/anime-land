namespace AnimeLand.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BooksImage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BookAuthors", "BookImagePath", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BookAuthors", "BookImagePath");
        }
    }
}
