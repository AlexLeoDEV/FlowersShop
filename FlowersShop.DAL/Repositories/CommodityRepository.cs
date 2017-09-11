namespace FlowersShop.DAL.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using FlowersShop.DAL.EF;
    using FlowersShop.DAL.Entities;
    using FlowersShop.DAL.Interfaces;

    public class CommodityRepository : IRepository<CommoditiesEntity>
    {
        private FlowersShopEntities _db;

        public CommodityRepository(FlowersShopEntities context)
        {
            _db = context;
        }

        public void Create(CommoditiesEntity item)
        {
            _db.Commodities.Add(item);
        }

        public void Delete(int id)
        {
            CommoditiesEntity commodity = _db.Commodities.Find(id);

            if (commodity != null)
            {
                _db.Commodities.Remove(commodity);
            }
        }

        public CommoditiesEntity Get(int id)
        {
            return _db.Commodities.Find(id);
        }

        public IEnumerable<CommoditiesEntity> GetAll()
        {
            return _db.Commodities.ToList();
        }

        public void Update(CommoditiesEntity item)
        {
            _db.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
