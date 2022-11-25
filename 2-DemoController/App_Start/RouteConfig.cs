using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _2_DemoController
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //pour les routes personnalisées on doit les définir avant 

            routes.MapRoute(
                name: "ContactDetails",
                url: "ContactDet/",
                defaults: new { controller = "Test", action = "Index", nom = "Dawan", prenom = "Paris" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
