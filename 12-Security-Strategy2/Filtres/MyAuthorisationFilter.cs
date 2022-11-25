using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _12_Security_Strategy2.Filtres
{
    public class MyAuthorisationFilter : AuthorizeAttribute
    {
        private readonly string[] allowedRoles;

        public MyAuthorisationFilter(params string[] roles)
        {
            allowedRoles = roles;
        }
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            bool authorize = false;
            string userId = Convert.ToString(httpContext.Session["userId"]);
            if (!string.IsNullOrEmpty(userId))
            {
                using (var context = new MyContext())
                {
                    var userRole = (from u in context.Users
                                    join r in context.Roles on u.RoleId equals r.Id
                                    where u.UserId == userId
                                    select new { r.Name }).FirstOrDefault();
                    foreach (var role in allowedRoles)
                    {
                        if (role == userRole.Name)

                            return true;

                    }
                }
            }
                return authorize;
        }

        //cette méthode est exécutée automatiquement si AuthorizeCore renvoie false

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            //option1: 
            // filterContext.HttpContext.Response.Redirect("~/Account/Autorisation");

            //option2:redirection vers une autre route
            filterContext.Result = new RedirectToRouteResult(
                new System.Web.Routing.RouteValueDictionary() { 
                {"controller","Account" },
                { "action","Autorisation"}
           });
        }
        
    }

}