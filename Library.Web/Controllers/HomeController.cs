using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Library.Core;
using Library.Core.Shared;
using System.Linq;

namespace Library.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Books";

            IEnumerable<Book> list = BookManager.GetAllBooks();

            return View(list);
        }
    }
}
