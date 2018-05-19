using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication7.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            System.Diagnostics.Trace.WriteLine("Home Page Visited");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Home page - Niraj Athawale";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "You reach me on:";

            return View();
        }
    }
}