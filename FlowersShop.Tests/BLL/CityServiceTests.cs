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
    public class CityServiceTests
    {
        private CityService cityService;
        CityDTO newCity = new CityDTO
        {
            id_City = 6,
            Title = "Ternivka",
            Price = 400M
        };

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

        [TestMethod]
        public void Create_city_succeeded()
        {
            //Arrange
            bool IsErrorOccured = true;
            var mock = new Mock<IUnitOfWork>();            

            //Act 
            mock.Setup(c => c.Cities.Create(It.Is<City>(cl => (cl.id_City == newCity.id_City) &&
                                                        (cl.Title == newCity.Title) &&
                                                        (cl.Price == newCity.Price)
                                                  ))).Callback(() => IsErrorOccured = false);
            cityService = new CityService(mock.Object);
            cityService.Create(newCity);

            //Arrange
            Assert.IsFalse(IsErrorOccured);
        }

        [TestMethod]
        public void Update_city_succeeded()
        {
            //Arrange
            bool IsErrorOccured = true;
            var mock = new Mock<IUnitOfWork>();

            //Act 
            mock.Setup(c => c.Cities.Update(It.Is<City>(cl => (cl.id_City == newCity.id_City) &&
                                                        (cl.Title == newCity.Title) &&
                                                        (cl.Price == newCity.Price)
                                                  ))).Callback(() => IsErrorOccured = false);
            cityService = new CityService(mock.Object);
            cityService.Update(newCity);

            //Arrange
            Assert.IsFalse(IsErrorOccured);
        }

        [TestMethod]
        public void Delete_city_succeeded()
        {
            //Arrange
            bool IsErrorOccured = true;
            var mock = new Mock<IUnitOfWork>();
            var cityId = 1;

            //Act and Arrange
            mock.Setup(c => c.Cities.Delete(cityId)).Callback(() => IsErrorOccured = false);
            cityService = new CityService(mock.Object);
            cityService.Delete(cityId);

            //Arrange
            Assert.IsFalse(IsErrorOccured);
        }

        [TestMethod]
        public void Dispose_city_succeeded()
        {
            //Arrange
            bool IsErrorOccured = true;
            var mock = new Mock<IUnitOfWork>();

            //Act
            mock.Setup(c => c.Dispose()).Callback(() => IsErrorOccured = false);
            cityService = new CityService(mock.Object);
            cityService.Dispose();

            //Assert
            Assert.IsFalse(IsErrorOccured);
        }
    }
}
