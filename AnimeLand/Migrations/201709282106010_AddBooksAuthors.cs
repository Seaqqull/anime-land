namespace AnimeLand.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBooksAuthors : DbMigration
    {
        public override void Up()
        {
            /*91_day*/
            Sql("INSERT INTO BookAuthors (BooksId, AuthorsId) VALUES (1, 8)");
            /*fate_apocrypha*/
            Sql("INSERT INTO BookAuthors (BooksId, AuthorsId) VALUES (3, 9)");
            /*noragami*/
            Sql("INSERT INTO BookAuthors (BooksId, AuthorsId) VALUES (4, 10)");
            /*project_k*/
            Sql("INSERT INTO BookAuthors (BooksId, AuthorsId) VALUES (5, 11)");
            /*steins_gate*/
            Sql("INSERT INTO BookAuthors (BooksId, AuthorsId) VALUES (6, 12)");
            /*death_note*/
            Sql("INSERT INTO BookAuthors (BooksId, AuthorsId) VALUES (2, 13)");
            Sql("INSERT INTO BookAuthors (BooksId, AuthorsId) VALUES (2, 14)");

        }
        
        public override void Down()
        {
        }
    }
}
