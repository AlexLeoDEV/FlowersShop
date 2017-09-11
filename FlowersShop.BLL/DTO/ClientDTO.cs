namespace FlowersShop.BLL.DTO
{
    using System;
    using System.Collections.Generic;

    public class ClientDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string CellPhone { get; set; }

        public string Email { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }

        public int CityId { get; set; }

        public CityDto CityDto { get; set; }
        
        public ICollection<OrderDto> OrderDto { get; set; }
    }
}
