namespace FlowersShop.BLL.Services
{
    using FlowersShop.BLL.Interfaces;
    using FlowersShop.DAL.Interfaces;
    using System.Collections.Generic;
    using FlowersShop.BLL.DTO;
    using FlowersShop.DAL.Entities;
    using FlowersShop.BLL.Infrastructure;
    using AutoMapper;

    public class ClientService : IClientService
    {
        public IUnitOfWork Database { get; set; }

        public ClientService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public ClientDto GetClient(int? id)
        {
            if (id == null)
            {
                throw new ValidationException("Commodity id was not set properly", "");
            }

            var cit = Database.Clients.Get(id.Value);

            if (cit == null)
            {
                throw new ValidationException("Commodity id was not found", "");
            }

            Mapper.Initialize(cfg => cfg.CreateMap<ClientEntity, ClientDto>());
            return Mapper.Map<ClientEntity, ClientDto>(cit);
        }

        public IEnumerable<ClientDto> GetClients()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<ClientEntity, ClientDto>());
            return Mapper.Map<IEnumerable<ClientEntity>, List<ClientDto>>(Database.Clients.GetAll());
        }

        public void Create(ClientDto client)
        {
            Database.Clients.Create(new ClientEntity
            {
                Id = client.ClientId,
                Name = client.Name,
                CellPhone = client.CellPhone,
                Email = client.Email,
                Gender = client.Gender,
                Age = client.Age,
                CityId = client.CityId
            });

            Database.Save();
        }

        public void Delete(int id)
        {
            Database.Clients.Delete(id);
            Database.Save();
        }

        public void Update(ClientDto client)
        {
            Database.Clients.Update(new ClientEntity
            {
                Id = client.ClientId,
                Name = client.Name,
                CellPhone = client.CellPhone,
                Email = client.Email,
                Gender = client.Gender,
                Age = client.Age,
                CityId = client.CityId
            });

            Database.Save();
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
