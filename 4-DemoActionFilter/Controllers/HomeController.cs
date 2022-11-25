using _4_DemoActionFilter.Filtres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _4_DemoActionFilter.Controllers
{
    //[HandleError]//toutes les action du controller sont filtrer
    //[LogFilter]
    public class HomeController : Controller
    {
        [OutputCache(Duration =10)]//mise en cache du serveur pour 10 secondes du contenu TemData
        public ActionResult Index()
        {
            TempData["Heure"] = DateTime.Now.ToLongTimeString();
            return View();
        }
        [HttpPost]
        [ValidateInput(true)]//par defaut =true et pas besoin de l'utiliser
                             //protection contre des attaques des types script injectées via un formulaire
        public ActionResult Index(string demo)
        {
            ViewBag.param = demo;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]//permet la vérifier le post client a transmi les données
        public ActionResult Index2(string txtDemo)
        {
            ViewBag.Autreparam = txtDemo;
            return View("Index");
        }

        [Authorize] //accésible uniquement aux users connéctes - Filtre à utiliser avec FremWork Identity(system de gestion des users avec des authorisations)
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            throw new Exception("Mon exception");
            return View();
        }
       // [HandleError]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            throw new Exception("Mon exception");

            return View();
        }
        //action exécutée dans le cas d'une URL non valide - voir le fichier Web.Config Global - Section 
        public ActionResult Error404()
        {
            return View("UrlError");
        }
    }
}