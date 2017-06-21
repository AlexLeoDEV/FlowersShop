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
    public class CityRepository : IRepository<City>
    {
        private FlowersShopContext db;
        public CityRepository(FlowersShopContext context)
        {
            db = context;
        }

        public void Create(City item)
        {
            db.Cities.Add(item);
        }

        public void Delete(int id)
        {
            City City = db.Cities.Find(id);
            if (City != null)
            {
                db.Cities.Remove(City);
            }
        }

        public IEnumerable<City> Find(Func<City, bool> predicate)
        {
            return db.Cities.Where(predicate).ToList();
        }

        public City Get(int id)
        {
            return db.Cities.Find(id);
        }

        public IEnumerable<City> GetAll()
        {
            return db.Cities.ToList();
        }

        public void Update(City item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
