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
        CommodityDTO newCommodity = new CommodityDTO
        {
            id_Commodities = 2,
            Title = "Rose",
            Colour = "Red",
            Price = 50M,
            Description = "Red rose",
            IsHandMade = true,
            id_Category = 1,
            Preferences = "Beloved",
            image = "/Content/img.jpg"
        };

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

        [TestMethod]
        public void Create_commodity_succeeded()
        {
            //Arrange
            bool IsErrorOccured = true;
            var mock = new Mock<IUnitOfWork>();

            //Act 
            mock.Setup(c => c.Commodities.Create(It.Is<Commodities>(cl => (cl.id_Commodities == newCommodity.id_Commodities) &&
                                                        (cl.Title == newCommodity.Title) &&
                                                        (cl.Colour == newCommodity.Colour) &&
                                                        (cl.Price == newCommodity.Price) &&
                                                        (cl.Description == newCommodity.Description) &&
                                                        (cl.IsHandMade == newCommodity.IsHandMade) &&
                                                        (cl.id_Category == newCommodity.id_Category) &&
                                                        (cl.Preferences == newCommodity.Preferences) &&
                                                        (cl.image == newCommodity.image)
                                                  ))).Callback(() => IsErrorOccured = false);

            commService = new CommoditiesService(mock.Object);
            commService.Create(newCommodity);

            //Arrange
            Assert.IsFalse(IsErrorOccured);
        }

        [TestMethod]
        public void Update_commodity_succeeded()
        {
            //Arrange
            bool IsErrorOccured = true;
            var mock = new Mock<IUnitOfWork>();

            //Act 
            mock.Setup(c => c.Commodities.Update(It.Is<Commodities>(cl => (cl.id_Commodities == newCommodity.id_Commodities) &&
                                                        (cl.Title == newCommodity.Title) &&
                                                        (cl.Colour == newCommodity.Colour) &&
                                                        (cl.Price == newCommodity.Price) &&
                                                        (cl.Description == newCommodity.Description) &&
                                                        (cl.IsHandMade == newCommodity.IsHandMade) &&
                                                        (cl.id_Category == newCommodity.id_Category) &&
                                                        (cl.Preferences == newCommodity.Preferences) &&
                                                        (cl.image == newCommodity.image)
                                                  ))).Callback(() => IsErrorOccured = false);
            commService = new CommoditiesService(mock.Object);
            commService.Update(newCommodity);

            //Arrange
            Assert.IsFalse(IsErrorOccured);
        }

        [TestMethod]
        public void Delete_commodity_succeeded()
        {
            //Arrange
            bool IsErrorOccured = true;
            var mock = new Mock<IUnitOfWork>();
            var commodityId = 7;

            //Act and Arrange
            mock.Setup(c => c.Commodities.Delete(commodityId)).Callback(() => IsErrorOccured = false);
            commService = new CommoditiesService(mock.Object);
            commService.Delete(commodityId);

            //Arrange
            Assert.IsFalse(IsErrorOccured);
        }

        [TestMethod]
        public void Dispose_commodity_succeeded()
        {
            //Arrange
            bool IsErrorOccured = true;
            var mock = new Mock<IUnitOfWork>();

            //Act
            mock.Setup(c => c.Dispose()).Callback(() => IsErrorOccured = false);
            commService = new CommoditiesService(mock.Object);
            commService.Dispose();

            //Assert
            Assert.IsFalse(IsErrorOccured);
        }
    }
}
