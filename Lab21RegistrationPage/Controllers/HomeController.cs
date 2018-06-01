using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab21RegistrationPage.Models;


namespace Lab21RegistrationPage.Controllers
{
    public class HomeController : Controller
    {

        
        public ActionResult Index()
        {
            CoffeeShopDBEntities ORM = new CoffeeShopDBEntities();

            ViewBag.Items = ORM.Items.ToList();
            
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
        public ActionResult Welcome (Item data)
        {

            CoffeeShopDBEntities ORM = new CoffeeShopDBEntities();
            if (ModelState.IsValid)
            {
                ORM.Items.Add(data);
                ORM.SaveChanges();
            }

            ViewBag.info = data.Name;

                            return View();
        }
       
    }
}