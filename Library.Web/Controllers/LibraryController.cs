using Library.Core;
using Library.Core.Shared;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Library.Web.Controllers
{
    public class LibraryController : ApiController
    {
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, DBManager.GetAllBooks());
        }
        
        public void Post([FromBody]object value, [FromBody]EntityType type)
        {

        }

        public void Put([FromBody]Book book, [FromBody]Client client)
        {

        }

        public void Delete([FromBody]Book value)
        {
            DBManager.DeleteBook(value);
        }
    }
}
