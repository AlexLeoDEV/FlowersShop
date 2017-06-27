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
    public class CategoryServiceTests
    {
        private CategoryService categoryService;

        [TestMethod]
        public void GetCategories_returns_all_entities()
        {
            //Arrange
            var mock = new Mock<IUnitOfWork>();
            mock.Setup(c => c.Categories.GetAll()).Returns(new List<Category>());

            //Act
            categoryService = new CategoryService(mock.Object);
            var result = categoryService.GetCategories();

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetCategory_returns_item()
        {
            //Arrange
            var categoryId = 2;
            var mock = new Mock<IUnitOfWork>();

            //Act
            mock.Setup(a => a.Categories.Get(categoryId)).Returns(new Category());
            categoryService = new CategoryService(mock.Object);

            var result = categoryService.GetCategory(categoryId);

            //Assert
            Assert.IsNotNull(result);
        }
    }
}
