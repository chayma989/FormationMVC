using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _4_DemoActionFilter.Filtres
{
    public class LogFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Trace("OnActionExecuted", filterContext.RouteData);
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Trace("OnActionExecuting", filterContext.RouteData);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Trace("OnResultExecuted", filterContext.RouteData);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Trace("OnResultExecuting", filterContext.RouteData);
        }

        public void Trace(string methodeName, RouteData routeData)
        {
            //accéder aux valeur du routage de la route
            string actionName, controllerName;
            controllerName = routeData.Values["controller"].ToString();
            actionName = routeData.Values["action"].ToString();

            string str = string.Format("1- Méthode name : {0} - Controller name : {1} - action name : {2}", methodeName, controllerName, actionName);
            System.Diagnostics.Trace.WriteLine(str);

            //afficher str dans la page web :httpContext pointe l'application en cours
            HttpContext.Current.Response.Write("<br>" + str + "</br>");
        }
    }
}