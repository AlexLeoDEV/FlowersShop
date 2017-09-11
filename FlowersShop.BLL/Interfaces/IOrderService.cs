namespace FlowersShop.BLL.Interfaces
{
    using FlowersShop.BLL.DTO;
    using System.Collections.Generic;

    public interface IOrderService
    {
        OrderDto GetOrder(int? id);
        IEnumerable<OrderDto> GetOrders();
        void Create(OrderDto order);
        void Delete(int id);
        void Update(OrderDto order);
        void Dispose();
    }
}
