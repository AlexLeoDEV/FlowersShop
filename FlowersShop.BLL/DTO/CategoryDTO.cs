namespace FlowersShop.BLL.DTO
{
    using System;
    using System.Collections.Generic;

    public class CategoryDto
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }
        
        public ICollection<CommodityDto> CommodityDto { get; set; }
    }
}
