using AutoMapper;
using FlowersShop.BLL.DTO;
using FlowersShop.BLL.Interfaces;
using FlowersShop.DAL.Entities;
using FlowersShop.WEB.Models;
using FlowersShop.WEB.Models.Additional;
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
        ICategoryService categoryService;

        public int pageSize = 4;
        public CommoditiesController(ICommoditiesService srv, ICategoryService crv)
        {
            commoditiesService = srv;
            categoryService = crv;
        }

        public ViewResult Index(int page = 1)
        {
            IEnumerable<CommodityDTO> commodDtos = commoditiesService.GetCommodities()
                    .OrderBy(item => item.id_Commodities)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize);
            Mapper.Initialize(cfg => cfg.CreateMap<CommodityDTO, CommodityViewModel>());
            var commodity = Mapper.Map<IEnumerable<CommodityDTO>, List<CommodityViewModel>>(commodDtos);


            CommoditiesFilter model = new CommoditiesFilter
            {
                Commodities = commodity.OrderBy(p => p.Price),

                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = commoditiesService.GetCommoditiesQuantity()
                },
            };

            return View(model);
        }



        public ActionResult Details(int id)
        {
            var commodity = commoditiesService.GetCommodity(id);
            return View(commodity);
        }

        public ActionResult GetBouquets()
        {
            IEnumerable<CommodityDTO> commodDtos = commoditiesService.GetCommodities();
            Mapper.Initialize(cfg => cfg.CreateMap<CommodityDTO, CommodityViewModel>());
            var commodity = Mapper.Map<IEnumerable<CommodityDTO>, List<CommodityViewModel>>(commodDtos);

            return View(commodity.Where(p => p.IsHandMade.Equals(false) && p.Title.Equals("Bouquets")).OrderBy(p => p.Price));
        }

        public ActionResult GetBaskets()
        {
            IEnumerable<CommodityDTO> commodDtos = commoditiesService.GetCommodities();
            Mapper.Initialize(cfg => cfg.CreateMap<CommodityDTO, CommodityViewModel>());
            var commodity = Mapper.Map<IEnumerable<CommodityDTO>, List<CommodityViewModel>>(commodDtos);

            return View(commodity.Where(p => p.IsHandMade.Equals(false) && p.Title.Equals("Baskets")).OrderBy(p => p.Price));
        }

        public ActionResult GetCompositions()
        {
            IEnumerable<CommodityDTO> commodDtos = commoditiesService.GetCommodities();
            Mapper.Initialize(cfg => cfg.CreateMap<CommodityDTO, CommodityViewModel>());
            var commodity = Mapper.Map<IEnumerable<CommodityDTO>, List<CommodityViewModel>>(commodDtos);

            return View(commodity.Where(p => p.IsHandMade.Equals(false) && p.Title.Equals("Composition")).OrderBy(p => p.Price));
        }

        public ActionResult GetMonoBouquets()
        {
            IEnumerable<CommodityDTO> commodDtos = commoditiesService.GetCommodities();
            Mapper.Initialize(cfg => cfg.CreateMap<CommodityDTO, CommodityViewModel>());
            var commodity = Mapper.Map<IEnumerable<CommodityDTO>, List<CommodityViewModel>>(commodDtos);

            return View(commodity.Where(p => p.IsHandMade.Equals(false) && p.Title.Equals("Mono Bouquets")).OrderBy(p => p.Price));
        }
    }
}