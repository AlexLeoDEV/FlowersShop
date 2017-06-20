using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace FlowersShop.Models
{
    [Table("Category")]
    public partial class Category
    {        
        public Category()
        {
            Commodities = new HashSet<Commodities>();
        }

        [Key]
        public int id_Category { get; set; }

        [Required]
        public string Title { get; set; }
        
        public virtual ICollection<Commodities> Commodities { get; set; }
    }
}
