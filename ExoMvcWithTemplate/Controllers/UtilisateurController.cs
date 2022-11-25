using ExoMvcWithTemplate.DTOs;
using ExoMvcWithTemplate.Models;
using ExoMvcWithTemplate.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExoMvcWithTemplate.Controllers
{
    public class UtilisateurController : Controller
    {
        private UtilisateurService service = new UtilisateurService();
        // GET: Utilisateur
        public ActionResult Index(string sortBy, string search,int page=0)
        {
            page = (page < 0) ? 0 : page;//if/else
            int  pageSize = 2;
            int totalPages = 0;

            List<UtilisateurDTO> lst = service.GetAllUser();

            //Pagination
            //if(!page.HasValue) { page = 0; }
              
            if((lst.Count() % pageSize)==0)
            {
                totalPages = lst.Count() / pageSize;
            }
            else
            {
                totalPages = (lst.Count() / pageSize) + 1;
            }
            lst = lst.Skip(pageSize * page).Take(pageSize).ToList();
            ViewBag.TotalPages = totalPages;
            ViewBag.Page = page + 1;
            ViewBag.PreviousPage = page - 1;

            if(lst.Count()<pageSize)
            {
                ViewBag.Next = page;
            }
            else
            {
                ViewBag.Next = page + 1;
            }



            //Filtre
            if(search!=null)
            {
                lst = lst.Where(u => u.UserName.Contains(search)).ToList();
            }

            //Tri
            switch (sortBy)
            {
                case "nameAsc":
                    lst = lst.OrderBy(u => u.UserName).ToList();
                    break;
                case "nameDesc":
                    lst = lst.OrderByDescending(u => u.UserName).ToList();
                    break;
                case null:
                    break;
            }


            return View(lst);
        }
    }
}