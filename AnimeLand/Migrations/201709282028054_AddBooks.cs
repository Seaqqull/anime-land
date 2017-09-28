namespace AnimeLand.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBooks : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Books (Title, TitleEng, Discription, CountriesId, ImagePath, YearPublished) " +
                "VALUES ('91 Äåíü', " +
                "'91 Days', " +
                "'As a child living in the town of Lawless, Angelo Lagusa has witnessed a tragedy: his parents and younger brother have been mercilessly slaughtered by the Vanetti mafia family." +
                " Losing everything he holds dear, he leaves both his name and hometown behind, adopting the new identity of Avilio Bruno. " +
                "Seven years later, Avilio finally has his chance for revenge when he receives a mysterious letter prompting him to return to Lawless.Obliging, he soon encounters the Vanetti dons son, Nero, and seeks to befriend him using the skills he has quietly honed for years. " +
                "Set during the Prohibition era, 91 Days tells the story of Avilios dark, bloodstained path to vengeance, as he slowly ends each of the men involved in the killing of his family.', " +
                "1, " +
                "'~/Content/images/91_days.jpg', " +
                "2016)");

            Sql("INSERT INTO Books (Title, TitleEng, Discription, CountriesId, ImagePath, YearPublished) " +
                "VALUES('Òåòðàäü Ñìåðòè', " +
                "'Death Note', " +
                "'A shinigami, as a god of death, can kill any person—provided they see their victims face and write their victims name in a notebook called a Death Note. One day, Ryuk, bored by the shinigami lifestyle and interested in seeing how a human would use a Death Note, drops one into the human realm. " +
                "High school student and prodigy Light Yagami stumbles upon the Death Note and—since he deplores the state of the world—tests the deadly notebook by writing a criminals name in it. When the criminal dies immediately following his experiment with the Death Note, Light is greatly surprised and quickly recognizes how devastating the power that has fallen into his hands could be." +
                "With this divine capability, Light decides to extinguish all criminals in order to build a new world where crime does not exist and people worship him as a god.Police, however, quickly discover that a serial killer is targeting criminals and, consequently, try to apprehend the culprit.', " +
                "1, " +
                "'~/Content/images/death_note.jpg', " +
                "2003)");

            Sql("INSERT INTO Books (Title, TitleEng, Discription, CountriesId, ImagePath, YearPublished) " +
                "VALUES('Ñóäüáà Àïîêðèô', " +
                "'Fate: Apocrypha', " +
                "'The setting is a parallel world to Fate/stay night where the Greater Grail mysteriously disappeared from Fuyuki after the Third Holy Grail War. After many years of silence, around the same time as the Fifth Holy Grail War would have happened, the Yggdmillennia, a family of magi, openly declares their secession from the Mages Association, and that they are in possession of the Grail. " +
                "The Association dispatches fifty magi to retrieve it, and all but one are instantly slaughtered by a mysterious Servant. The one remaining manages to activate the reserve system of the Greater Grail, allowing for the summoning of fourteen Servants in total. " +
                "In the city of Trifas, two factions will fight for the control of the sacred relic, each of them possessing their own team of seven Servants: the Black Faction whose members are part of Yggdmillennia, protecting the Grail, and the Red Faction whose members were sent by the Mages Association, trying to take the Grail back.', " +
                "1, " +
                "'~/Content/images/fate_apocrypha.jpg', " +
                "2017)");

            Sql("INSERT INTO Books (Title, TitleEng, Discription, CountriesId, ImagePath, YearPublished) " +
                "VALUES('Áåçäîìíûé Áîã', " +
                "'Noragami', " +
                "'In times of need, if you look in the right place, you just may see a strange telephone number scrawled in red. If you call this number, you will hear a young man introduce himself as the Yato God. Yato is a minor deity and a self - proclaimed Delivery God, who dreams of having millions of worshippers. " +
                "Without a single shrine dedicated to his name, however, his goals are far from being realized.He spends his days doing odd jobs for five yen apiece, until his weapon partner becomes fed up with her useless master and deserts him. Just as things seem to be looking grim for the god, his fortune changes when a middle school girl, Hiyori Iki, " +
                "supposedly saves Yato from a car accident, taking the hit for him.', " +
                "1, " +
                "'~/Content/images/noragami.jpg', " +
                "2014)");

            Sql("INSERT INTO Books (Title, TitleEng, Discription, CountriesId, ImagePath, YearPublished) " +
                "VALUES('Ïðîåêò Ê', " +
                "'K Project', " +
                "'Kings are individuals who have been bestowed with incredible supernatural powers and granted the ability to recruit others into their clans. Protecting the lives and honor of their clansmen is an integral part of the Kings duties. After a video depicting the heinous murder of a Red Clansman spreads virally, the unassuming student Yashiro Isana is accused of homicide. " +
                "Now, a manhunt is underway for his head, bringing him into contact with the infamous Black Dog Kurou Yatogami—a skilled swordsman and martial artist determined to follow the wishes of his late master, the Seventh King. Meanwhile, the current Red King, Mikoto Suou, faces his own imminent demise as the search for Yashiro narrows. But during Yashiros struggle to prove his innocence, " +
                "a greater conspiracy is unraveling behind the scenes;', " +
                "1, " +
                "'~/Content/images/project_k.jpg', " +
                "2012)");

            Sql("INSERT INTO Books (Title, TitleEng, Discription, CountriesId, ImagePath, YearPublished) " +
                "VALUES('Âðàòà Øòåéíà', " +
                "'Steins Gate', " +
                "'The self-proclaimed mad scientist Rintarou Okabe rents out a room in a rickety old building in Akihabara, where he indulges himself in his hobby of inventing prospective future gadgets with fellow lab members: Mayuri Shiina, his air-headed childhood friend, and Hashida Itaru, a perverted hacker nicknamed Daru. The three pass the time by tinkering with their most promising contraption yet," +
                " a machine dubbed the Phone Microwave, which performs the strange function of morphing bananas into piles of green gel. Though miraculous in itself, the phenomenon doesnt provide anything concrete in Okabes search for a scientific breakthrough; that is, until the lab members are spurred into action by a string of mysterious happenings before stumbling upon an unexpected success—the Phone " +
                "Microwave can send emails to the past, altering the flow of history.', " +
                "1, " +
                "'~/Content/images/steins_gate.jpg', " +
                "2011)");
        }
        
        public override void Down()
        {
        }
    }
}
