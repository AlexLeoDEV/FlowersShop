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
        private ClientService _clientService;

        ClientDto newClient = new ClientDto
        {
            ClientId = 2,
            Name = "Petro",
            CellPhone = "0995566445",
            Email = "email@hot.org",
            Gender = "Male",
            Age = 42,
            CityId = 1
        };

        [TestMethod]
        public void GetClients_return_all_entities()
        {
            //Arrange
            var mock = new Mock<IUnitOfWork>();
            mock.Setup(c => c.Clients.GetAll()).Returns(new List<ClientEntity>());

            //Act
            _clientService = new ClientService(mock.Object);
            var result = _clientService.GetClients();

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
            mock.Setup(a => a.Clients.Get(clientId)).Returns(new ClientEntity());
            _clientService = new ClientService(mock.Object);

            var result = _clientService.GetClient(clientId);

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Create_client_succeeded()
        {
            //Arrange
            bool IsErrorOccured = true;
            var mock = new Mock<IUnitOfWork>();            
           
            //Act 
            mock.Setup(c => c.Clients.Create(It.Is<ClientEntity>(cl => (cl.Id == newClient.ClientId) &&
                                                        cl.Name == newClient.Name &&
                                                        cl.CellPhone == newClient.CellPhone &&
                                                        cl.Email == newClient.Email &&
                                                        cl.Gender == newClient.Gender &&
                                                        cl.Age == newClient.Age &&
                                                        cl.CityId == newClient.CityId)))
                                                        .Callback(() => IsErrorOccured = false);

            _clientService = new ClientService(mock.Object);
            _clientService.Create(newClient);

            //Arrange
            Assert.IsFalse(IsErrorOccured);
        }

        [TestMethod]
        public void Update_client_succeeded()
        {
            //Arrange
            var isErrorOccured = true;
            var mock = new Mock<IUnitOfWork>();

            //Act 
            mock.Setup(c => c.Clients.Update(It.Is<ClientEntity>(cl => cl.Id == newClient.ClientId 
                                                                && cl.Name == newClient.Name 
                                                                && cl.CellPhone == newClient.CellPhone 
                                                                && cl.Email == newClient.Email 
                                                                && cl.Gender == newClient.Gender 
                                                                && cl.Age == newClient.Age 
                                                                && cl.CityId == newClient.CityId)))
                                                                .Callback(() => isErrorOccured = false);
            _clientService = new ClientService(mock.Object);
            _clientService.Update(newClient);

            //Arrange
            Assert.IsFalse(isErrorOccured);
        }

        [TestMethod]
        public void Delete_client_succeeded()
        {
            //Arrange
            var isErrorOccured = true;
            var mock = new Mock<IUnitOfWork>();
            var clientId = 1;

            //Act and Arrange
            mock.Setup(c => c.Clients.Delete(clientId)).Callback(() => isErrorOccured = false);
            _clientService = new ClientService(mock.Object);
            _clientService.Delete(clientId);

            //Arrange
            Assert.IsFalse(isErrorOccured);
        }

        [TestMethod]
        public void Dispose_client_succeeded()
        {
            //Arrange
            var isErrorOccured = true;
            var mock = new Mock<IUnitOfWork>();

            //Act
            mock.Setup(c => c.Dispose()).Callback(() => isErrorOccured = false);
            _clientService = new ClientService(mock.Object);
            _clientService.Dispose();

            //Assert
            Assert.IsFalse(isErrorOccured);
        }
    }
}
