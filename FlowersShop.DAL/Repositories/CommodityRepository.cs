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
    public class CommodityRepository : IRepository<Commodities>
    {
        private FlowersShopContext db;
        public CommodityRepository(FlowersShopContext context)
        {
            db = context;
        }

        public void Create(Commodities item)
        {
            db.Commodities.Add(item);
        }

        public void Delete(int id)
        {
            Commodities Commodity = db.Commodities.Find(id);
            if (Commodity != null)
            {
                db.Commodities.Remove(Commodity);
            }
        }

        public Commodities Get(int id)
        {
            return db.Commodities.Find(id);
        }

        public IEnumerable<Commodities> GetAll()
        {
            return db.Commodities.ToList();
        }

        public void Update(Commodities item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
