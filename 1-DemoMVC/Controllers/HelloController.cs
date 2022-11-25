using _1_DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1_DemoMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            ViewBag.Nom = "Dawan";
            ViewBag.Prenom = "Jehann";

            Personne p = new Personne() { Nom = "Fayzi", Prenom = "Chaymae" };

            return View("Vue2",p);
        }
    }
}