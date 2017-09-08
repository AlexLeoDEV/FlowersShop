namespace FlowersShop.BLL.Services
{
    using FlowersShop.BLL.Interfaces;
    using System.Collections.Generic;
    using FlowersShop.BLL.DTO;
    using FlowersShop.DAL.Interfaces;
    using FlowersShop.DAL.Entities;
    using AutoMapper;
    using FlowersShop.BLL.Infrastructure;

    public class CategoryService : ICategoryService
    {
        public IUnitOfWork Database { get; set; }

        public CategoryService(IUnitOfWork uow)
        {
            Database = uow;
        }
        public void Create(CategoryDto category)
        {
            Database.Categories.Create(new CategoryEntity
            {
                Id = category.Id,
                Name = category.Name
            });

            Database.Save();
        }

        public void Delete(int id)
        {
            Database.Categories.Delete(id);
            Database.Save();
        }

        public void Dispose()
        {
            Database.Dispose();
        }

        public IEnumerable<CategoryDto> GetCategories()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<CategoryEntity, CategoryDto>());
            return Mapper.Map<IEnumerable<CategoryEntity>, List<CategoryDto>>(Database.Categories.GetAll());
        }

        public CategoryDto GetCategory(int? id)
        {
            if (id == null)
            {
                throw new ValidationException("Commodity id was not set properly", "");
            }

            var cat = Database.Categories.Get(id.Value);

            if (cat == null)
            {
                throw new ValidationException("Commodity id was not found", "");
            }

            Mapper.Initialize(cfg => cfg.CreateMap<CategoryEntity, CategoryDto>());
            return Mapper.Map<CategoryEntity, CategoryDto>(cat);
        }

        public IEnumerable<string> GetCategoryName()
        {
            var cat = Database.Categories.GetAll();
            var catTitle = new List<string>();

            foreach (var item in cat)
            {
                catTitle.Add(item.Name);
            }

            return catTitle;
        }

        public void Update(CategoryDto category)
        {
            Database.Categories.Update(new CategoryEntity
            {
                Id = category.Id,
                Name = category.Name
            });

            Database.Save();
        }
    }
}
