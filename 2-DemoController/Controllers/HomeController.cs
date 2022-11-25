using _2_DemoController.Models;
using _2_DemoController.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace _2_DemoController.Controllers
{
    //controller : une classe qui hérite de la clas Controller et qui posséde un certain nombres de méthode appelées Action
    //chaque Action répond à une requete du poste client
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return  View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            //return Redirect("/Home/Contact");//redirection vers l"action contact de HomeController
            //return RedirectToAction("Index","Test",new {nom="Dawan", prenom="Jehann"});
            return RedirectToRoute("ContactDetails");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            // return Content("Ceci est le contenu de l'action Contact du controller Home");
            //return Content("<Personne><Nom>Dawan</Nom><Prenom>Paris</Prenom></Personne>", "text/xml");
            //return File(Server.MapPath("~/Demo.txt"), "text/plain");//affiche le contenu du fichier sur le poste client(navigateur)
            //return File(Server.MapPath("~/Demo.txt"), "text/plain", "down.txt");
            // return JavaScript("alert('Test de la methode return JavaScript)");
            //return null;//empty
            Personne p = new Personne { Nom = "Dawan", Prenom = "Paris" };
            //return Json(p,JsonRequestBehavior.AllowGet);
            string jsonStr = JsonTool.ToJson<Personne>(p);
            byte[] tabByte= Encoding.UTF8.GetBytes(jsonStr);
            //return File(tabByte, "application/json", "personne.json");
            //return HttpNotFound();
            // return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest,"Mauvaise requete");
            return new HttpUnauthorizedResult("Authorisation refusé ");
        }
    }
}