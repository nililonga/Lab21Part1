using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab21RegistrationPage.Controllers
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
        //this will go to my registration view
        public ActionResult Registration()
        {
            
            return View();
        }
        public ActionResult Welcome (string INPUT = null)
        {
            ViewBag.info = INPUT;
            return View();
        }
    }
}