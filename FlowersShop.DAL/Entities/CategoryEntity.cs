namespace FlowersShop.DAL.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// DAL category model
    /// </summary>
    public class CategoryEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryEntity"/> class.
        /// </summary>
        public CategoryEntity()
        {
            Commodity = new HashSet<CommoditiesEntity>();
        }

        /// <summary>
        /// Gets or sets the category id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///  Gets or sets category name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///  Gets or sets commodities collection of the category
        /// </summary>
        public virtual ICollection<CommoditiesEntity> Commodity { get; set; }
    }
}
