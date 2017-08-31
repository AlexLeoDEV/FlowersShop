namespace FlowersShop.DAL.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// DAL client model
    /// </summary>
    public class ClientEntity
    {
        /// <summary>
        /// Gets or sets client id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets client name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets client phone
        /// </summary>
        public string CellPhone { get; set; }

        /// <summary>
        /// Gets or sets client email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets client gender
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets client age
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Gets or sets client's city id
        /// </summary>
        public int CityId { get; set; }

        /// <summary>
        /// Gets or sets client city
        /// </summary>
        public virtual CityEntity City { get; set; }

        /// <summary>
        /// Gets or sets client's order collection
        /// </summary>
        public virtual ICollection<OrderEntity> Order { get; set; }
    }
}
