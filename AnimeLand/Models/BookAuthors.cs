using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnimeLand.Models
{
    public class BookAuthors
    {
        public int Id { get; set; }
        public Books Books { get; set; }
        public int BooksId { get; set; }
        public Authors Authors { get; set; }
        public int AuthorsId { get; set; }
    }
}