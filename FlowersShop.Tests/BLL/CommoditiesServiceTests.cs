using FlowersShop.BLL.DTO;
using FlowersShop.BLL.Interfaces;
using FlowersShop.BLL.Services;
using FlowersShop.DAL.Entities;
using FlowersShop.DAL.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace FlowersShop.Tests
{
    [TestClass]
    public class CommoditiesServiceTests
    {
        private CommoditiesService service;

        [TestMethod]
        public void GetAll_returns_all_entities()
        {
            //Arrange
            var mock = new Mock<IUnitOfWork>();
            mock.Setup(c => c.Commodities.GetAll()).Returns(new List<Commodities>());

            //Act
            service = new CommoditiesService(mock.Object);
            var result = service.GetCommodities();

            //Arrange
            Assert.IsNotNull(result);
        }
    }
}
