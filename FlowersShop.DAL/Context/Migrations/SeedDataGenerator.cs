namespace FlowersShop.DAL.Context.Migrations
{
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Diagnostics;
    using EF;
    using Entities;

    /// <summary>
    /// Generates and seeds test entity data
    /// </summary>
    internal static class SeedDataGenerator
    {
        /// <summary>
        /// Generates and seeds test data for
        /// categories, cities, clients and commodities entities
        /// </summary>
        /// <param name="context">Context of the entities</param>
        [Conditional("DEBUG")]
        internal static void GenerateDebugEntities(FlowersShopEntities context)
        {
            var categories = GenerateCategories();
            var cities = GenerateCities();
            var clients = GenerateClients();
            var commodities = GenerateCommodities();

            context.Categories.AddOrUpdate(c => c.Name, categories.ToArray());
            context.SaveChanges();

            context.Cities.AddOrUpdate(ct => ct.Name, cities.ToArray());
            context.SaveChanges();

            // context.Clients.AddOrUpdate(cl => cl.Name, clients.ToArray());
            // context.SaveChanges();
            context.Commodities.AddOrUpdate(com => com.Id, commodities.ToArray());
            context.SaveChanges();
        }

        #region categories

        private static List<CategoryEntity> GenerateCategories()
        {
            return new List<CategoryEntity>
            {
                new CategoryEntity
                {
                    Id = 1,
                    Name = "Flower composition"
                },

                new CategoryEntity
                {
                    Id = 2,
                    Name = "Mono bouquet"
                },

                new CategoryEntity
                {
                    Id = 3,
                    Name = "Bouquet"
                },

                new CategoryEntity
                {
                    Id = 4,
                    Name = "Flower basket"
                },

                new CategoryEntity
                {
                    Id = 5,
                    Name = "Flower"
                },

                new CategoryEntity
                {
                    Id = 6,
                    Name = "Grass"
                },

                new CategoryEntity
                {
                    Id = 7,
                    Name = "Decoration"
                }
            };
        }

        #endregion

        #region cities

        private static List<CityEntity> GenerateCities()
        {
            return new List<CityEntity>
            {
                new CityEntity
                {
                    Id = 1,
                    Name = "Dnipro",
                    DeliveryPrice = 100
                },

                new CityEntity
                {
                    Id = 2,
                    Name = "Kamianske",
                    DeliveryPrice = 120
                },

                new CityEntity
                {
                    Id = 3,
                    Name = "Novomoskovsk",
                    DeliveryPrice = 120
                },

                new CityEntity
                {
                    Id = 4,
                    Name = "Pavlograd",
                    DeliveryPrice = 150
                }
            };
        }

        #endregion

        #region clients

        private static IEnumerable<ClientEntity> GenerateClients()
        {
            return new List<ClientEntity>
            {
                new ClientEntity
                {
                    Id = 1,
                    Name = "Alex",
                    Age = 26,
                    CellPhone = "0953336885",
                    CityId = 1,
                    Email = "alex123@yahoo.com",
                    Gender = "Male"
                },
                new ClientEntity
                {
                    Id = 2,
                    Name = "Kiril",
                    Age = 24,
                    CellPhone = "0953354885",
                    CityId = 2,
                    Email = "kiril@yahoo.com",
                    Gender = "Male"
                }
            };
        }

        #endregion

        #region commodities
        private static List<CommoditiesEntity> GenerateCommodities()
        {
            return new List<CommoditiesEntity>
            {
                new CommoditiesEntity
                {
                    Id = 1,
                    Name = "Roses",
                    Colour = "Red",
                    Price = 35,
                    Description = "Red rose",
                    IsHandMade = false,
                    ImagePath = "/Content/Images/Comodities/Flowers/fl1.jpg",
                    CategoryId = 5,
                    Preferences = "Beloved"
                },

                new CommoditiesEntity
                {
                    Id = 2,
                    Name = "Roses",
                    Colour = "White",
                    Price = 30,
                    Description = "White rose",
                    IsHandMade = false,
                    ImagePath = "/Content/Images/Comodities/Flowers/fl2.jpg",
                    CategoryId = 5,
                    Preferences = "Kid"
                },

                new CommoditiesEntity
                {
                    Id = 3,
                    Name = "Roses",
                    Colour = "Pink",
                    Price = 27,
                    Description = "Pink rose",
                    IsHandMade = false,
                    ImagePath = "/Content/Images/Comodities/Flowers/fl3.jpg",
                    CategoryId = 5,
                    Preferences = "Mom"
                },

                new CommoditiesEntity
                {
                    Id = 4,
                    Name = "Roses",
                    Colour = "Yellow",
                    Price = 28,
                    Description = "Yellow rose",
                    IsHandMade = false,
                    ImagePath = "/Content/Images/Comodities/Flowers/fl4.jpg",
                    CategoryId = 5,
                    Preferences = "Colleague"
                },

                new CommoditiesEntity
                {
                    Id = 5,
                    Name = "Lilies",
                    Colour = "White",
                    Price = 29,
                    Description = "White lily",
                    IsHandMade = false,
                    ImagePath = "/Content/Images/Comodities/Flowers/fl5.jpg",
                    CategoryId = 5,
                    Preferences = "Granny"
                },

                new CommoditiesEntity
                {
                    Id = 6,
                    Name = "Lilies",
                    Colour = "Orange",
                    Price = 24,
                    Description = "Orange lily",
                    IsHandMade = false,
                    ImagePath = "/Content/Images/Comodities/Flowers/fl6.jpg",
                    CategoryId = 5,
                    Preferences = "Kid"
                },

                new CommoditiesEntity
                {
                    Id = 7,
                    Name = "Lilies",
                    Colour = "Pink",
                    Price = 22,
                    Description = "Pink lily",
                    IsHandMade = false,
                    ImagePath = "/Content/Images/Comodities/Flowers/fl7.jpg",
                    CategoryId = 5,
                    Preferences = "Mom"
                },

                new CommoditiesEntity
                {
                    Id = 8,
                    Name = "Tulip",
                    Colour = "White",
                    Price = 22,
                    Description = "White tulip",
                    IsHandMade = false,
                    ImagePath = "/Content/Images/Comodities/Flowers/fl8.jpg",
                    CategoryId = 5,
                    Preferences = "Kid"
                },

                new CommoditiesEntity
                {
                    Id = 9,
                    Name = "Tulip",
                    Colour = "Pink",
                    Price = 28,
                    Description = "Pink tulip",
                    IsHandMade = false,
                    ImagePath = "/Content/Images/Comodities/Flowers/fl9.jpg",
                    CategoryId = 5,
                    Preferences = "Colleague"
                },

                new CommoditiesEntity
                {
                    Id = 10,
                    Name = "Tulip",
                    Colour = "Red",
                    Price = 32,
                    Description = "Red tulip",
                    IsHandMade = false,
                    ImagePath = "/Content/Images/Comodities/Flowers/fl10.jpg",
                    CategoryId = 5,
                    Preferences = "Beloved"
                },

                new CommoditiesEntity
                {
                    Id = 11,
                    Name = "Tulip",
                    Colour = "Yellow",
                    Price = 30,
                    Description = "Yellow tulip",
                    IsHandMade = false,
                    ImagePath = "/Content/Images/Comodities/Flowers/fl11.jpg",
                    CategoryId = 5,
                    Preferences = "Colleague"
                },

                new CommoditiesEntity
                {
                    Id = 12,
                    Name = "Chrysanthemum",
                    Colour = "White",
                    Price = 36,
                    Description = "White chrysanthemum",
                    IsHandMade = false,
                    ImagePath = "/Content/Images/Comodities/Flowers/fl12.jpg",
                    CategoryId = 5,
                    Preferences = "Kid"
                },

                new CommoditiesEntity
                {
                    Id = 13,
                    Name = "Chrysanthemum",
                    Colour = "Red",
                    Price = 34,
                    Description = "Red chrysanthemum",
                    IsHandMade = false,
                    ImagePath = "/Content/Images/Comodities/Flowers/fl13.jpg",
                    CategoryId = 5,
                    Preferences = "Kid"
                },

                new CommoditiesEntity
                {
                    Id = 14,
                    Name = "Chrysanthemum",
                    Colour = "Yellow",
                    Price = 34,
                    Description = "Yellow chrysanthemum",
                    IsHandMade = false,
                    ImagePath = "/Content/Images/Comodities/Flowers/fl14.jpg",
                    CategoryId = 5,
                    Preferences = "Colleague"
                },

                new CommoditiesEntity
                {
                    Id = 15,
                    Name = "Chrysanthemum",
                    Colour = "Orange",
                    Price = 37,
                    Description = "Orange chrysanthemum",
                    IsHandMade = false,
                    ImagePath = "/Content/Images/Comodities/Flowers/fl15.jpg",
                    CategoryId = 5,
                    Preferences = "Granny"
                },

                new CommoditiesEntity
                {
                    Id = 16,
                    Name = "Peony",
                    Colour = "Red",
                    Price = 30,
                    Description = "Red peon",
                    IsHandMade = false,
                    ImagePath = "/Content/Images/Comodities/Flowers/fl16.jpg",
                    CategoryId = 5,
                    Preferences = "Beloved"
                },

                new CommoditiesEntity
                {
                    Id = 17,
                    Name = "Peony",
                    Colour = "White",
                    Price = 31,
                    Description = "White peon",
                    IsHandMade = false,
                    ImagePath = "/Content/Images/Comodities/Flowers/fl17.jpg",
                    CategoryId = 5,
                    Preferences = "Kid"
                },

                new CommoditiesEntity
                {
                    Id = 18,
                    Name = "Peony",
                    Colour = "Pink",
                    Price = 30,
                    Description = "Pink peon",
                    IsHandMade = false,
                    ImagePath = "/Content/Images/Comodities/Flowers/fl18.jpg",
                    CategoryId = 5,
                    Preferences = "Colleague"
                },

                new CommoditiesEntity
                {
                    Id = 19,
                    Name = "Irises",
                    Colour = "Blue",
                    Price = 36,
                    Description = "Blue irise",
                    IsHandMade = false,
                    ImagePath = "/Content/Images/Comodities/Flowers/fl19.jpg",
                    CategoryId = 5,
                    Preferences = "Colleague"
                },

                new CommoditiesEntity
                {
                    Id = 20,
                    Name = "Irises",
                    Colour = "Red",
                    Price = 30,
                    Description = "Red irise",
                    IsHandMade = false,
                    ImagePath = "/Content/Images/Comodities/Flowers/fl20.jpg",
                    CategoryId = 5,
                    Preferences = "Beloved"
                },

                new CommoditiesEntity
                {
                    Id = 21,
                    Name = "Irises",
                    Colour = "Yellow",
                    Price = 33,
                    Description = "Yellow irise",
                    IsHandMade = false,
                    ImagePath = "/Content/Images/Comodities/Flowers/fl21.jpg",
                    CategoryId = 5,
                    Preferences = "Beloved"
                },

                new CommoditiesEntity
                {
                    Id = 22,
                    Name = "Irises",
                    Colour = "White",
                    Price = 27,
                    Description = "White irise",
                    IsHandMade = false,
                    ImagePath = "/Content/Images/Comodities/Flowers/fl22.jpg",
                    CategoryId = 5,
                    Preferences = "Beloved"
                }
            };
        }

        #endregion
    }
}
