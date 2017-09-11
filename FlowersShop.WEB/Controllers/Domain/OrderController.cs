using AutoMapper;
using FlowersShop.BLL.DTO;
using FlowersShop.BLL.Interfaces;
using FlowersShop.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace FlowersShop.WEB.Controllers
{
    public class OrderController : Controller
    {
        IOrderService orderService;
        ICommoditiesService commoditiesService;
        public OrderController(IOrderService orv, ICommoditiesService csrv)
        {
            orderService = orv;
            commoditiesService = csrv;
        }

        public ActionResult Index()
        {
            IEnumerable<OrderDto> orderDtos = orderService.GetOrders();
            Mapper.Initialize(cfg => cfg.CreateMap<OrderDto, OrderViewModel>());
            var order = Mapper.Map<IEnumerable<OrderDto>, List<OrderViewModel>>(orderDtos);

            return View(order);
        }

        public ActionResult Buy(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var commodity = commoditiesService.GetCommodity(id);

            OrderViewModel model = new OrderViewModel
            {
                CommodityId = commodity.Id,
                Quantity = 1,
                FullPrice = commodity.Price
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Buy(OrderDto order)
        {
            order.ClientId = 1;
            order.OrderTime = DateTime.Now;
            orderService.Create(order);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var order = orderService.GetOrder(id);
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
            var order = orderService.GetOrder(id);
            orderService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}