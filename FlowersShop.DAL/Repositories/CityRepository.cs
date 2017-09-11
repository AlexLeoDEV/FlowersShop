namespace FlowersShop.DAL.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using FlowersShop.DAL.EF;
    using FlowersShop.DAL.Entities;
    using FlowersShop.DAL.Interfaces;

    public class CityRepository : IRepository<CityEntity>
    {
        private FlowersShopEntities _db;

        public CityRepository(FlowersShopEntities context)
        {
            _db = context;
        }

        public void Create(CityEntity item)
        {
            _db.Cities.Add(item);
        }

        public void Delete(int id)
        {
            CityEntity city = _db.Cities.Find(id);

            _db.Cities.Remove(city);
        }

        public CityEntity Get(int id)
        {
            return _db.Cities.Find(id);
        }

        public IEnumerable<CityEntity> GetAll()
        {
            return _db.Cities.ToList();
        }

        public void Update(CityEntity item)
        {
            _db.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
