namespace FlowersShop.WEB.Models.Commodities
{
    using FlowersShop.BLL.DTO;

    /// <summary>
    /// Represents commodity view model
    /// </summary>
    public class CommodityItemViewModel
    {
        /// <summary>
        /// Gets or sets commodity Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets commodity name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets commodity path to image 
        /// </summary>
        public string ImagePath { get; set; }

        /// <summary>
        /// Gets or sets commodity price
        /// </summary>
        public decimal Price { get; set; }

        #region Factory Methods

        /// <summary>
        /// Maps CommodityItemViewModel to CommodityViewModel
        /// </summary>
        /// <param name="commodity"> CommodityViewModel object </param>
        /// <returns> View model object </returns>
        public static CommodityItemViewModel Map(CommodityViewModel commodity)
        {
            var commodityItemViewModel = new CommodityItemViewModel
            {
                Id = commodity.Id,
                Name = commodity.Name,
                ImagePath = commodity.ImagePath,
                Price = commodity.Price
            };
            return commodityItemViewModel;
        }

        #endregion
    }
}