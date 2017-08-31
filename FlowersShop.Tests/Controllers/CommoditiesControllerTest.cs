using FlowersShop.BLL.DTO;
using FlowersShop.BLL.Interfaces;
using FlowersShop.WEB.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace FlowersShop.Tests.Controllers
{
    [TestClass]
    public class CommoditiesControllerTest
    {
        private CommoditiesController controller;

        [TestInitialize]
        public void SetupContext()
        {
            controller = new CommoditiesController();
        }

        [TestMethod]
        public void Index_view_result_not_null()
        {
            // Arrange
            string colours = "All";
            int page = 1;
            var mock = new Mock<ICommoditiesService>();
            mock.Setup(a => a.GetCommodities()).Returns(new List<CommodityDto>());
            controller = new CommoditiesController(mock.Object);

            // Act
            var result = controller.Index(colours, page) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Get_commodity_from_db()
        {
            //Arrange
            var commodity = 25;

            //Act
            var mock = new Mock<ICommoditiesService>();
            mock.Setup(a => a.GetCommodity(commodity));
            var result = new CommoditiesController(mock.Object);

            //Assert
            Assert.IsNotNull(result);
        }
    }
}
