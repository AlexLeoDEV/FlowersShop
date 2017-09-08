namespace FlowersShop.WEB.Models
{
    using FlowersShop.DAL.Entities;
    using System.Collections.Generic;

    public class CityViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal DeliveryPrice { get; set; }

        public int? ClientId { get; set; }

        public ICollection<ClientEntity> Client { get; set; }
    }
}