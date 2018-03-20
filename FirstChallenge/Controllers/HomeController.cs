using FirstChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstChallenge.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(ComicBookManager.GetComicBooks());
        }

        public ActionResult Detail(int id)
        {
            return View(ComicBookManager.GetComicBooks().FirstOrDefault(x => x.ComicBookId == id));
        }
    }
}