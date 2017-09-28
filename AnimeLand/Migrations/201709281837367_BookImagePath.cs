namespace AnimeLand.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookImagePath : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "ImagePath", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "ImagePath");
        }
    }
}
