using FlowersShop.DAL.Entities;
using FlowersShop.WEB.Models.Additional;
using System.Collections.Generic;

namespace FlowersShop.WEB.Models
{
    public class CommodityViewModel
    {
        public int id_Commodities { get; set; }

        public string Title { get; set; }

        public string Colour { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public bool IsHandMade { get; set; }

        public int id_Category { get; set; }

        public string image { get; set; }

        public string Preferences { get; set; }

        public CategoryEntity Category { get; set; }

        public ICollection<OrderEntity> Order { get; set; }
    }
    public class CommoditiesFilter
    {
        public IEnumerable<CommodityViewModel> Commodities { get; set; }
        public PagingInfo PgInfo { get; set; }
    }
}