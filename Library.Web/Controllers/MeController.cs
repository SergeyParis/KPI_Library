using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Owin;
using Library.Web.Models;

namespace Library.Web.Controllers
{
    [Authorize]
    public class MeController : ApiController
    {
        public MeController()
        {
        }
        
        public GetViewModel Get()
        {
            return new GetViewModel() {  };
        }
    }
}