namespace FlowersShop.BLL.DTO
{
    using System;
    using System.Collections.Generic;

    public class CommodityDto
    {
        public int CommodityId { get; set; }

        public string Name { get; set; }

        public string Colour { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public bool IsHandMade { get; set; }

        public int CategoryId { get; set; }

        public string ImagePath { get; set; }

        public string Preferences { get; set; }

        public CategoryDto CategoryDto { get; set; }

        public ICollection<OrderDto> OrderDto { get; set; }
    }
}
