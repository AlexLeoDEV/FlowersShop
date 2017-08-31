namespace FlowersShop.BLL.Interfaces
{
    using FlowersShop.BLL.DTO;
    using System.Collections.Generic;

    public interface ICityService
    {
        CityDto GetCity(int? id);
        IEnumerable<CityDto> GetCities();
        void Create(CityDto city);
        void Delete(int id);
        void Update(CityDto city);
        void Dispose();
        IEnumerable<string> GetCityName();
    }
}
