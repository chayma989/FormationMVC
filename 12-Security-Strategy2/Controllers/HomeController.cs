using _12_Security_Strategy2.Filtres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _12_Security_Strategy2.Controllers
{
    [LoginFilter]
    public class HomeController : Controller
    {
        [MyAuthorisationFilter("Admin","Manager")]
        public ActionResult Index()
        {
            return View();
        }

        [MyAuthorisationFilter("Admin", "Visitor")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [MyAuthorisationFilter("Admin")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}