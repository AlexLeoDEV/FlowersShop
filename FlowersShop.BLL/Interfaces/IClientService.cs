using FlowersShop.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowersShop.BLL.Interfaces
{
    public interface IClientService
    {
        ClientDTO GetClient(int? id);
        IEnumerable<ClientDTO> GetClients();
        void Create(ClientDTO client);
        void Delete(int id);
        void Update(ClientDTO client);
        void Dispose();
    }
}
