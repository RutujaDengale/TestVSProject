﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Contact1()
        {
            ViewBag.Message = "Your contact page.";

            return null;
        }

        public ActionResult About1()
        {
            ViewBag.Message = "Your contact page.";

            return null;
        }

        public ActionResult About2()
        {
            ViewBag.Message = "Your contact page.";

            return null;
        }

        public ActionResult About3()
        {
            ViewBag.Message = "Your contact page.";

            return null;
        }
    }
}