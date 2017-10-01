using AnimeLand.Models;
using AnimeLand.ViewModels;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnimeLand.Controllers
{
    public class MangaController : Controller
    {
        private ApplicationDbContext _context;

        public MangaController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Manga
        public ActionResult Index(int? page)
        {
            Dictionary<int, String> links = new Dictionary<int, String>();

            int pageSize = 2; // books per page
            int pageNumber = (page ?? 1); // current page
            int cntBooks = _context.Books.Count(); // count books
            int countPage = 1; // count pages

            if (cntBooks != 0)
                countPage = (int)((cntBooks - 1) / pageSize) + 1;
            if (countPage == 0) countPage = 1;
            if (pageNumber > countPage) pageNumber = countPage;
            if (pageNumber == 0) pageNumber = 1;


            links[pageNumber] = pageNumber.ToString();
            for (int i = 1; i < 3; i++) {
                if(pageNumber - i > 0)
                    links[pageNumber - i] = (i == 2) ? "..." : (pageNumber - i).ToString();
                if (pageNumber + i <= countPage)
                    links[pageNumber + i] = (i == 2) ? "..." : (pageNumber + i).ToString();
            }
            links[1] = "1";
            links[countPage] = countPage.ToString();

            //IOrderedEnumerable<KeyValuePair<int, string>> links_ = links.OrderBy(link => link.Key);
            //links_.ElementAt(links.Count - 1);
            //var items = from pair in links
            //            orderby pair.Key ascending
            //                       select pair;

            //
            //var books_ = _context.Books.OrderBy(book => book.Id).Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList(),
            //

            BookListModel bookListModel = new BookListModel {
                Books = _context.Books.OrderBy(book => book.Id).Skip(pageSize * (pageNumber - 1)).Take(pageSize).ToList(),
                Links = links.OrderBy(link => link.Key),
                CurrentPage = pageNumber
            };

            return View(bookListModel);

            //var books = _context.Books.ToList();
            //return View(books.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult Detail(int? id)
        {
            id = (id ?? 1);

            var book = _context.Books.SingleOrDefault(c => c.Id == id);
            var authors = _context.Authors.Where(author => _context.BookAuthors.Where(b => b.BooksId == id).Count(it => it.AuthorsId == author.Id) != 0);// _context.BookAuthors.Where(b => b.BooksId == id);
            var genres = _context.Genres.Where(genr => _context.BookGenres.Where(b => b.BooksId == id).Count(it => it.GenresId == genr.Id) != 0);
            var bookFull = new BookFullModel
            {
                Books = book,
                BookAuthors = authors,
                BookGenres = genres
            };


            return View(bookFull);
        }
    }
}