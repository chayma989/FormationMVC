using _11_Security_Strategy1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _11_Security_Strategy1.Controllers
{
    public class AccountController : Controller
    {
        private MyContext context = new MyContext();
        // GET: Account
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create([Bind(Include ="Email ,Password")] Utilisateur utilisateur)
        {
            if(ModelState.IsValid)
            {
                context.Utilisateurs.Add(utilisateur);
                context.SaveChanges();
                return RedirectToAction("Connexion", "Login");
            }
            return View(utilisateur);
        }
    }
}