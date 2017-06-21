using FlowersShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FlowersShop.WEB.Models
{
    public class CityViewModel
    {
        public int id_City { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public int? id_Client { get; set; }

        public ICollection<Client> Client { get; set; }
    }
}