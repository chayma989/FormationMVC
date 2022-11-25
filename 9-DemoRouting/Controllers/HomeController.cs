using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _9_DemoRouting.Controllers
{
    [RoutePrefix("myRoute")]
    public class HomeController : Controller
    {
        [Route("~/")]//permet de faire un override du RoutePrefix - Ne prend pas en compte le RoutePrefix dans le routage
        [Route("Index")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("~/About/{name:minlength(3)?}")]//c'est définir des paramètres optionnel + contrainte
        public ActionResult About(string name)
        {
            ViewBag.Message = "Your application description page.Name = "+name;

            return View();
        }

        [Route("ContactUs/{id:int}")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}