﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "APSmini";

            return View();
        }

        [HttpPost]
        public ActionResult Index(string textUserID, string textPassword)
        {

            return View();
        }
    }
}
