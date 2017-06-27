using FlowersShop.BLL.Interfaces;
using FlowersShop.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowersShop.BLL.DTO;
using FlowersShop.DAL.Entities;
using FlowersShop.BLL.Infrastructure;
using AutoMapper;

namespace FlowersShop.BLL.Services
{
    public class ClientService : IClientService
    {
        IUnitOfWork Database { get; set; }
        public ClientService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public ClientDTO GetClient(int? id)
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
            Mapper.Initialize(cfg => cfg.CreateMap<Client, ClientDTO>());
            return Mapper.Map<Client, ClientDTO>(cit);
        }

        public IEnumerable<ClientDTO> GetClients()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Client, ClientDTO>());
            return Mapper.Map<IEnumerable<Client>, List<ClientDTO>>(Database.Clients.GetAll());
        }

        public void Create(ClientDTO client)
        {
            Database.Clients.Create(new Client
            {
                id_Client = client.id_Client,
                Name = client.Name,
                CellPhone = client.CellPhone,
                Email = client.Email,
                Gender = client.Gender,
                Age = client.Age,
                id_City = client.id_City
            });
            Database.Save();
        }

        public void Delete(int id)
        {
            Database.Clients.Delete(id);
            Database.Save();
        }

        public void Update(ClientDTO client)
        {
            Database.Clients.Update(new Client
            {
                id_Client = client.id_Client,
                Name = client.Name,
                CellPhone = client.CellPhone,
                Email = client.Email,
                Gender = client.Gender,
                Age = client.Age,
                id_City = client.id_City
            });
            Database.Save();
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
