using ExoMvcWithTemplate.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ExoMvcWithTemplate
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //initialisation du mapper
            MapperConfig.Configure();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        }
    }
}
