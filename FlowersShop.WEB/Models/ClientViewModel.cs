using FlowersShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FlowersShop.WEB.Models
{
    public class ClientViewModel
    {
        public int id_Client { get; set; }

        public string Name { get; set; }

        public string CellPhone { get; set; }

        public string Email { get; set; }

        public string Gender { get; set; }

        public int? Age { get; set; }

        public int? id_City { get; set; }

        public CityEntity City { get; set; }
        
        public ICollection<OrderEntity> Order { get; set; }
    }
}