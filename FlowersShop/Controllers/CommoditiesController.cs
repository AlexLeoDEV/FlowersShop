using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FlowersShop.Models;

namespace FlowersShop.Controllers
{
    public class CommoditiesController : Controller
    {
        private FlowersShopModelContext db = new FlowersShopModelContext();

        // GET: Commodities
        public ActionResult Index(string selectedTitle, string selectedColour, string selectedPriceSort, string selectedCategory)
        {
            var commodities = from c in db.Commodities
                              where c.IsHandMade.Equals(false) && c.Price <= 500
                              select c;

            commodities = commodities.OrderBy(p => p.Price);

            if (!String.IsNullOrEmpty(selectedTitle))
            {
                if (!selectedTitle.Equals("All"))
                {
                    commodities = commodities.Where(c => c.Title.Equals(selectedTitle));
                }                
            }

            if (!String.IsNullOrEmpty(selectedColour))
            {
                if (!selectedColour.Equals("All"))
                {
                    commodities = commodities.Where(c => c.Colour.Equals(selectedColour));
                }
            }
            if (!String.IsNullOrEmpty(selectedPriceSort))
            {
                if (!selectedPriceSort.Equals("Ascending"))
                {
                    commodities = commodities.OrderByDescending(c => c.Price);
                }
            }
            if (!String.IsNullOrEmpty(selectedCategory))
            {
                if (!selectedCategory.Equals("All"))
                {
                    commodities = commodities.Where(c => c.Preferences.Equals(selectedCategory));
                }
            }

            return View(commodities);
        }

        // GET: Commodities/Details/5
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

        public ActionResult Bouquets()
        {
            var result = from b in db.Category
                         join com in db.Commodities on b.id_Category equals com.id_Category
                         where com.IsHandMade.Equals(false) && b.Title.Equals("Bouquet")
                         select new ModelsInfoView { Category = b, Commodities = com };
                       
            return View(result);
        }

        public ActionResult Baskets()
        {
            var result = from b in db.Category
                         join com in db.Commodities on b.id_Category equals com.id_Category
                         where b.id_Category.Equals(4)
                         select new ModelsInfoView { Category = b, Commodities = com };

            return View(result);
        }

        public ActionResult MonoBouquets()
        {
            var result = from b in db.Category
                         join com in db.Commodities on b.id_Category equals com.id_Category
                         where b.id_Category.Equals(2)
                         select new ModelsInfoView { Category = b, Commodities = com };

            return View(result);
        }

        public ActionResult Compositions()
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
