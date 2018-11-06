using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Library.Shared;
using Library.Shared.Models;
using Library.Core;

namespace Library.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Books";

            IAuthor author = new Author("Name Author 1");
            List<IBook> list = new List<IBook>()
            {
                new Book("Name book 1", "5555511111000", author),
                new Book("Name book 2", "5555511111001", author)
            };

            return View(list);
        }
    }
}
