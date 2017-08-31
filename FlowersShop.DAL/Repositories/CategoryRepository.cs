namespace FlowersShop.DAL.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using FlowersShop.DAL.EF;
    using FlowersShop.DAL.Entities;
    using FlowersShop.DAL.Interfaces;

    public class CategoryRepository : IRepository<CategoryEntity>
    {
        private FlowersShopEntities _db;

        public CategoryRepository(FlowersShopEntities context)
        {
            _db = context;
        }

        public void Create(CategoryEntity item)
        {
            _db.Categories.Add(item);
        }

        public void Delete(int id)
        {
            CategoryEntity category = _db.Categories.Find(id);

            if (category != null)
            {
                _db.Categories.Remove(category);
            }
        }

        public CategoryEntity Get(int id)
        {
            return _db.Categories.Find(id);
        }

        public IEnumerable<CategoryEntity> GetAll()
        {
            return _db.Categories.ToList();
        }

        public void Update(CategoryEntity item)
        {
            _db.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
