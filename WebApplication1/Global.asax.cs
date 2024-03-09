using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ViewEngines.Engines.Clear();
            var razorEngine = new RazorViewEngine();
            razorEngine.ViewLocationFormats = razorEngine.MasterLocationFormats
                .Concat(new[] {
                "~Views/Home/{1}/{0}.cshtml",
                }).ToArray();
            ViewEngines.Engines.Add(razorEngine);

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
