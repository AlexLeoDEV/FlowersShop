using FlowersShop.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace FlowersShop.BLL.Interfaces
{
    public interface ICityService
    {
        CityDTO GetCity(int? id);
        IEnumerable<CityDTO> GetCities();
        void Create(CityDTO city);
        void Delete(int id);
        void Update(CityDTO city);
        void Dispose();

        //SelectList GetListClients();
        IEnumerable<string> GetCityName();
    }
}
