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
        public ActionResult Menu(Item data)
        {
            CoffeeShopDBEntities ORM = new CoffeeShopDBEntities();
            List<Item> items = ORM.Items.ToList();
            ViewBag.Items = items;
            ViewBag.Items = ORM.Items;
            return View();
        }
        public ActionResult Add(int id)
        {
            CoffeeShopDBEntities ORM = new CoffeeShopDBEntities();
            //check if cart object already exists
            if (Session["Cart"] == null)
            {
                //if it doesn't, make new list of books
                List<Item> cart = new List<Item>();
                //add this book to it
                cart.Add((from x in ORM.Items where x.ID == id select x).Single());
                //add the list to the session
                Session.Add("Cart", cart);
            }
            else
            {
                //if it does exist, get the list
                List<Item> cart = (List<Item>)(Session["Cart"]);
                //add this book to it
                cart.Add((from x in ORM.Items where x.ID == id select x).Single());
                //add it back to the session
                //Session["Cart"] = cart;
            }
            return View();
        }

    }
}