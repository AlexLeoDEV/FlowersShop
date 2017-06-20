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
    public class OrdersController : Controller
    {
        private FlowersShopModelContext db = new FlowersShopModelContext();

        public ActionResult Index()
        {
            var order = db.Order.Include(o => o.Client).Include(o => o.Commodities);
            return View(order.ToList());
        }

        public ActionResult Create(int id)
        {
            Commodities commodity = db.Commodities.Find(id);
            if (commodity == null)
            {
                return HttpNotFound();
            }
            var commodities = from c in db.Commodities
                              where c.id_Commodities.Equals(id)
                              select c;

            ViewBag.id_Client = new SelectList(db.Client, "id_Client", "Name");
            ViewBag.id_Commodities = new SelectList(commodities, "id_Commodities", "Title");
            ViewBag.FullPrice = new SelectList(commodities, "Price", "Price");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_Order,id_Commodities,OrderTime,Quantity,FullPrice,id_Client,Receiver,Address")] Order order)
        {
            if (ModelState.IsValid)
            {
                order.OrderTime = DateTime.Now;
                db.Order.Add(order);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_Client = new SelectList(db.Client, "id_Client", "Name", order.id_Client);
            ViewBag.id_Commodities = new SelectList(db.Commodities, "id_Commodities", "Title", order.id_Commodities);
            return View(order);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Order.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Order order = db.Order.Find(id);
            db.Order.Remove(order);
            db.SaveChanges();
            return RedirectToAction("Index");
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
