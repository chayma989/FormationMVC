using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _11_Security_Strategy1.Filtres
{
    public class LoginFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Session["user_id"] == null)
            {
                //redirection vers la page de connexion
                filterContext.HttpContext.Response.Redirect("~/Login/Connexion");
            }

        }
    }
}