﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _9_DemoRouting.Controllers
{
    public class AccueilController : Controller
    {
        // GET: Accueil
        public ActionResult Index()
        {
           // return View("Home/Index");
            return RedirectToRoute("myRoute/Index");
        }
    }
}