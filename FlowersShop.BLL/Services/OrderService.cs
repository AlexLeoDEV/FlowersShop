namespace FlowersShop.BLL.Services
{
    using FlowersShop.BLL.Interfaces;
    using System;
    using System.Collections.Generic;
    using FlowersShop.BLL.DTO;
    using FlowersShop.DAL.Interfaces;
    using FlowersShop.DAL.Entities;
    using FlowersShop.BLL.Infrastructure;
    using AutoMapper;

    public class OrderService : IOrderService
    {
        public IUnitOfWork Database { get; set; }

        public OrderService(IUnitOfWork uow)
        {
            Database = uow;
        }
        public void Create(OrderDto order)
        {
            Database.Orders.Create(new OrderEntity
            {
                Id = order.OrderId,
                CommodityId = order.CommoditiesId,
                OrderTime = DateTime.Now,
                Quantity = order.Quantity,
                FullPrice = order.Quantity,
                ClientId = order.ClientId,
                Receiver = order.Receiver,
                Address = order.Address
            });
            Database.Save();
        }

        public void Delete(int id)
        {
            Database.Orders.Delete(id);
            Database.Save();
        }

        public void Dispose()
        {
            Database.Dispose();
        }

        public OrderDto GetOrder(int? id)
        {
            if (id == null)
            {
                throw new ValidationException("Commodity id was not set properly", "");
            }

            var cit = Database.Orders.Get(id.Value);

            if (cit == null)
            {
                throw new ValidationException("Commodity id was not found", "");
            }

            Mapper.Initialize(cfg => cfg.CreateMap<OrderEntity, OrderDto>());
            return Mapper.Map<OrderEntity, OrderDto>(cit);
        }

        public IEnumerable<OrderDto> GetOrders()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<OrderEntity, OrderDto>());
            var res = Mapper.Map<IEnumerable<OrderEntity>, List<OrderDto>>(Database.Orders.GetAll());
            return res;
        }

        public void Update(OrderDto order)
        {
            Database.Orders.Update(new OrderEntity
            {
                Id = order.OrderId,
                CommodityId = order.CommoditiesId,
                OrderTime = DateTime.Now,
                Quantity = order.Quantity,
                FullPrice = order.Quantity,
                ClientId = order.ClientId,
                Receiver = order.Receiver,
                Address = order.Address
            });
            Database.Save();
        }
    }
}
