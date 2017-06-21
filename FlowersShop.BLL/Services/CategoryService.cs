using FlowersShop.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowersShop.BLL.DTO;
using FlowersShop.DAL.Interfaces;
using FlowersShop.DAL.Entities;
using AutoMapper;
using FlowersShop.BLL.Infrastructure;

namespace FlowersShop.BLL.Services
{
    public class CategoryService : ICategoryService
    {
        IUnitOfWork Database { get; set; }

        public CategoryService(IUnitOfWork uow)
        {
            Database = uow;
        }
        public void Create(CategoryDTO category)
        {
            Database.Categories.Create(new Category
            {
                id_Category = category.id_Category,
                Title = category.Title
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

        public IEnumerable<CategoryDTO> GetCategories()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Category, CategoryDTO>());
            return Mapper.Map<IEnumerable<Category>, List<CategoryDTO>>(Database.Categories.GetAll());
        }

        public CategoryDTO GetCategory(int? id)
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
            Mapper.Initialize(cfg => cfg.CreateMap<Category, CategoryDTO>());
            return Mapper.Map<Category, CategoryDTO>(cat);
        }

        public IEnumerable<string> GetCategoryName()
        {
            var cat = Database.Categories.GetAll();
            List<string> catTitle = new List<string>();
            foreach (var item in cat)
            {
                catTitle.Add(item.Title);
            }
            return catTitle;
        }

        public void Update(CategoryDTO category)
        {
            Database.Categories.Update(new Category
            {
                id_Category = category.id_Category,
                Title = category.Title
            });
            Database.Save();
        }
    }
}
