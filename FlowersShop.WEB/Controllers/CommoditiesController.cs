using AutoMapper;
using FlowersShop.BLL.DTO;
using FlowersShop.BLL.Interfaces;
using FlowersShop.DAL.Entities;
using FlowersShop.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlowersShop.WEB.Controllers
{
    public class CommoditiesController : Controller
    {
        ICommoditiesService commoditiesService;
        public CommoditiesController(ICommoditiesService srv)
        {
            commoditiesService = srv;
        }

        public ActionResult Index()
        {
            IEnumerable<CommodityDTO> commodDtos = commoditiesService.GetCommodities();
            Mapper.Initialize(cfg => cfg.CreateMap<CommodityDTO, CommodityViewModel>());
            var commodity = Mapper.Map<IEnumerable<CommodityDTO>, List<CommodityViewModel>>(commodDtos);



            return View(commodity);
        }
    }
}