﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web2.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        // Luôn chạy File Index đầu tiên.
        public ActionResult Index()
        {           
            return View();
        }

     
    }
}