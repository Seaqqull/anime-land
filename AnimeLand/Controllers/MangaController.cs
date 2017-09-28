using AnimeLand.Models;
using AnimeLand.ViewModels;
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
        public ActionResult Index()
        {
            var books = _context.Books.ToList();

            return View(books);
        }
    }
}