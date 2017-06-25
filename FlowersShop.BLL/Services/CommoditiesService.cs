using FlowersShop.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowersShop.BLL.DTO;
using FlowersShop.DAL.Interfaces;
using AutoMapper;
using FlowersShop.DAL.Entities;
using FlowersShop.BLL.Infrastructure;
using System.Web.Mvc;

namespace FlowersShop.BLL.Services
{
    public class CommoditiesService : ICommoditiesService
    {
        public IUnitOfWork Database { get; set; }

        public CommoditiesService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public void Create(CommodityDTO commodity)
        {
            Database.Commodities.Create(new Commodities
            { id_Commodities = commodity.id_Commodities,
                Title = commodity.Title,
                Description = commodity.Description,
                Colour = commodity.Colour,
                id_Category = commodity.id_Category,
                IsHandMade = commodity.IsHandMade,
                Price = commodity.Price,
                Preferences = commodity.Preferences,
                image = commodity.image
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

        public IEnumerable<CommodityDTO> GetCommodities()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Commodities, CommodityDTO>());
            return Mapper.Map<IEnumerable<Commodities>, List<CommodityDTO>>(Database.Commodities.GetAll());
        }

        public IEnumerable<CommodityDTO> GetNotHandMadeCommodities()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Commodities, CommodityDTO>());
            var res  = Mapper.Map<IEnumerable<Commodities>, List<CommodityDTO>>(Database.Commodities.GetAll());

            var rest = from r in res
                       where r.IsHandMade.Equals(false)
                       select r;

            return rest;
        }

        public CommodityDTO GetCommodity(int? id)
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
            Mapper.Initialize(cfg => cfg.CreateMap<Commodities, CommodityDTO>());
            return Mapper.Map<Commodities, CommodityDTO>(com);
        }

        public int GetCommoditiesQuantity()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Commodities, CommodityDTO>());
            var quantity = Mapper.Map<IEnumerable<Commodities>, List<CommodityDTO>>(Database.Commodities.GetAll());
            return quantity.Count;
        }
        public SelectList GetListCategories()
        {
            SelectList categories = new SelectList(Database.Categories.GetAll(), "id_Category", "Title");
            return categories;
        }

        public void Update(CommodityDTO commodity)
        {
            Database.Commodities.Update(new Commodities
            {
                id_Commodities = commodity.id_Commodities,
                Title = commodity.Title,
                Description = commodity.Description,
                Colour = commodity.Colour,
                id_Category = commodity.id_Category,
                IsHandMade = commodity.IsHandMade,
                Price = commodity.Price,
                Preferences = commodity.Preferences,
                image = commodity.image
            });
            Database.Save();
        }
    }
}
