using _8_DemoFormValidation.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _8_DemoFormValidation.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new Employe());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Exclude = "photo")] Employe emp, HttpPostedFileBase photo)
        {
           string extension = Path.GetExtension(photo.FileName);
           if (extension.Equals(".jpg") || extension.Equals(".jpeg"))
            {
                //avant d'insérer l'employe en base, en doit vérifier si tous les champs sont valides
                if (ModelState.IsValid)
                {
                    return Content("Employé inséré en base......");
                }
                else
                {
                    return View(emp);
                }
            }
           
            else
            {
                ViewBag.ImageNonValide = "Extension d'image non Valide";
                return View(emp);
            }

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