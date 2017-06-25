using FlowersShop.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowersShop.BLL.DTO;
using AutoMapper;
using FlowersShop.DAL.Entities;
using FlowersShop.DAL.Interfaces;
using System.Web.Mvc;

namespace FlowersShop.BLL.Services
{
    public class CommoditiesByCategoryService : ICommoditiesByCategory
    {
        public IUnitOfWork Database { get; set; }

        public CommoditiesByCategoryService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public IEnumerable<CommoditiesByCategoryDTO> GetBouquets()
        {
            Mapper.Initialize(cfg => 
            {
                cfg.CreateMap<Category, CategoryDTO>();
                cfg.CreateMap<Commodities, CommodityDTO>();
            });

            var commodities = Mapper.Map<IEnumerable<Commodities>, List<CommodityDTO>>(Database.Commodities.GetAll());
            var categories = Mapper.Map<IEnumerable<Category>, List<CategoryDTO>>(Database.Categories.GetAll());


            var commod = from c in categories
                         join cm in commodities on c.id_Category equals cm.id_Category
                         where cm.IsHandMade.Equals(false) && c.Title.Equals("Bouquet")
                         select new CommoditiesByCategoryDTO
                         {
                             CommodityDTO = cm
                         };
            var res = Mapper.Map<IEnumerable<CommoditiesByCategoryDTO>>(commod);

            return res.OrderBy(c => c.CommodityDTO.Price);
        }

        public IEnumerable<CommoditiesByCategoryDTO> GetBaskets()
        {
            Mapper.Initialize(cfg => 
            {
                cfg.CreateMap<Category, CategoryDTO>();
                cfg.CreateMap<Commodities, CommodityDTO>();
            });

            var commodities = Mapper.Map<IEnumerable<Commodities>, List<CommodityDTO>>(Database.Commodities.GetAll());
            var categories = Mapper.Map<IEnumerable<Category>, List<CategoryDTO>>(Database.Categories.GetAll());


            var commod = from c in categories
                         join cm in commodities on c.id_Category equals cm.id_Category
                         where cm.IsHandMade.Equals(false) && c.Title.Equals("Flower basket")
                         select new CommoditiesByCategoryDTO
                         {
                             CommodityDTO = cm
                         };
            var res = Mapper.Map<IEnumerable<CommoditiesByCategoryDTO>>(commod);

            return res.OrderBy(c => c.CommodityDTO.Price);
        }

        public IEnumerable<CommoditiesByCategoryDTO> GetMonoBouquets()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<Category, CategoryDTO>();
                cfg.CreateMap<Commodities, CommodityDTO>();
            });

            var commodities = Mapper.Map<IEnumerable<Commodities>, List<CommodityDTO>>(Database.Commodities.GetAll());
            var categories = Mapper.Map<IEnumerable<Category>, List<CategoryDTO>>(Database.Categories.GetAll());


            var commod = from c in categories
                         join cm in commodities on c.id_Category equals cm.id_Category
                         where cm.IsHandMade.Equals(false) && c.Title.Equals("Mono bouquet")
                         select new CommoditiesByCategoryDTO
                         {
                             CommodityDTO = cm
                         };
            var res = Mapper.Map<IEnumerable<CommoditiesByCategoryDTO>>(commod);

            return res.OrderBy(c => c.CommodityDTO.Price);
        }

        public IEnumerable<CommoditiesByCategoryDTO> GetCompositions()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<Category, CategoryDTO>();
                cfg.CreateMap<Commodities, CommodityDTO>();
            });

            var commodities = Mapper.Map<IEnumerable<Commodities>, List<CommodityDTO>>(Database.Commodities.GetAll());
            var categories = Mapper.Map<IEnumerable<Category>, List<CategoryDTO>>(Database.Categories.GetAll());


            var commod = from c in categories
                         join cm in commodities on c.id_Category equals cm.id_Category
                         where cm.IsHandMade.Equals(false) && c.Title.Equals("Flower composition")
                         select new CommoditiesByCategoryDTO
                         {
                             CommodityDTO = cm
                         };
            var res = Mapper.Map<IEnumerable<CommoditiesByCategoryDTO>>(commod);

            return res.OrderBy(c => c.CommodityDTO.Price);
        }

        public IEnumerable<CommoditiesByCategoryDTO> GetDreamBouquet()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<Category, CategoryDTO>();
                cfg.CreateMap<Commodities, CommodityDTO>();
            });

            var commodities = Mapper.Map<IEnumerable<Commodities>, List<CommodityDTO>>(Database.Commodities.GetAll());
            var categories = Mapper.Map<IEnumerable<Category>, List<CategoryDTO>>(Database.Categories.GetAll());


            var commod = from c in categories
                         join cm in commodities on c.id_Category equals cm.id_Category
                         where cm.IsHandMade.Equals(true)
                         select new CommoditiesByCategoryDTO
                         {
                             CommodityDTO = cm
                         };
            var res = Mapper.Map<IEnumerable<CommoditiesByCategoryDTO>>(commod);

            return res.OrderBy(c => c.CommodityDTO.Price);
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
