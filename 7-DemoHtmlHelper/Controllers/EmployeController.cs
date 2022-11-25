using _7_DemoHtmlHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _7_DemoHtmlHelper.Controllers
{
    public class EmployeController : Controller
    {
        // GET: Employe
        public ActionResult Index()
        {
            List<Departement> departements = new List<Departement>
            {
                new Departement{DepartementId=1, Nom="Info"},
                new Departement{DepartementId=2, Nom="Recherche"},
                new Departement{DepartementId=3, Nom="Dev"},
            };
            SelectList sl = new SelectList(departements, "DepartementId", "Nom");
            TempData["DepartementId"] = sl;
            TempData.Keep();

            Employe emp = new Employe
            {
                Id = 1,
                Nom = "Toto",
                Salaire = 1500,
                IsActif = true,
                DateEntree = DateTime.Now,
                type = EmployeType.DEBUTANT

            };
            return View(emp);
        }
        
        //si on connait pas le type d'objet renvoyé par le formulaire, on prut utiliser le type générique 
        [HttpPost]
        public ActionResult Index(Employe emp)
        {
            return null;
        }
    }
}