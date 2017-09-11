using FlowersShop.BLL.DTO;
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
    public class OrderServiceTests
    {
        private OrderService ordersService;

        [TestMethod]
        public void GetOrders_returns_all_entities()
        {
            //Arrange
            var mock = new Mock<IUnitOfWork>();
            mock.Setup(c => c.Orders.GetAll()).Returns(new List<OrderEntity>());

            //Act
            ordersService = new OrderService(mock.Object);
            var result = ordersService.GetOrders();

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetOrder_returns_item()
        {
            //Arrange
            var orderId = 2;
            var mock = new Mock<IUnitOfWork>();

            //Act
            mock.Setup(a => a.Orders.Get(orderId)).Returns(new OrderEntity());
            ordersService = new OrderService(mock.Object);

            var result = ordersService.GetOrder(orderId);

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Delete_order_succeeded()
        {
            //Arrange
            bool IsErrorOccured = true;
            var mock = new Mock<IUnitOfWork>();
            var orderId = 7;

            //Act and Arrange
            mock.Setup(c => c.Orders.Delete(orderId)).Callback(() => IsErrorOccured = false);
            ordersService = new OrderService(mock.Object);
            ordersService.Delete(orderId);

            //Arrange
            Assert.IsFalse(IsErrorOccured);
        }

        [TestMethod]
        public void Dispose_order_succeeded()
        {
            //Arrange
            bool IsErrorOccured = true;
            var mock = new Mock<IUnitOfWork>();

            //Act
            mock.Setup(c => c.Dispose()).Callback(() => IsErrorOccured = false);
            ordersService = new OrderService(mock.Object);
            ordersService.Dispose();

            //Assert
            Assert.IsFalse(IsErrorOccured);
        }
    }
}
