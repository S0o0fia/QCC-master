﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Resources;

namespace AspnetMvcDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Home()
        {
            return View();
        }


        [HttpGet]
        public ActionResult MakeChoice()
        {
            return View();
        }

    }
}