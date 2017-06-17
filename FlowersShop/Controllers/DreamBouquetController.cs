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
    public class DreamBouquetController : Controller
    {
        private FlowersShopModelContext db = new FlowersShopModelContext();

        // GET: DreamBouquet
        public ActionResult Index()
        {
            var commodities = from c in db.Commodities
                              where c.IsHandMade.Equals(true)
                              select c;

            commodities = commodities.OrderBy(p => p.Price);

            return View(commodities);
        }

        // GET: DreamBouquet/Details/5
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
