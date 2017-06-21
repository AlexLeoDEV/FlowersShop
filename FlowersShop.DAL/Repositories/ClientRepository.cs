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
    public class ClientRepository : IRepository<Client>
    {
        private FlowersShopContext db;
        public ClientRepository(FlowersShopContext context)
        {
            db = context;
        }

        public void Create(Client item)
        {
            db.Clients.Add(item);
        }

        public void Delete(int id)
        {
            Client Client = db.Clients.Find(id);
            if (Client != null)
            {
                db.Clients.Remove(Client);
            }
        }

        public IEnumerable<Client> Find(Func<Client, bool> predicate)
        {
            return db.Clients.Where(predicate).ToList();
        }

        public Client Get(int id)
        {
            return db.Clients.Find(id);
        }

        public IEnumerable<Client> GetAll()
        {
            return db.Clients.ToList();
        }

        public void Update(Client item)
        {
            db.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
