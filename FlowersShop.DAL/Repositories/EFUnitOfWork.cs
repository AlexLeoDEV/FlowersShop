namespace FlowersShop.DAL.Repositories
{
    using System;
    using FlowersShop.DAL.EF;
    using FlowersShop.DAL.Entities;
    using FlowersShop.DAL.Interfaces;

    public class EFUnitOFWork : IUnitOfWork
    {
        private FlowersShopEntities _db;
        private CommodityRepository _commodityRepository;
        private CategoryRepository _categoryRepository;
        private ClientRepository _clientRepository;
        private OrderRepository _orderRepository;
        private CityRepository _cityRepository;

        private bool _disposed = false;

        public EFUnitOFWork()
        {
            _db = new FlowersShopEntities();
        }

        public IRepository<CommoditiesEntity> Commodities
        {
            get
            {
                if (_commodityRepository == null)
                {
                    _commodityRepository = new CommodityRepository(_db);
                }

                return _commodityRepository;
            }
        }

        public IRepository<CategoryEntity> Categories
        {
            get
            {
                if (_categoryRepository == null)
                {
                    _categoryRepository = new CategoryRepository(_db);
                }

                return _categoryRepository;
            }
        }

        public IRepository<ClientEntity> Clients
        {
            get
            {
                if (_clientRepository == null)
                {
                    _clientRepository = new ClientRepository(_db);
                }

                return _clientRepository;
            }
        }

        public IRepository<CityEntity> Cities
        {
            get
            {
                if (_cityRepository == null)
                {
                    _cityRepository = new CityRepository(_db);
                }

                return _cityRepository;
            }
        }

        public IRepository<OrderEntity> Orders
        {
            get
            {
                if (_orderRepository == null)
                {
                    _orderRepository = new OrderRepository(_db);
                }

                return _orderRepository;
            }
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }

                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
