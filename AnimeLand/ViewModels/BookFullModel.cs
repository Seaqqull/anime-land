using AnimeLand.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnimeLand.ViewModels
{
    public class BookFullModel
    {
        public Books Books { get; set; }
        public List<BookAuthors> BookAuthors { get; set; }
        public List<BookGenres> BookGenres { get; set; }
    }
}