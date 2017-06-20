using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace FlowersShop.Models
{    
    public partial class Commodities
    {
        public Commodities()
        {
            Order = new HashSet<Order>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_Commodities { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        public string Colour { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Required]
        public string Description { get; set; }

        public bool IsHandMade { get; set; }

        public int id_Category { get; set; }

        [Required]
        public string image { get; set; }

        [StringLength(50)]
        public string Preferences { get; set; }

        public virtual Category Category { get; set; }
        
        public virtual ICollection<Order> Order { get; set; }
    }
}
