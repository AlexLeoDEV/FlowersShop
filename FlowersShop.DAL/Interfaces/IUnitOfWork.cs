namespace FlowersShop.DAL.Interfaces
{
    using System;
    using FlowersShop.DAL.Entities;

    public interface IUnitOfWork : IDisposable
    {
        IRepository<CommoditiesEntity> Commodities { get; }

        IRepository<CategoryEntity> Categories { get; }

        IRepository<ClientEntity> Clients { get; }

        IRepository<CityEntity> Cities { get; }

        IRepository<OrderEntity> Orders { get; }

        void Save();
    }
}
