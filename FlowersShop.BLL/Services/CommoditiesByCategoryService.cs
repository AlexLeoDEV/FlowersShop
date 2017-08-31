namespace FlowersShop.BLL.Services
{
    using FlowersShop.BLL.Interfaces;
    using System.Collections.Generic;
    using System.Linq;
    using FlowersShop.BLL.DTO;
    using AutoMapper;
    using FlowersShop.DAL.Entities;
    using FlowersShop.DAL.Interfaces;

    public class CommoditiesByCategoryService : ICommoditiesByCategory
    {
        public IUnitOfWork Database { get; set; }

        public CommoditiesByCategoryService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public IEnumerable<CommoditiesByCategoryDto> GetBouquets()
        {
            Mapper.Initialize(cfg => 
            {
                cfg.CreateMap<CategoryEntity, CategoryDto>();
                cfg.CreateMap<CommoditiesEntity, CommodityDto>();
            });

            var commodities = Mapper.Map<IEnumerable<CommoditiesEntity>, List<CommodityDto>>(Database.Commodities.GetAll());
            var categories = Mapper.Map<IEnumerable<CategoryEntity>, List<CategoryDto>>(Database.Categories.GetAll());

            var commod = from c in categories
                         join cm in commodities on c.CategoryId equals cm.CategoryId
                         where cm.IsHandMade.Equals(false) && c.Name.Equals("Bouquet")
                         select new CommoditiesByCategoryDto
                         {
                             CommodityDto = cm
                         };

            var res = Mapper.Map<IEnumerable<CommoditiesByCategoryDto>>(commod);

            return res.OrderBy(c => c.CommodityDto.Price);
        }

        public IEnumerable<CommoditiesByCategoryDto> GetBaskets()
        {
            Mapper.Initialize(cfg => 
            {
                cfg.CreateMap<CategoryEntity, CategoryDto>();
                cfg.CreateMap<CommoditiesEntity, CommodityDto>();
            });

            var commodities = Mapper.Map<IEnumerable<CommoditiesEntity>, List<CommodityDto>>(Database.Commodities.GetAll());
            var categories = Mapper.Map<IEnumerable<CategoryEntity>, List<CategoryDto>>(Database.Categories.GetAll());

            var commod = from c in categories
                         join cm in commodities on c.CategoryId equals cm.CategoryId
                         where cm.IsHandMade.Equals(false) && c.Name.Equals("Flower basket")
                         select new CommoditiesByCategoryDto
                         {
                             CommodityDto = cm
                         };

            var res = Mapper.Map<IEnumerable<CommoditiesByCategoryDto>>(commod);

            return res.OrderBy(c => c.CommodityDto.Price);
        }

        public IEnumerable<CommoditiesByCategoryDto> GetMonoBouquets()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<CategoryEntity, CategoryDto>();
                cfg.CreateMap<CommoditiesEntity, CommodityDto>();
            });

            var commodities = Mapper.Map<IEnumerable<CommoditiesEntity>, List<CommodityDto>>(Database.Commodities.GetAll());
            var categories = Mapper.Map<IEnumerable<CategoryEntity>, List<CategoryDto>>(Database.Categories.GetAll());

            var commod = from c in categories
                         join cm in commodities on c.CategoryId equals cm.CategoryId
                         where cm.IsHandMade.Equals(false) && c.Name.Equals("Mono bouquet")
                         select new CommoditiesByCategoryDto
                         {
                             CommodityDto = cm
                         };

            var res = Mapper.Map<IEnumerable<CommoditiesByCategoryDto>>(commod);

            return res.OrderBy(c => c.CommodityDto.Price);
        }

        public IEnumerable<CommoditiesByCategoryDto> GetCompositions()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<CategoryEntity, CategoryDto>();
                cfg.CreateMap<CommoditiesEntity, CommodityDto>();
            });

            var commodities = Mapper.Map<IEnumerable<CommoditiesEntity>, List<CommodityDto>>(Database.Commodities.GetAll());
            var categories = Mapper.Map<IEnumerable<CategoryEntity>, List<CategoryDto>>(Database.Categories.GetAll());

            var commod = from c in categories
                         join cm in commodities on c.CategoryId equals cm.CategoryId
                         where cm.IsHandMade.Equals(false) && c.Name.Equals("Flower composition")
                         select new CommoditiesByCategoryDto
                         {
                             CommodityDto = cm
                         };

            var res = Mapper.Map<IEnumerable<CommoditiesByCategoryDto>>(commod);

            return res.OrderBy(c => c.CommodityDto.Price);
        }

        public IEnumerable<CommoditiesByCategoryDto> GetDreamBouquet()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<CategoryEntity, CategoryDto>();
                cfg.CreateMap<CommoditiesEntity, CommodityDto>();
            });

            var commodities = Mapper.Map<IEnumerable<CommoditiesEntity>, List<CommodityDto>>(Database.Commodities.GetAll());
            var categories = Mapper.Map<IEnumerable<CategoryEntity>, List<CategoryDto>>(Database.Categories.GetAll());


            var commod = from c in categories
                         join cm in commodities on c.CategoryId equals cm.CategoryId
                         where cm.IsHandMade.Equals(true)
                         select new CommoditiesByCategoryDto
                         {
                             CommodityDto = cm
                         };

            var res = Mapper.Map<IEnumerable<CommoditiesByCategoryDto>>(commod);

            return res.OrderBy(c => c.CommodityDto.Price);
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
