namespace FlowersShop.WEB.Models.Commodities
{
    using Generic;
    using FlowersShop.BLL.DTO;

    /// <summary>
    /// Represents CommodityViewModel and referrer link.
    /// </summary>
    public class CommodityRefererViewModel : RefererViewModel<CommodityViewModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommodityRefererViewModel" /> class.
        /// </summary>
        /// <param name="commodity">Commodity collection view model.</param>
        /// <param name="referer">Referrer controller name.</param>
        public CommodityRefererViewModel(CommodityDto commodity, string referer) 
            : base(CommodityViewModel.Map(commodity), referer)
        {
        }
    }
}