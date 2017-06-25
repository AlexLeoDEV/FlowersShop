using FlowersShop.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace FlowersShop.BLL.Interfaces
{
    public interface ICommoditiesByCategory
    {
        IEnumerable<CommoditiesByCategoryDTO> GetBouquets();
        IEnumerable<CommoditiesByCategoryDTO> GetBaskets();
        IEnumerable<CommoditiesByCategoryDTO> GetMonoBouquets();
        IEnumerable<CommoditiesByCategoryDTO> GetCompositions();
        IEnumerable<CommoditiesByCategoryDTO> GetDreamBouquet();
        void Dispose();
    }
}
