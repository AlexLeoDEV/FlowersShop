using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowersShop.DAL.Entities
{

    [Table("Order")]
    public class Order
    {
        [Key]
        public int id_Order { get; set; }

        public int? id_Commodities { get; set; }

        public DateTime OrderTime { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal FullPrice { get; set; }

        public int? id_Client { get; set; }

        [Required]
        [StringLength(50)]
        public string Receiver { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        public Client Client { get; set; }

        public virtual Commodities Commodities { get; set; }
    }
}
