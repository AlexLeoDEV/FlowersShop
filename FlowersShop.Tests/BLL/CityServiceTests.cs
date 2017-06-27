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
    public class CityServiceTests
    {
        private CityService cityService;

        [TestMethod]
        public void GetCities_returns_all_entities()
        {
            //Arrange
            var mock = new Mock<IUnitOfWork>();
            mock.Setup(c => c.Cities.GetAll()).Returns(new List<City>());

            //Act
            cityService = new CityService(mock.Object);
            var result = cityService.GetCities();

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetCity_returns_item()
        {
            //Arrange
            var cityId = 2;
            var mock = new Mock<IUnitOfWork>();

            //Act
            mock.Setup(a => a.Cities.Get(cityId)).Returns(new City());
            cityService = new CityService(mock.Object);

            var result = cityService.GetCity(cityId);

            //Assert
            Assert.IsNotNull(result);
        }
    }
}
