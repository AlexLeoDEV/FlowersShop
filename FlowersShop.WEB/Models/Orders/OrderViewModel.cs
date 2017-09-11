namespace FlowersShop.WEB.Models
{
    using FlowersShop.DAL.Entities;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public class OrderViewModel
    {
        public int Id { get; set; }

        public int? CommodityId { get; set; }

        public DateTime OrderTime { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal FullPrice { get; set; }

        public int? ClientId { get; set; }

        public string Receiver { get; set; }

        public string Address { get; set; }

        public ClientEntity Client { get; set; }

        public CommoditiesEntity Commodities { get; set; }
    }
}