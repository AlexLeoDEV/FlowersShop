using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FlowersShop.Models;
using FlowersShop.Logic;

namespace FlowersShop.Controllers
{
    public class CommoditiesController : Controller
    {
        private FlowersShopModelContext db = new FlowersShopModelContext();

        public ActionResult Index(string selectedTitle, string selectedColour, string selectedPriceSort, string selectedCategory)
        {
            var commodities = from c in db.Commodities
                              where c.IsHandMade.Equals(false) && c.Price <= 500
                              select c;

            commodities = commodities.OrderBy(p => p.Price);

            commodities = Services.CheckFilter(selectedTitle) == true ?
                commodities.Where(c => c.Title.Equals(selectedTitle)) : commodities;

            commodities = Services.CheckFilter(selectedColour) == true ?
                commodities.Where(c => c.Colour.Equals(selectedColour)) : commodities;

            commodities = Services.CheckFilter(selectedColour) == true ?
                commodities.OrderByDescending(c => c.Price) : commodities;

            commodities = Services.CheckFilter(selectedCategory) == true ?
                commodities.Where(c => c.Preferences.Equals(selectedCategory)) : commodities;

            return View(commodities);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Commodities commodities = db.Commodities.Find(id);
            if (commodities == null)
            {
                return HttpNotFound();
            }
            return View(commodities);
        }        

        public ActionResult GetBouquets()
        {
            var result = from b in db.Category
                         join com in db.Commodities on b.id_Category equals com.id_Category
                         where com.IsHandMade.Equals(false) && b.Title.Equals("Bouquet")
                         select new ModelsInfoView { Category = b, Commodities = com };
                       
            return View(result);
        }

        public ActionResult GetBaskets()
        {
            var result = from b in db.Category
                         join com in db.Commodities on b.id_Category equals com.id_Category
                         where b.id_Category.Equals(4)
                         select new ModelsInfoView { Category = b, Commodities = com };

            return View(result);
        }

        public ActionResult GetMonoBouquets()
        {
            var result = from b in db.Category
                         join com in db.Commodities on b.id_Category equals com.id_Category
                         where b.id_Category.Equals(2)
                         select new ModelsInfoView { Category = b, Commodities = com };

            return View(result);
        }

        public ActionResult GetCompositions()
        {
            var result = from b in db.Category
                         join com in db.Commodities on b.id_Category equals com.id_Category
                         where b.id_Category.Equals(1)
                         select new ModelsInfoView { Category = b, Commodities = com };

            return View(result);
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
