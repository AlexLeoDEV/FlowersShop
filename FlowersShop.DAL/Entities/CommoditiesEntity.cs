namespace FlowersShop.DAL.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// DAL commodity model
    /// </summary>
    public class CommoditiesEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommoditiesEntity"/> class.
        /// </summary>
        public CommoditiesEntity()
        {
            Order = new HashSet<OrderEntity>();
        }

        /// <summary>
        /// Gets or sets commodity id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets commodity name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets commodity colour
        /// </summary>
        public string Colour { get; set; }

        /// <summary>
        /// Gets or sets commodity price
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets commodity description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether commodity is handmade
        /// </summary>
        public bool IsHandMade { get; set; }

        /// <summary>
        /// Gets or sets image path for specific commodity
        /// </summary>
        public string ImagePath { get; set; }

        /// <summary>
        /// Gets or sets commodity's categoryId
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets commodity preferences
        /// </summary>
        public string Preferences { get; set; }

        /// <summary>
        /// Gets or sets specific category of commodity
        /// </summary>
        public CategoryEntity Category { get; set; }

        /// <summary>
        /// Gets or sets commodity order
        /// </summary>
        public virtual ICollection<OrderEntity> Order { get; set; }
    }
}
