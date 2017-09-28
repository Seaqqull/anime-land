using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnimeLand.Models
{
    public class BookGenres
    {
        public int Id { get; set; }
        public Books Books { get; set; }
        public int BooksId { get; set; }
        public Genres Genres { get; set; }
        public int GenresId { get; set; }
    }
}