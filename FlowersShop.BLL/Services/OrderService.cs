using FlowersShop.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowersShop.BLL.DTO;
using FlowersShop.DAL.Interfaces;
using FlowersShop.DAL.Entities;
using FlowersShop.BLL.Infrastructure;
using AutoMapper;

namespace FlowersShop.BLL.Services
{
    public class OrderService : IOrderService
    {
        IUnitOfWork Database { get; set; }
        public OrderService(IUnitOfWork uow)
        {
            Database = uow;
        }
        public void Create(OrderDTO order)
        {
            Database.Orders.Create(new Order
            {
                id_Order = order.id_Order,
                id_Commodities = order.id_Commodities,
                OrderTime = DateTime.Now,
                Quantity = order.Quantity,
                FullPrice = order.Quantity,
                id_Client = order.id_Client,
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

        public OrderDTO GetOrder(int? id)
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
            Mapper.Initialize(cfg => cfg.CreateMap<Order, OrderDTO>());
            return Mapper.Map<Order, OrderDTO>(cit);
        }

        public IEnumerable<string> GetOrderName()
        {
            var ord = Database.Orders.GetAll();
            List<string> ordTitle = new List<string>();
            foreach (var item in ord)
            {
                ordTitle.Add(item.Receiver);
            }
            return ordTitle;
        }

        public IEnumerable<OrderDTO> GetOrders()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Order, OrderDTO>());
            return Mapper.Map<IEnumerable<Order>, List<OrderDTO>>(Database.Orders.GetAll());
        }

        public void Update(OrderDTO order)
        {
            Database.Orders.Update(new Order
            {
                id_Order = order.id_Order,
                id_Commodities = order.id_Commodities,
                OrderTime = DateTime.Now,
                Quantity = order.Quantity,
                FullPrice = order.Quantity,
                id_Client = order.id_Client,
                Receiver = order.Receiver,
                Address = order.Address
            });
            Database.Save();
        }
    }
}
