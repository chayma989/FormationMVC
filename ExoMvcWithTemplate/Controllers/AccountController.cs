using ExoMvcWithTemplate.DTOs;
using ExoMvcWithTemplate.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExoMvcWithTemplate.Controllers
{
    public class AccountController : Controller
    {
        private UtilisateurService userService = new UtilisateurService();
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(UtilisateurDTO userDto,HttpPostedFileBase photo)
        {
            if(ModelState.IsValid)
            {
                userDto.Photo = userDto.UserName + Path.GetExtension(photo.FileName);
                photo.SaveAs(Server.MapPath("~/Content/UserImage/") + userDto.Photo);
                userService.Add(userDto);
                return RedirectToAction("Index", "Login");
            }
            return View(userDto);
        }
    }
}