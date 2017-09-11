namespace FlowersShop.BLL.Services
{
    using FlowersShop.BLL.Interfaces;
    using FlowersShop.DAL.Interfaces;
    using System.Collections.Generic;
    using FlowersShop.BLL.DTO;
    using FlowersShop.DAL.Entities;
    using FlowersShop.BLL.Infrastructure;
    using AutoMapper;

    public class CityService : ICityService
    {
        public IUnitOfWork Database { get; set; }

        public CityService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public CityDto GetCity(int? id)
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
            Mapper.Initialize(cfg => cfg.CreateMap<CityEntity, CityDto>());
            return Mapper.Map<CityEntity, CityDto>(cit);
        }

        public IEnumerable<CityDto> GetCities()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<CityEntity, CityDto>());
            return Mapper.Map<IEnumerable<CityEntity>, List<CityDto>>(Database.Cities.GetAll());
        }

        public void Create(CityDto city)
        {
            Database.Cities.Create(new CityEntity
            {
                Id = city.Id,
                Name = city.Name,
                DeliveryPrice = city.DeliveryPrice
            });

            Database.Save();
        }

        public void Delete(int id)
        {
            Database.Cities.Delete(id);
            Database.Save();
        }

        public void Update(CityDto city)
        {
            Database.Cities.Update(new CityEntity
            {
                Id = city.Id,
                Name = city.Name,
                DeliveryPrice = city.DeliveryPrice
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
            var citTitle = new List<string>();

            foreach (var item in cit)
            {
                citTitle.Add(item.Name);
            }
            return citTitle;
        }
    }
}
