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
            var books = _context.Books.ToList();

            int pageSize = 3;
            int pageNumber = (page ?? 1);


            return View(books.ToPagedList(pageNumber, pageSize));
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