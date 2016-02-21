using asp_lesson_5_10_a.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp_lesson_5_10_a.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult GetAuthor()
        {
            return View();
        }
        BookContext db = new BookContext();

        [HttpPost]
        public ActionResult GetAuthor(Author author)
        {
            db.Authors.Add(author);
            //db.Books.AddRange(author.Books);
            db.SaveChanges();
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}