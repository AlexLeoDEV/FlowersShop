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
    public class CategoryServiceTests
    {
        private CategoryService categoryService;
        CategoryDTO newCategory = new CategoryDTO
        {
            id_Category = 6,
            Title = "New category",
        };

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

        [TestMethod]
        public void Create_category_succeeded()
        {
            //Arrange
            bool IsErrorOccured = true;
            var mock = new Mock<IUnitOfWork>();
            
            //Act 
            mock.Setup(c => c.Categories.Create(It.Is<Category>(cl => (cl.id_Category == newCategory.id_Category) &&
                                                        (cl.Title == newCategory.Title)
                                                  ))).Callback(() => IsErrorOccured = false);
            categoryService = new CategoryService(mock.Object);
            categoryService.Create(newCategory);

            //Arrange
            Assert.IsFalse(IsErrorOccured);
        }

        [TestMethod]
        public void Update_category_succeeded()
        {
            //Arrange
            bool IsErrorOccured = true;
            var mock = new Mock<IUnitOfWork>();

            //Act 
            mock.Setup(c => c.Categories.Update(It.Is<Category>(cl => (cl.id_Category == newCategory.id_Category) &&
                                                        (cl.Title == newCategory.Title)
                                                  ))).Callback(() => IsErrorOccured = false);
            categoryService = new CategoryService(mock.Object);
            categoryService.Update(newCategory);

            //Arrange
            Assert.IsFalse(IsErrorOccured);
        }

        [TestMethod]
        public void Delete_category_succeeded()
        {
            //Arrange
            bool IsErrorOccured = true;
            var mock = new Mock<IUnitOfWork>();
            var categoryId = 1;

            //Act and Arrange
            mock.Setup(c => c.Categories.Delete(categoryId)).Callback(() => IsErrorOccured = false);
            categoryService = new CategoryService(mock.Object);
            categoryService.Delete(categoryId);

            //Arrange
            Assert.IsFalse(IsErrorOccured);
        }

        [TestMethod]
        public void Dispose_category_succeeded()
        {
            //Arrange
            bool IsErrorOccured = true;
            var mock = new Mock<IUnitOfWork>();

            //Act
            mock.Setup(c => c.Dispose()).Callback(() => IsErrorOccured = false);
            categoryService = new CategoryService(mock.Object);
            categoryService.Dispose();

            //Assert
            Assert.IsFalse(IsErrorOccured);
        }
    }
}
