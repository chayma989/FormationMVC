using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _11_Security_Strategy1.Models
{
    public class AdminFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Session["Admin"]==null)
            {
                filterContext.HttpContext.Response.Redirect("~/Login/Autorisation");
            }
        }
    }
}