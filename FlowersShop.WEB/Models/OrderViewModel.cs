using FlowersShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FlowersShop.WEB.Models
{
    public class OrderViewModel
    {
        public int id_Order { get; set; }

        public int? id_Commodities { get; set; }

        public DateTime OrderTime { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal FullPrice { get; set; }

        public int? id_Client { get; set; }

        public string Receiver { get; set; }

        public string Address { get; set; }

        public ClientEntity Client { get; set; }

        public CommoditiesEntity Commodities { get; set; }
    }
}