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
        private CommoditiesService commService;

        [TestMethod]
        public void GetCommodities_returns_all_entities()
        {
            //Arrange
            var mock = new Mock<IUnitOfWork>();
            mock.Setup(c => c.Commodities.GetAll()).Returns(new List<Commodities>());

            //Act
            commService = new CommoditiesService(mock.Object);
            var result = commService.GetCommodities();

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetCommodity_returns_item()
        {
            //Arrange
            var commodityId = 7;
            var mock = new Mock<IUnitOfWork>();

            //Act
            mock.Setup(a => a.Commodities.Get(commodityId)).Returns(new Commodities());
            commService = new CommoditiesService(mock.Object);

            var result = commService.GetCommodity(commodityId);

            //Assert
            Assert.IsNotNull(result);
        }
    }
}
