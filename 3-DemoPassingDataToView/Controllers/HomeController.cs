using _3_DemoPassingDataToView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3_DemoPassingDataToView.Controllers
{
    public class HomeController : Controller
    {
        Contacts c = new Contacts { Nom = "nomContact", Prenom = "prenomContact" };

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Nom = "dawan";
            ViewData["Prenom"] = "jehann";
            TempData["Formation"] = "Asp.Net";
            TempData.Keep();//keep permet de maintenir lie contenu de TempData aprés consommation
            Session["Version"] = "5.0";//données maintenues pendant toute la durrée de la session
            // Session.Abandon();//session détruite par le serveur
           //Session.Remove("Version");
          //Session.Timeout = 1;//session valide pendant 1 min

            //envoie d'objet à la vue

            
            return View(c);
        }

        [HttpPost]
        public ActionResult Index(string nom)
        {
            ViewBag.Param = nom;
            return View(c);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}