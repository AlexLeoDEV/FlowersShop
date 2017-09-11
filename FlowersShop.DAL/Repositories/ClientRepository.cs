namespace FlowersShop.DAL.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using FlowersShop.DAL.EF;
    using FlowersShop.DAL.Entities;
    using FlowersShop.DAL.Interfaces;

    public class ClientRepository : IRepository<ClientEntity>
    {
        private FlowersShopEntities _db;

        public ClientRepository(FlowersShopEntities context)
        {
            _db = context;
        }

        public void Create(ClientEntity item)
        {
            _db.Clients.Add(item);
        }

        public void Delete(int id)
        {
            ClientEntity client = _db.Clients.Find(id);

            if (client != null)
            {
                _db.Clients.Remove(client);
            }
        }

        public ClientEntity Get(int id)
        {
            return _db.Clients.Find(id);
        }

        public IEnumerable<ClientEntity> GetAll()
        {
            return _db.Clients.ToList();
        }

        public void Update(ClientEntity item)
        {
            _db.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
