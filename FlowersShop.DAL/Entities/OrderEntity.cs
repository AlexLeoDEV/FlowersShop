namespace FlowersShop.DAL.Entities
{
    using System;

    /// <summary>
    /// DAL order model
    /// </summary>
    public class OrderEntity
    {
        /// <summary>
        /// Gets or sets order id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets commodityId of order
        /// </summary>
        public int CommodityId { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public DateTime OrderTime { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public decimal FullPrice { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public int ClientId { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public string Receiver { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public ClientEntity Client { get; set; }

        /// <summary>
        /// Gets or sets
        /// </summary>
        public virtual CommoditiesEntity Commodity { get; set; }
    }
}
