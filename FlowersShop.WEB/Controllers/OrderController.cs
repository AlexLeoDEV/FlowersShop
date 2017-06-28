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
        IClientService clientService;
        public OrderController(IOrderService orv, ICommoditiesService csrv, IClientService clisrv)
        {
            orderService = orv;
            commoditiesService = csrv;
            clientService = clisrv;
        }

        public ActionResult Index()
        {
            IEnumerable<OrderDTO> orderDtos = orderService.GetOrders();
            Mapper.Initialize(cfg => cfg.CreateMap<OrderDTO, OrderViewModel>());
            var order = Mapper.Map<IEnumerable<OrderDTO>, List<OrderViewModel>>(orderDtos);

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
                id_Commodities = commodity.id_Commodities,
                Quantity = 1,
                FullPrice = commodity.Price,
                Receiver = "Enter your receiver name",
                Address = "Enter address of your receiver"
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Buy([Bind(Include = "id_Order,id_Commodities,OrderTime,Quantity,FullPrice,id_Client,Receiver,Address")] OrderDTO order)
        {
            order.OrderTime = DateTime.Now;
            orderService.Create(order);
            return RedirectToAction("Index");
        }
    }
}