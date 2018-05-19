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
        private const string homePageVisitedMessage = "Home Page Visited";

        public ActionResult Index()
        {
            System.Diagnostics.Trace.WriteLine(homePageVisitedMessage);
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