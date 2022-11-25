using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _1_DemoMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{nb}/{nb1}",
                defaults: new { controller = "Home", action = "Index", nb = UrlParameter.Optional, nb1 = UrlParameter.Optional }
            );
        }
    }
}
