using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _12_Security_Strategy2.Filtres
{
    public class LoginFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Session["userName"]==null)
            {
                filterContext.HttpContext.Response.Redirect("~/Account/Login");
            }
        }
    }
}