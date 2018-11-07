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

            Author author = DBManager.GetAuthorByName("Mark Twain");
            Client client = DBManager.GetClientByName("Max Brazhnik");

            DBManager.AddBook(new Book("The Birthday Boy", "1402742681", author));
            DBManager.AddBook(new Book("The Spelling Bee", "140274269X", author));
            DBManager.AddBook(new Book("The Adventures of Tom Sawyer #6: Tom's Treasure Hunt", "1402767544", author));
            DBManager.AddBook(new Book("Romeo and Juliet", "1906230455", author));
            DBManager.AddBook(new Book("Anna Karenina", "1911091042", author));

            IEnumerable<Book> list = DBManager.GetAllBooks();

            return View(list);
        }
    }
}
