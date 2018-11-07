using System.Collections.Generic;
using System.Web.Mvc;
using Library.Core.Shared;
using System.Net.Http;
using System.Threading.Tasks;

namespace Library.Web.Controllers
{
    public class HomeController : Controller
    {
        private static HttpClient _client = new HttpClient();

        public async Task<ActionResult> Index()
        {
            ViewBag.Title = "Books";

            IEnumerable<Book> list = await _client.GetAsync("http://localhost:61592/api/Library").Result.Content.ReadAsAsync<IEnumerable<Book>>();

            return View(list);
        }
    }
}
