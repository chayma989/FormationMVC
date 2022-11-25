using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2_DemoController.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index(string nom,string prenom)
        {
            return Content("Nom: "+nom+  " Prenom: " +prenom);
        }
    }
}