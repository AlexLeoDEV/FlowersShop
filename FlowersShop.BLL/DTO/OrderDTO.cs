using FlowersShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowersShop.BLL.DTO
{
    public class OrderDTO
    {
        public int id_Order { get; set; }

        public int? id_Commodities { get; set; }

        public DateTime OrderTime { get; set; }

        public int Quantity { get; set; }

        public decimal FullPrice { get; set; }

        public int? id_Client { get; set; }

        public string Receiver { get; set; }

        public string Address { get; set; }

        public ClientDTO Client { get; set; }

        public CommodityDTO Commodities { get; set; }
    }
}
