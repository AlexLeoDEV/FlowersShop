using FlowersShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowersShop.BLL.DTO
{
    public class CategoryDTO
    {
        public int id_Category { get; set; }

        public string Title { get; set; }
        
        public ICollection<CommodityDTO> Commodities { get; set; }
    }
}
