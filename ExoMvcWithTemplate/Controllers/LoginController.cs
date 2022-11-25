using ExoMvcWithTemplate.DTOs;
using ExoMvcWithTemplate.Models;
using ExoMvcWithTemplate.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExoMvcWithTemplate.Controllers
{
    public class LoginController : Controller
    {
        private UtilisateurService service = new UtilisateurService();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(LoginDTO loginDTO)
        {
            UtilisateurDTO userDTO = service.FindUserByUserNameAndPassword(loginDTO);
            if (userDTO != null && userDTO.Id != 0)
            {

                if (userDTO.IsAdmin)
                {
                    Session["userAdmin"] = userDTO;
                }
                else
                {
                    Session["user"] = userDTO;
                }
                return RedirectToAction("Index", "Home"); //page d'accueil
                //return Content("Page d'accueil.....");
            }
            else
            {
                ViewBag.Erreur = "Echec connexion.......";
            }

            return View(loginDTO);
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index");
        }
    }

    
}