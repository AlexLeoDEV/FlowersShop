namespace FlowersShop.BLL.Interfaces
{
    using FlowersShop.BLL.DTO;
    using System.Collections.Generic;

    public interface IClientService
    {
        ClientDto GetClient(int? id);
        IEnumerable<ClientDto> GetClients();
        void Create(ClientDto client);
        void Delete(int id);
        void Update(ClientDto client);
        void Dispose();
    }
}
