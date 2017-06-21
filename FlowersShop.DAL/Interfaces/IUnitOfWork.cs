using FlowersShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowersShop.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Commodities> Commodities { get; }
        IRepository<Category> Categories { get; }
        IRepository<Client> Clients { get; }
        IRepository<City> Cities { get; }
        IRepository<Order> Orders { get; }
        void Save();
    }
}
