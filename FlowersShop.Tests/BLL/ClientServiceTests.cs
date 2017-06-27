using FlowersShop.BLL.DTO;
using FlowersShop.BLL.Interfaces;
using FlowersShop.BLL.Services;
using FlowersShop.DAL.Entities;
using FlowersShop.DAL.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowersShop.Tests.BLL
{
    [TestClass]
    public class ClientServiceTests
    {
        private ClientService clientService;

        [TestMethod]
        public void GetClients_return_all_entities()
        {
            //Arrange
            var mock = new Mock<IUnitOfWork>();
            mock.Setup(c => c.Clients.GetAll()).Returns(new List<Client>());

            //Act
            clientService = new ClientService(mock.Object);
            var result = clientService.GetClients();

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetClient_return_item()
        {
            //Arrange
            var clientId = 7;
            var mock = new Mock<IUnitOfWork>();

            //Act
            mock.Setup(a => a.Clients.Get(clientId)).Returns(new Client());
            clientService = new ClientService(mock.Object);

            var result = clientService.GetClient(clientId);

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Create_client_succeeded()
        {
            //Arrange
            var mock = new Mock<IClientService>();
            var newClient = new ClientDTO
            {
                id_Client = 2,
                Name = "Petro",
                CellPhone = "0995566445",
                Email = "email@hot.org",
                Gender = "Male",
                Age = 42,
                id_City = 1
            };
           
            //Act and Arrange
            mock.Setup(c => c.Create(newClient)).Verifiable();
        }

        [TestMethod]
        public void Update_client_succeeded()
        {
            //Arrange
            var mock = new Mock<IClientService>();
            var newClient = new ClientDTO
            {
                id_Client = 2,
                Name = "Petro",
                CellPhone = "0995566445",
                Email = "email@hot.org",
                Gender = "Male",
                Age = 42,
                id_City = 1
            };

            //Act and Arrange
            mock.Setup(c => c.Update(newClient)).Verifiable();
        }

        [TestMethod]
        public void Delete_client_succeeded()
        {
            //Arrange
            var mock = new Mock<IClientService>();
            var clientID = 1;

            //Act and Arrange
            mock.Setup(c => c.Delete(clientID)).Verifiable();
        }
    }
}
