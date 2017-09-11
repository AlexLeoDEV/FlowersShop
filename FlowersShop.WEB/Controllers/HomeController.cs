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
    public class HomeController : Controller
    {
        ICityService cityService;
        public HomeController(ICityService csrv)
        {
            cityService = csrv;
        }
        public ActionResult Services()
        {
            ViewBag.Message = "Our services";
            return View();
        }

        public ActionResult Delivering()
        {
            var cityDtos = cityService.GetCities();
            Mapper.Initialize(cfg => cfg.CreateMap<CityDto, CityViewModel>());
            var cities = Mapper.Map<IEnumerable<CityDto>, List<CityViewModel>>(cityDtos);

            return View(cities);
        }

        public ActionResult About()
        {
            ViewBag.Message = "About us";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Our contacts";

            return View();
        }
    }
}