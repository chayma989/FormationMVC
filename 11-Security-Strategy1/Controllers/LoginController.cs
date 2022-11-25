using _11_Security_Strategy1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _11_Security_Strategy1.Controllers
{
    public class LoginController : Controller
    {
        private MyContext context = new MyContext();
        // GET: Login
        public ActionResult Connexion()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Connexion([Bind(Include ="Email,Password")] Utilisateur utilisateur)
        {
            string ErrorMessg = "Echec Connexion...";

            if(ModelState.IsValid)
            {
             Utilisateur userBD = context.Utilisateurs.SingleOrDefault(user => utilisateur.Email.Equals(utilisateur.Email));
                if (userBD != null)
                {
                    if (userBD.Password.Equals(utilisateur.Password))
                    {
                        if (userBD.Admin)
                        {
                            Session["Admin"] = userBD.Admin;
                        }

                        Session["user_id"] = userBD.UtilisateurId;
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ViewBag.Erreur = ErrorMessg;
                    }
                }
                else
                {
                    ViewBag.Erreur = ErrorMessg;
                }

            }
            return View(utilisateur);
        }
        public ActionResult Logout()
        {

           // Session.RemoveAll();
            Session.Abandon();
            return RedirectToAction("Connexion");
        }

        public ActionResult Authorisation()
        {
            return View();
        }
    }
}