namespace FlowersShop.WEB.Controllers
{
    using AutoMapper;
    using FlowersShop.BLL.DTO;
    using FlowersShop.BLL.Interfaces;
    using FlowersShop.WEB.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        private readonly ICityService _cityService;

        public HomeController(ICityService cityService)
        {
            _cityService = cityService;
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult Delivering()
        {
            var cityDtos = _cityService.GetCities();
            Mapper.Initialize(cfg => cfg.CreateMap<CityDto, CityViewModel>());
            var cities = Mapper.Map<IEnumerable<CityDto>, List<CityViewModel>>(cityDtos);

            return View(cities);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}