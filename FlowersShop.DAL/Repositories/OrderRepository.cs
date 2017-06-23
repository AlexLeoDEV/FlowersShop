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
    public class OrderRepository : IRepository<Order>
    {
        private FlowersShopContext db;
        public OrderRepository(FlowersShopContext context)
        {
            db = context;
        }

        public void Create(Order item)
        {
            db.Orders.Add(item);
        }

        public void Delete(int id)
        {
            Order Order = db.Orders.Find(id);
            if (Order != null)
            {
                db.Orders.Remove(Order);
            }
        }

        public IEnumerable<Order> Find(Func<Order, bool> predicate)
        {
            return db.Orders.Where(predicate).ToList();
        }

        public Order Get(int id)
        {
            return db.Orders.Find(id);
        }

        public IEnumerable<Order> GetAll()
        {

            return db.Orders.ToList();
        }

        public void Update(Order item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
