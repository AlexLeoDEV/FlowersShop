using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlowersShop.WEB.Models
{
    public class CommoditiesByCategoryViewModel
    {
        public CategoryViewModel Category { get; set; }
        public CommodityViewModel Commodities { get; set; }
    }
}