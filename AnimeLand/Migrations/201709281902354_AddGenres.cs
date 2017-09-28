namespace AnimeLand.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenres : DbMigration
    {
        public override void Up()
        {
            /*Authors*/
            /*91_days*/
            Sql("INSERT INTO Authors (FIO) VALUES ('Taku Kishimoto')");
            /*fate_apocrypha*/
            Sql("INSERT INTO Authors (FIO) VALUES ('Yuichiro Higashide')");
            /*noragami*/
            Sql("INSERT INTO Authors (FIO) VALUES ('Adachitoka')");
            /*project_k*/
            Sql("INSERT INTO Authors (FIO) VALUES ('Nakanishi Go')");
            /*steins_gate*/
            Sql("INSERT INTO Authors (FIO) VALUES ('Chiyomaru Shikura')");
            /*death_note*/
            Sql("INSERT INTO Authors (FIO) VALUES ('Ohba Tsugumi')");
            Sql("INSERT INTO Authors (FIO) VALUES ('Obata Takeshi')");

            /*Genres*/
            Sql("INSERT INTO Genres (Name) VALUES ('Action')");
            Sql("INSERT INTO Genres (Name) VALUES ('Historical')");
            Sql("INSERT INTO Genres (Name) VALUES ('Drama')");
            Sql("INSERT INTO Genres (Name) VALUES ('Supernatural')");
            Sql("INSERT INTO Genres (Name) VALUES ('Magic')");
            Sql("INSERT INTO Genres (Name) VALUES ('Fantasy')");
            Sql("INSERT INTO Genres (Name) VALUES ('Adventure')");
            Sql("INSERT INTO Genres (Name) VALUES ('Shounen')");
            Sql("INSERT INTO Genres (Name) VALUES ('Sci-Fi')");
            Sql("INSERT INTO Genres (Name) VALUES ('Thriller')");
            Sql("INSERT INTO Genres (Name) VALUES ('Mystery')");
            Sql("INSERT INTO Genres (Name) VALUES ('Psychological')");

            /*Counties*/
            Sql("INSERT INTO Countries (Name) VALUES ('Japan')");


        }
        
        public override void Down()
        {
        }
    }
}
