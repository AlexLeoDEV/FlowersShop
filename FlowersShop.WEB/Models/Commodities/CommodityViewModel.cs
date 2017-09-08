namespace FlowersShop.WEB.Models
{
    using FlowersShop.BLL.DTO;
    using FlowersShop.DAL.Entities;
    using System.Collections.Generic;

    public class CommodityViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Colour { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public bool IsHandMade { get; set; }

        public int CategoryId { get; set; }

        public string ImagePath { get; set; }

        public string Preferences { get; set; }

        public CategoryEntity Category { get; set; }

        public ICollection<OrderEntity> Order { get; set; }

        #region Factory Methods

        /// <summary>
        /// Maps BLL entity to presentation
        /// </summary>
        /// <param name="commodity"> BLL object </param>
        /// <returns> View model object </returns>
        public static CommodityViewModel Map(CommodityDto commodity)
        {
            var commodityViewModel = new CommodityViewModel
            {
                Id = commodity.Id,
                Name = commodity.Name,
                Colour = commodity.Colour,
                CategoryId = commodity.CategoryId,
                IsHandMade = commodity.IsHandMade,
                Description = commodity.Description,
                Price = commodity.Price,
                ImagePath = commodity.ImagePath,
                Preferences = commodity.Preferences
            };

            return commodityViewModel;
        }

        #endregion
    }
}