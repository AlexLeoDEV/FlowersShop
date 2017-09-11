namespace FlowersShop.WEB.Models.Commodities
{
    using FlowersShop.WEB.Models.Generic;

    public class CommodityCollectionRefererViewModel : RefererViewModel<CommodityCollectionViewModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommodityCollectionRefererViewModel" /> class.
        /// </summary>
        /// <param name="commodity">Commodity collection view model.</param>
        /// <param name="referer">Referrer controller name.</param>
        public CommodityCollectionRefererViewModel(CommodityCollectionViewModel commodity, string referer) 
            : base(commodity, referer)
        {
        }
    }
}