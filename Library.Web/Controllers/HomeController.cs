using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Library.Shared;
using Library.Shared.Models;
using Library.Core;
using System.Linq;

namespace Library.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Books";

            IEnumerable<IBook> list = BookManager.GetAllBooks();

            return View(list);
        }
    }
}
