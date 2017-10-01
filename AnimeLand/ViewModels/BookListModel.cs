using AnimeLand.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnimeLand.ViewModels
{
    public class BookListModel
    {
        public List<Books> Books { get; set; }
        public IOrderedEnumerable<KeyValuePair<int, string>> Links { get; set; }
        public int CurrentPage { get; set; }
    }
}