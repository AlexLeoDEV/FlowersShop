using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowersShop.BLL.DTO
{
    public class ClientDTO
    {
        public int id_Client { get; set; }

        public string Name { get; set; }

        public string CellPhone { get; set; }

        public string Email { get; set; }

        public string Gender { get; set; }

        public int? Age { get; set; }

        public int? id_City { get; set; }

        public CityDTO City { get; set; }
        
        public ICollection<OrderDTO> Order { get; set; }
    }
}
