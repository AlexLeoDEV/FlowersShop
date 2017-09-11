namespace FlowersShop.DAL.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using FlowersShop.DAL.EF;
    using FlowersShop.DAL.Entities;
    using FlowersShop.DAL.Interfaces;

    public class OrderRepository : IRepository<OrderEntity>
    {
        private FlowersShopEntities _db;

        public OrderRepository(FlowersShopEntities context)
        {
            _db = context;
        }

        public void Create(OrderEntity item)
        {
            _db.Orders.Add(item);
        }

        public void Delete(int id)
        {
            OrderEntity order = _db.Orders.Find(id);

            if (order != null)
            {
                _db.Orders.Remove(order);
            }
        }

        public OrderEntity Get(int id)
        {
            return _db.Orders.Find(id);
        }

        public IEnumerable<OrderEntity> GetAll()
        {
            return _db.Orders.ToList();
        }

        public void Update(OrderEntity item)
        {
            _db.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
