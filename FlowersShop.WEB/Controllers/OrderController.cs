using AutoMapper;
using FlowersShop.BLL.DTO;
using FlowersShop.BLL.Interfaces;
using FlowersShop.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlowersShop.WEB.Controllers
{
    public class OrderController : Controller
    {
        IOrderService orderService;
        ICommoditiesService commoditiesService;
        IClientService clientService;
        public OrderController(IOrderService orv, ICommoditiesService csr, IClientService clsr)
        {
            orderService = orv;
            commoditiesService = csr;
            clientService = clsr;
        }

        public ActionResult Index()
        {
            IEnumerable<OrderDTO> orderDtos = orderService.GetOrders();
            Mapper.Initialize(cfg => cfg.CreateMap<OrderDTO, OrderViewModel>());
            var order = Mapper.Map<IEnumerable<OrderDTO>, List<OrderViewModel>>(orderDtos);

            return View(order);
        }

        public ActionResult Create(int? id)
        {
            IEnumerable<CommodityDTO> commodDtos = commoditiesService.GetCommodities();
            Mapper.Initialize(cfg => cfg.CreateMap<CommodityDTO, CommodityViewModel>());
            var commodities = Mapper.Map<IEnumerable<CommodityDTO>, List<CommodityViewModel>>(commodDtos);
           
            var com = from c in commodities
                              where c.id_Commodities.Equals(id)
                              select c;

            ViewBag.id_Client = new SelectList(clientService.GetClientName(), "id_Client", "Name");
            ViewBag.id_Commodities = new SelectList(com, "id_Commodities", "Title");
            ViewBag.FullPrice = new SelectList(com, "Price", "Price");
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "id_Order,id_Commodities,OrderTime,Quantity,FullPrice,id_Client,Receiver,Address")] OrderDTO order)
        {
            order.OrderTime = DateTime.Now;
            orderService.Create(order);
            return RedirectToAction("Index");
        }
    }
}