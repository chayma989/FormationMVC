using _7_DemoHtmlHelper.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _7_DemoHtmlHelper.Controllers
{
    public class Formation
    {
        public int Id { get; set; }
        public string Nom { get; set; }
    }
    public class Centre
    {
        public int Id { get; set; }
        public string Nom { get; set; }
    }
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Formation> lstFormations = new List<Formation>
        {
            new Formation(){Id=1,Nom="Asp.net"},
            new Formation(){Id=2,Nom="Java"},
            new Formation(){Id=3,Nom="PHP"}
        };

            SelectList formations = new SelectList(lstFormations, "Id", "Nom", 2);
            ViewBag.formations = formations;

            List<Centre> lstCentres = new List<Centre>
        {
            new Centre(){Id=1,Nom="centre1"},
            new Centre(){Id=2,Nom="centre2"},
            new Centre(){Id=3,Nom="centre3"},
            new Centre(){Id=4,Nom="centre4"}
        };

            SelectList centres = new SelectList(lstCentres, "Id", "Nom");
            ViewBag.centres = centres;
            return View();
        }

        [HttpPost]
        public ActionResult Bonjour(string nom,string prenom,string Poste,int formation, int? centre)
        {
            //pour centre et formation, les données sont stockées dans ViewBag qui est détruit par le serveur juste aprés

            //List<SelectListItem> formations =(List<SelectListItem>)TempData["formations"];
            return Content("Nom: " + nom + "Prénom: " + prenom + "Poste: " + Poste+ "Formation: ");
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
        public ActionResult AfficherContact()
        {
            return View(new Contact());
        }
        [HttpPost]
        public ActionResult AjouterContact([Bind(Include ="Nom,Photo")] Contact c,HttpPostedFileBase photo)
        {
            //sauvegarder des fichier
            string fileName = c.Id + Path.GetExtension(photo.FileName);//personnaliser le nom du fichier 10.jpg
            c.Photo = fileName;
            string cheminDossier = Server.MapPath("~/Content/Image/" + fileName);
            photo.SaveAs(cheminDossier);
            return Content("Contact ajouté");
        }
    }
}