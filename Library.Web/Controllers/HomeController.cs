using System.Collections.Generic;
using System.Web.Mvc;
using Library.Core.Shared;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Library.Web.Controllers
{
    public class HomeController : Controller
    {
        private static HttpClient _client;
        private static JavaScriptSerializer _JSON = new JavaScriptSerializer();

        

        static HomeController()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://localhost:61592");
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("aplication/json"));
        }

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Title = "Books";

            IEnumerable<Book> list = null;
            HttpResponseMessage response = _client.GetAsync("api/Library").Result;
            if (response.IsSuccessStatusCode)
            {
                var tmp = response.Content.ReadAsStringAsync().Result;
                list = JsonConvert.DeserializeObject<IEnumerable<Book>>(tmp);
            }

            return View(new HomeViewModel() { Books = list });
        }

        [HttpPost]
        public ActionResult Index(string name)
        {
            return null;
        }

        [HttpPost]
        public void GetTypeForm(EntityType type)
        {
            ViewBag.Type = type;
        }
    }
}
