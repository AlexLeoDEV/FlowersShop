namespace FlowersShop.BLL.Services
{
    using FlowersShop.BLL.Interfaces;
    using System.Collections.Generic;
    using FlowersShop.BLL.DTO;
    using FlowersShop.DAL.Interfaces;
    using AutoMapper;
    using FlowersShop.DAL.Entities;
    using FlowersShop.BLL.Infrastructure;

    public class CommoditiesService : ICommoditiesService
    {
        public IUnitOfWork Database { get; set; }

        public CommoditiesService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public void Create(CommodityDto commodity)
        {
            Database.Commodities.Create(new CommoditiesEntity
            {
                Id = commodity.Id,
                Name = commodity.Name,
                Description = commodity.Description,
                Colour = commodity.Colour,
                CategoryId = commodity.CategoryId,
                IsHandMade = commodity.IsHandMade,
                Price = commodity.Price,
                Preferences = commodity.Preferences,
                ImagePath = commodity.ImagePath
            });

            Database.Save();
        }

        public void Delete(int id)
        {
            Database.Commodities.Delete(id);
            Database.Save();
        }

        public void Dispose()
        {
            Database.Dispose();
        }

        public IEnumerable<CommodityDto> GetCommodities()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<CommoditiesEntity, CommodityDto>());
            return Mapper.Map<IEnumerable<CommoditiesEntity>, List<CommodityDto>>(Database.Commodities.GetAll());
        }

        public CommodityDto GetCommodity(int? id)
        {
            if (id == null)
            {
                throw new ValidationException("Commodity id was not set properly", "");
            }

            var com = Database.Commodities.Get(id.Value);

            if (com == null)
            {
                throw new ValidationException("Commodity id was not found","");
            }

            Mapper.Initialize(cfg => cfg.CreateMap<CommoditiesEntity, CommodityDto>());
            return Mapper.Map<CommoditiesEntity, CommodityDto>(com);
        }

        public int GetCommoditiesQuantity()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<CommoditiesEntity, CommodityDto>());
            var quantity = Mapper.Map<IEnumerable<CommoditiesEntity>, List<CommodityDto>>(Database.Commodities.GetAll());
            return quantity.Count;
        }

        public void Update(CommodityDto commodity)
        {
            Database.Commodities.Update(new CommoditiesEntity
            {
                Id = commodity.Id,
                Name = commodity.Name,
                Description = commodity.Description,
                Colour = commodity.Colour,
                CategoryId = commodity.CategoryId,
                IsHandMade = commodity.IsHandMade,
                Price = commodity.Price,
                Preferences = commodity.Preferences,
                ImagePath = commodity.ImagePath
            });

            Database.Save();
        }
    }
}
