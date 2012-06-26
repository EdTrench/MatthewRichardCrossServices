using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MatthewRichardCrossServices.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to Matthew Ricahrd Cross Services";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
