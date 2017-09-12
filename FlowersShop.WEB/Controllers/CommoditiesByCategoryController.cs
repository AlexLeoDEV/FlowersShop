namespace FlowersShop.WEB.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using AutoMapper;
    using FlowersShop.BLL.DTO;
    using FlowersShop.BLL.Interfaces;
    using FlowersShop.WEB.Models;

    /// <summary>
    /// 
    /// </summary>
    public class CommoditiesByCategoryController : Controller
    {
        private readonly ICommoditiesByCategory _commoditiesByCategory;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="commoditiesByCategory"></param>
        public CommoditiesByCategoryController(ICommoditiesByCategory commoditiesByCategory)
        {
            _commoditiesByCategory = commoditiesByCategory;
        }

        public ActionResult GetBouquets()
        {
            var commoditiesByCategoryDto = _commoditiesByCategory.GetBouquets();
            Mapper.Initialize(cfg => cfg.CreateMap<CommoditiesByCategoryDto, CommodityViewModel>());
            var commoditiesByCategoryList = Mapper.Map<IEnumerable<CommoditiesByCategoryDto>, List<CommodityViewModel>>(commoditiesByCategoryDto);

            return View(commoditiesByCategoryList);
        }

        public ActionResult GetBaskets()
        {
            IEnumerable<CommoditiesByCategoryDto> commodByCatDtos = _commoditiesByCategory.GetBaskets();

            return View(commodByCatDtos);
        }

        public ActionResult GetMonoBouquets()
        {
            IEnumerable<CommoditiesByCategoryDto> commodByCatDtos = _commoditiesByCategory.GetMonoBouquets();

            return View(commodByCatDtos);
        }

        public ActionResult GetCompositions()
        {
            IEnumerable<CommoditiesByCategoryDto> commodByCatDtos = _commoditiesByCategory.GetCompositions();

            return View(commodByCatDtos);
        }

        public ActionResult GetDreamBouquet()
        {
            IEnumerable<CommoditiesByCategoryDto> commodByCatDtos = _commoditiesByCategory.GetDreamBouquet();

            return View(commodByCatDtos);
        }
    }
}