namespace FlowersShop.Tests.BLL
{
    using FlowersShop.BLL.DTO;
    using FlowersShop.BLL.Services;
    using FlowersShop.DAL.Entities;
    using FlowersShop.DAL.Interfaces;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using System.Collections.Generic;

    [TestClass]
    public class CityServiceTests
    {
        private CityService _cityService;

        CityDto newCity = new CityDto
        {
            CityId = 6,
            Title = "Ternivka",
            Price = 400M
        };

        [TestMethod]
        public void GetCities_returns_all_entities()
        {
            //Arrange
            var mock = new Mock<IUnitOfWork>();
            mock.Setup(c => c.Cities.GetAll()).Returns(new List<CityEntity>());

            //Act
            _cityService = new CityService(mock.Object);
            var result = _cityService.GetCities();

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
            mock.Setup(a => a.Cities.Get(cityId)).Returns(new CityEntity());
            _cityService = new CityService(mock.Object);

            var result = _cityService.GetCity(cityId);

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Create_city_succeeded()
        {
            //Arrange
            var isErrorOccured = true;
            var mock = new Mock<IUnitOfWork>();            

            //Act 
            mock.Setup(c => c.Cities.Create(It.Is<CityEntity>(cl => cl.Id == newCity.CityId 
                                                           && cl.Name == newCity.Title 
                                                           && cl.Price == newCity.Price)))
                                                           .Callback(() => isErrorOccured = false);
            _cityService = new CityService(mock.Object);
            _cityService.Create(newCity);

            //Arrange
            Assert.IsFalse(isErrorOccured);
        }

        [TestMethod]
        public void Update_city_succeeded()
        {
            //Arrange
            var isErrorOccured = true;
            var mock = new Mock<IUnitOfWork>();

            //Act 
            mock.Setup(c => c.Cities.Update(It.Is<CityEntity>(cl => cl.Id == newCity.CityId 
                                                            && cl.Name == newCity.Title 
                                                            && cl.Price == newCity.Price)))
                                                            .Callback(() => isErrorOccured = false);
            _cityService = new CityService(mock.Object);
            _cityService.Update(newCity);

            //Arrange
            Assert.IsFalse(isErrorOccured);
        }

        [TestMethod]
        public void Delete_city_succeeded()
        {
            //Arrange
            var isErrorOccured = true;
            var mock = new Mock<IUnitOfWork>();
            var cityId = 1;

            //Act and Arrange
            mock.Setup(c => c.Cities.Delete(cityId)).Callback(() => isErrorOccured = false);
            _cityService = new CityService(mock.Object);
            _cityService.Delete(cityId);

            //Arrange
            Assert.IsFalse(isErrorOccured);
        }

        [TestMethod]
        public void Dispose_city_succeeded()
        {
            //Arrange
            var isErrorOccured = true;
            var mock = new Mock<IUnitOfWork>();

            //Act
            mock.Setup(c => c.Dispose()).Callback(() => isErrorOccured = false);
            _cityService = new CityService(mock.Object);
            _cityService.Dispose();

            //Assert
            Assert.IsFalse(isErrorOccured);
        }
    }
}
