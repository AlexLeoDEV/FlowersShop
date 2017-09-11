namespace FlowersShop.BLL.Interfaces
{
    using FlowersShop.BLL.DTO;
    using System.Collections.Generic;

    public interface ICommoditiesByCategory
    {
        IEnumerable<CommoditiesByCategoryDto> GetBouquets();
        IEnumerable<CommoditiesByCategoryDto> GetBaskets();
        IEnumerable<CommoditiesByCategoryDto> GetMonoBouquets();
        IEnumerable<CommoditiesByCategoryDto> GetCompositions();
        IEnumerable<CommoditiesByCategoryDto> GetDreamBouquet();
        void Dispose();
    }
}
