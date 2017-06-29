using AutoMapper;
using FlowersShop.BLL.DTO;
using FlowersShop.BLL.Interfaces;
using FlowersShop.DAL.Entities;
using FlowersShop.WEB.Code;
using FlowersShop.WEB.Models;
using FlowersShop.WEB.Models.Additional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace FlowersShop.WEB.Controllers
{

    public class CommoditiesController : Controller
    {
        ICommoditiesService commoditiesService;

        public int pageSize = 8;

        public CommoditiesController(ICommoditiesService srv)
        {
            commoditiesService = srv;
        }

        public CommoditiesController()
        {

        }

        public ViewResult Index(string selectedColour, int page = 1)
        {
            IEnumerable<CommodityDTO> commodDtos = commoditiesService.GetCommodities();                 
            Mapper.Initialize(cfg => cfg.CreateMap<CommodityDTO, CommodityViewModel>());
            var commodity = Mapper.Map<IEnumerable<CommodityDTO>, List<CommodityViewModel>>(commodDtos);
            IEnumerable<CommodityViewModel> commoditiesList;

            commoditiesList = FilterService.CheckFilter(selectedColour) == true ?
                commodity.Where(c => c.Colour.Equals(selectedColour)) : commodity;

            CommoditiesFilter model = new CommoditiesFilter
            {
                Commodities = commoditiesList.OrderBy(item => item.id_Commodities)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize),

                PgInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = commoditiesService.GetCommoditiesQuantity()
                },
            };

            return View(model);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var commodity = commoditiesService.GetCommodity(id);
            return View(commodity);
        }                
    }
}