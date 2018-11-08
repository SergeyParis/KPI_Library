using System.Collections.Generic;
using System.Web.Mvc;
using Library.Core.Shared;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Library.Core;

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
            return View(new HomeViewModel() { Books = MakeGetRequest<Book>(string.Empty) });
        }

        [HttpPost]
        public void Index(int type, string name)
        {
            EntityType Type = (EntityType)type;

            switch (Type)
            {
                case EntityType.Client:

                    break;
                case EntityType.Author:

                    break;
                case EntityType.Book:

                    break;

            }
        }


        [NonAction]
        public IEnumerable<T> MakeGetRequest<T>(string parameters)
        {
            IEnumerable<T> result;
            string queryString;

            if (string.IsNullOrEmpty(parameters))
                queryString = "api/Library";
            else
                queryString = $"api/Library/{parameters}";


            HttpResponseMessage response = _client.GetAsync("api/Library").Result;
            if (response.IsSuccessStatusCode)
                result = JsonConvert.DeserializeObject<IEnumerable<T>>(response.Content.ReadAsStringAsync().Result);
            else
                result = null;

            return result;
        }
    }
}
