namespace FlowersShop.WEB.Models
{
    using FlowersShop.DAL.Entities;
    using System.Collections.Generic;

    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public ICollection<CommoditiesEntity> Commodities { get; set; }
    }

    public enum Categories
    {
        FlowerComposition = 1,
        MonoBouquet = 2,
        Bouquet = 3,
        FlowerBasket = 4,
    }
}