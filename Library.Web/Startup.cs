﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Library.Web.Startup))]

namespace Library.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {

        }
    }
}
