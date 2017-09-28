namespace AnimeLand.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFieldYearPublish : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "YearPublished", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "YearPublished");
        }
    }
}
