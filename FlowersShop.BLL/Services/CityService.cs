using FlowersShop.BLL.Interfaces;
using FlowersShop.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowersShop.BLL.DTO;
using FlowersShop.DAL.Entities;
using FlowersShop.BLL.Infrastructure;
using AutoMapper;
using System.Web.Mvc;

namespace FlowersShop.BLL.Services
{
    public class CityService : ICityService
    {
        IUnitOfWork Database { get; set; }
        public CityService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public CityDTO GetCity(int? id)
        {
            if (id == null)
            {
                throw new ValidationException("Commodity id was not set properly", "");
            }

            var cit = Database.Cities.Get(id.Value);

            if (cit == null)
            {
                throw new ValidationException("Commodity id was not found", "");
            }
            Mapper.Initialize(cfg => cfg.CreateMap<City, CityDTO>());
            return Mapper.Map<City, CityDTO>(cit);
        }

        public IEnumerable<CityDTO> GetCities()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<City, CityDTO>());
            return Mapper.Map<IEnumerable<City>, List<CityDTO>>(Database.Cities.GetAll());
        }

        public void Create(CityDTO city)
        {
            Database.Cities.Create(new City
            {
                id_City = city.id_City,
                Title = city.Title,
                id_Client = city.id_Client,
                Price = city.Price
            });
            Database.Save();
        }

        public void Delete(int id)
        {
            Database.Cities.Delete(id);
            Database.Save();
        }

        public void Update(CityDTO city)
        {
            Database.Cities.Update(new City
            {
                id_City = city.id_City,
                Title = city.Title,
                id_Client = city.id_Client,
                Price = city.Price
            });
            Database.Save();
        }

        public void Dispose()
        {
            Database.Dispose();
        }

        public IEnumerable<string> GetCityName()
        {
            var cit = Database.Cities.GetAll();
            List<string> citTitle = new List<string>();
            foreach (var item in cit)
            {
                citTitle.Add(item.Title);
            }
            return citTitle;
        }
    }
}
