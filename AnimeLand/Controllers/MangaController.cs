using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnimeLand.Controllers
{
    public class MangaController : Controller
    {        
        // GET: Manga
        public ActionResult Index()
        {
            return View();
        }
    }
}