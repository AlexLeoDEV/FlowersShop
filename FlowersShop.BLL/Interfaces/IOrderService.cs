using FlowersShop.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowersShop.BLL.Interfaces
{
    public interface IOrderService
    {
        OrderDTO GetOrder(int? id);
        IEnumerable<OrderDTO> GetOrders();
        void Create(OrderDTO order);
        void Delete(int id);
        void Update(OrderDTO order);
        void Dispose();
    }
}
