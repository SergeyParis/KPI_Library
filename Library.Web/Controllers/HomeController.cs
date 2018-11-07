﻿using System.Collections.Generic;
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

        private EntityType _currentType = EntityType.Nothing;

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
        public ActionResult Index(string name)
        {
            return null;
        }

        [HttpPost]
        public void GetTypeForm(EntityType type)
        {
            if (type == EntityType.Book)
            {
                ViewBag.Authors = MakeGetRequest<Author>(((int)EntityType.Author).ToString());
            }

            _currentType = type;
            ViewBag.Type = type;
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
