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
    public class CommoditiesByCategoryController : Controller
    {
        ICommoditiesByCategory commoditiesByCategory;
        public CommoditiesByCategoryController(ICommoditiesByCategory cbc)
        {
            commoditiesByCategory = cbc;
        }

        public ActionResult GetBouquets()
        {
            IEnumerable<CommoditiesByCategoryDto> commodByCatDtos = commoditiesByCategory.GetBouquets();            

            return View(commodByCatDtos);
        }

        public ActionResult GetBaskets()
        {
            IEnumerable<CommoditiesByCategoryDto> commodByCatDtos = commoditiesByCategory.GetBaskets();

            return View(commodByCatDtos);
        }

        public ActionResult GetMonoBouquets()
        {
            IEnumerable<CommoditiesByCategoryDto> commodByCatDtos = commoditiesByCategory.GetMonoBouquets();

            return View(commodByCatDtos);
        }

        public ActionResult GetCompositions()
        {
            IEnumerable<CommoditiesByCategoryDto> commodByCatDtos = commoditiesByCategory.GetCompositions();

            return View(commodByCatDtos);
        }

        public ActionResult GetDreamBouquet()
        {
            IEnumerable<CommoditiesByCategoryDto> commodByCatDtos = commoditiesByCategory.GetDreamBouquet();

            return View(commodByCatDtos);
        }
    }
}