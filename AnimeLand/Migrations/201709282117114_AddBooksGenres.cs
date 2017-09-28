namespace AnimeLand.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBooksGenres : DbMigration
    {
        public override void Up()
        {
            /*91_day*/
            Sql("INSERT INTO BookGenres (BooksId, GenresId) VALUES (1, 13)");
            Sql("INSERT INTO BookGenres (BooksId, GenresId) VALUES (1, 14)");
            Sql("INSERT INTO BookGenres (BooksId, GenresId) VALUES (1, 15)");
            /*fate_apocrypha*/
            Sql("INSERT INTO BookGenres (BooksId, GenresId) VALUES (3, 13)");
            Sql("INSERT INTO BookGenres (BooksId, GenresId) VALUES (3, 14)");
            Sql("INSERT INTO BookGenres (BooksId, GenresId) VALUES (3, 15)");
            Sql("INSERT INTO BookGenres (BooksId, GenresId) VALUES (3, 16)");
            Sql("INSERT INTO BookGenres (BooksId, GenresId) VALUES (3, 17)");
            Sql("INSERT INTO BookGenres (BooksId, GenresId) VALUES (3, 18)");
            /*noragami*/
            Sql("INSERT INTO BookGenres (BooksId, GenresId) VALUES (4, 13)");
            Sql("INSERT INTO BookGenres (BooksId, GenresId) VALUES (4, 19)");
            Sql("INSERT INTO BookGenres (BooksId, GenresId) VALUES (4, 16)");
            Sql("INSERT INTO BookGenres (BooksId, GenresId) VALUES (4, 20)");
            /*project_k*/
            Sql("INSERT INTO BookGenres (BooksId, GenresId) VALUES (5, 13)");
            Sql("INSERT INTO BookGenres (BooksId, GenresId) VALUES (5, 16)");
            /*steins_gate*/
            Sql("INSERT INTO BookGenres (BooksId, GenresId) VALUES (6, 21)");
            Sql("INSERT INTO BookGenres (BooksId, GenresId) VALUES (6, 22)");
            /*death_note*/
            Sql("INSERT INTO BookGenres (BooksId, GenresId) VALUES (2, 23)");
            Sql("INSERT INTO BookGenres (BooksId, GenresId) VALUES (2, 24)");
            Sql("INSERT INTO BookGenres (BooksId, GenresId) VALUES (2, 16)");
            Sql("INSERT INTO BookGenres (BooksId, GenresId) VALUES (2, 22)");
        }
        
        public override void Down()
        {
        }
    }
}
