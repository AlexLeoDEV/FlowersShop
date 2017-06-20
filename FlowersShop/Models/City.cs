using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace FlowersShop.Models
{
    [Table("City")]
    public partial class City
    {
        public City()
        {
            Client = new HashSet<Client>();
        }

        [Key]
        public int id_City { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public int? id_Client { get; set; }
        
        public virtual ICollection<Client> Client { get; set; }
    }
}
