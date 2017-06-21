using FlowersShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

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

        public Category Category { get; set; }

        public ICollection<Order> Order { get; set; }
    }
}