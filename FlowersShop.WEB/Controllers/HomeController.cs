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
            //Mapper.Initialize(cfg => cfg.CreateMap<CityDTO, CityViewModel>());
            //var cities = Mapper.Map<IEnumerable<CityDTO>, List<CityViewModel>>(cityDtos);

            return View(cityDtos);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}