using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowersShop.DAL.Entities
{
    [Table("Client")]
    public class Client
    {
        public Client()
        {
            Order = new HashSet<Order>();
        }

        [Key]
        public int id_Client { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(13)]
        public string CellPhone { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Gender { get; set; }

        public int? Age { get; set; }

        public int? id_City { get; set; }

        public virtual City City { get; set; }
        
        public virtual ICollection<Order> Order { get; set; }
    }
}
