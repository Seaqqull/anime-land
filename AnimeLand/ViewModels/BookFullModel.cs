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
        public IQueryable<Authors> BookAuthors { get; set; }
        public IQueryable<Genres> BookGenres { get; set; }
    }
}