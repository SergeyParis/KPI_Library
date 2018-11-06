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

            BookManager.DROP_DB();

            Author author = new Author("Mark Twain");
            Client client = new Client("Max Brazhnik", 2);
            BookManager.AddBook(new Book("A Song for Aunt Polly", "1402732872", author));
            BookManager.AddBook(new Book("The Birthday Boy", "1402742681", author));
            BookManager.AddBook(new Book("The Spelling Bee", "140274269X", author));
            BookManager.AddBook(new Book("The Adventures of Tom Sawyer #6: Tom's Treasure Hunt", "1402767544", true, author, client));
            BookManager.AddBook(new Book("Romeo and Juliet", "1906230455", true, author, client));
            BookManager.AddBook(new Book("Anna Karenina", "1911091042", author));

            IEnumerable<IBook> list = BookManager.GetAllBooks();

            return View(list);
        }
    }
}
