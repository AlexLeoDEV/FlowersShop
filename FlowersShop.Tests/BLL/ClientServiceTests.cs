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
        ClientDTO newClient = new ClientDTO
        {
            id_Client = 2,
            Name = "Petro",
            CellPhone = "0995566445",
            Email = "email@hot.org",
            Gender = "Male",
            Age = 42,
            id_City = 1
        };

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
            bool IsErrorOccured = true;
            var mock = new Mock<IUnitOfWork>();            
           
            //Act 
            mock.Setup(c => c.Clients.Create(It.Is<Client>(cl => (cl.id_Client == newClient.id_Client) &&
                                                        (cl.Name == newClient.Name) &&
                                                        (cl.CellPhone == newClient.CellPhone) &&
                                                        (cl.Email == newClient.Email) &&
                                                        (cl.Gender == newClient.Gender) &&
                                                        (cl.Age == newClient.Age) &&
                                                        (cl.id_City == newClient.id_City)
                                                  ))).Callback(() => IsErrorOccured = false);

            clientService = new ClientService(mock.Object);
            clientService.Create(newClient);

            //Arrange
            Assert.IsFalse(IsErrorOccured);
        }

        [TestMethod]
        public void Update_client_succeeded()
        {
            //Arrange
            bool IsErrorOccured = true;
            var mock = new Mock<IUnitOfWork>();

            //Act 
            mock.Setup(c => c.Clients.Update(It.Is<Client>(cl => (cl.id_Client == newClient.id_Client) &&
                                                        (cl.Name == newClient.Name) &&
                                                        (cl.CellPhone == newClient.CellPhone) &&
                                                        (cl.Email == newClient.Email) &&
                                                        (cl.Gender == newClient.Gender) &&
                                                        (cl.Age == newClient.Age) &&
                                                        (cl.id_City == newClient.id_City)
                                                  ))).Callback(() => IsErrorOccured = false);
            clientService = new ClientService(mock.Object);
            clientService.Update(newClient);

            //Arrange
            Assert.IsFalse(IsErrorOccured);
        }

        [TestMethod]
        public void Delete_client_succeeded()
        {
            //Arrange
            bool IsErrorOccured = true;
            var mock = new Mock<IUnitOfWork>();
            var clientId = 1;

            //Act and Arrange
            mock.Setup(c => c.Clients.Delete(clientId)).Callback(() => IsErrorOccured = false);
            clientService = new ClientService(mock.Object);
            clientService.Delete(clientId);

            //Arrange
            Assert.IsFalse(IsErrorOccured);
        }

        [TestMethod]
        public void Dispose_client_succeeded()
        {
            //Arrange
            bool IsErrorOccured = true;
            var mock = new Mock<IUnitOfWork>();

            //Act
            mock.Setup(c => c.Dispose()).Callback(() => IsErrorOccured = false);
            clientService = new ClientService(mock.Object);
            clientService.Dispose();

            //Assert
            Assert.IsFalse(IsErrorOccured);
        }
    }
}
