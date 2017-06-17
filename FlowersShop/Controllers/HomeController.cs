using FlowersShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace FlowersShop.Controllers
{
    public class HomeController : Controller
    {
        private FlowersShopModelContext db = new FlowersShopModelContext();

        public ActionResult Services()
        {
            ViewBag.Message = "Our services";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About our company";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Our contacts";

            return View();
        }

        // GET: Cities
        public ActionResult Delivering()
        {
            IEnumerable<City> cities = db.City;
            ViewBag.City = cities;
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}