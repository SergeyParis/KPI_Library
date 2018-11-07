using Library.Core;
using Library.Core.Shared;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Library.Web.Controllers
{
    public class LibraryController : ApiController
    {
        private static JavaScriptSerializer _JSON = new JavaScriptSerializer() { };

        public HttpResponseMessage Get()
        {
            string json = JsonConvert.SerializeObject(DBManager.GetAllBooks(), Formatting.None,
                new JsonSerializerSettings() { ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore });

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(json, Encoding.UTF8, "application/json");

            return response;
        }
        public HttpResponseMessage Get(int type)
        {
            string json = "";

            switch (type)
            {
                case (int)EntityType.Book: return this.Get();
                case (int)EntityType.Author:
                    json = JsonConvert.SerializeObject(DBManager.GetAllAuthors(), Formatting.None, 
                        new JsonSerializerSettings() { ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore });
                    break;
                case (int)EntityType.Client:
                    json = JsonConvert.SerializeObject(DBManager.GetAllClients(), Formatting.None,
                        new JsonSerializerSettings() { ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore });
                    break;
                default: return null;
            }

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(json, Encoding.UTF8, "application/json");

            return response;
        }

        public void Post([FromBody]int id, [FromBody]int type)
        {

        }

        public void Put([FromBody]int bookId, [FromBody]int clientId)
        {

        }

        public void Delete([FromBody]int bookId)
        {

        }
    }
}
