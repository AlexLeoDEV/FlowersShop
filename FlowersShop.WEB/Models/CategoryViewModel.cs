using FlowersShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlowersShop.WEB.Models
{
    public class CategoryViewModel
    {
        public int id_Category { get; set; }
        public string Title { get; set; }
        
        public ICollection<Commodities> Commodities { get; set; }
    }

    public enum Categories
    {
        FlowerComposition = 1,
        MonoBouquet = 2,
        Bouquet = 3,
        FlowerBasket = 4,
    }
}