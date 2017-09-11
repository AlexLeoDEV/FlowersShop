namespace FlowersShop.BLL.Interfaces
{
    using FlowersShop.BLL.DTO;
    using System.Collections.Generic;

    public interface ICommoditiesService
    {
        CommodityDto GetCommodity(int? id);
        IEnumerable<CommodityDto> GetCommodities();
        void Create(CommodityDto commodity);
        void Delete(int id);
        void Update(CommodityDto commodity);
        void Dispose();
        int GetCommoditiesQuantity();
    }
}
