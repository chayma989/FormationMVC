using _12_Security_Strategy2.Filtres;
using _12_Security_Strategy2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _12_Security_Strategy2.Controllers
{
    
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [MyAuthorisationFilter("admin","manager","rh","","")]
        public ActionResult Login(User model)
        {
            if(ModelState.IsValid)
            {
                using(var context=new MyContext())
                {
                   User user = context.Users.Where(u => u.UserId==model.UserId && u.Password==model.Password).FirstOrDefault();
                    if(user!=null)
                    {
                        Session["userName"] = user.UserName;
                        Session["userId"] = user.UserId;
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ViewBag.Error = "Echec Connexion....";
                    }
                }
            }
            return View(model);
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Login");
        }
        public ActionResult Autorisation()
        {
            return View();
        }
    }
}