namespace FlowersShop.BLL.DTO
{
    using System;

    public class OrderDto
    {
        public int Id { get; set; }

        public int CommodityId { get; set; }

        public DateTime OrderTime { get; set; }

        public int Quantity { get; set; }

        public decimal FullPrice { get; set; }

        public int ClientId { get; set; }

        public string Receiver { get; set; }

        public string Address { get; set; }

        public ClientDto ClientDto { get; set; }

        public CommodityDto CommodityDto { get; set; }
    }
}
