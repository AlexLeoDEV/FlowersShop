namespace FlowersShop.DAL.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// DAL city model
    /// </summary>
    public class CityEntity
    {
        /// <summary>
        /// Gets or sets city id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets city name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets specific delivery price in the city
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets client which this city is
        /// !!! SHOULD NOT BE USED !!!
        /// Created to address mapping issues for Client - City relationship
        /// </summary>
        public virtual ICollection<ClientEntity> LedClient { get; set; }
    }
}
