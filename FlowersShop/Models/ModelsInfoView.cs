using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowersShop.Models
{
    public class ModelsInfoView
    {
        public Category Category { get; set; }
        public Commodities Commodities { get; set; }
        public City City { get; set; }
        public Client Client { get; set; }
        public Order Order { get; set; }
    }
}
