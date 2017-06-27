using FlowersShop.DAL.EF;
using FlowersShop.DAL.Entities;
using FlowersShop.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowersShop.DAL.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        private FlowersShopContext db;
        public CategoryRepository(FlowersShopContext context)
        {
            db = context;
        }

        public void Create(Category item)
        {
            db.Categories.Add(item);
        }

        public void Delete(int id)
        {
            Category Category = db.Categories.Find(id);
            if (Category != null)
            {
                db.Categories.Remove(Category);
            }
        }

        public Category Get(int id)
        {
            return db.Categories.Find(id);
        }

        public IEnumerable<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public void Update(Category item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
