using Library.Core;
using Library.Core.Shared;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Library.Web.Controllers
{
    public class LibraryController : ApiController
    {
        public IEnumerable<Book> Get()
        {
            return DBManager.GetAllBooks();
        }
        
        public void Post([FromBody]object value, EntityType type)
        {

        }

        public void Put([FromBody]Book value)
        {

        }

        public void Delete([FromBody]Book value)
        {
            DBManager.DeleteBook(value);
        }
    }
}
