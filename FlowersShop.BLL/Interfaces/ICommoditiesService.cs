using FlowersShop.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace FlowersShop.BLL.Interfaces
{
    public interface ICommoditiesService
    {
        CommodityDTO GetCommodity(int? id);
        IEnumerable<CommodityDTO> GetCommodities();
        void Create(CommodityDTO commodity);
        void Delete(int id);
        void Update(CommodityDTO commodity);
        void Dispose();
        SelectList GetListCategories();
        //IEnumerable<string> GetCommodityName();
    }
}
