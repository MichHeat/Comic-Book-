using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About our Comic Books.";

            return View();
        }

        public ActionResult Location()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Features()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Favourites()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}