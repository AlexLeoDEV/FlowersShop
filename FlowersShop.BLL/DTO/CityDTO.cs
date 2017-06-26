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
    public class CityDTO
    {
        public int id_City { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }
    }
}
