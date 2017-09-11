namespace FlowersShop.WEB.Models.Commodities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using FlowersShop.BLL.DTO;

    /// <summary>
    /// Represents commodity collections
    /// </summary>
    public class CommodityCollectionViewModel
    {
        private const int FIRST_PAGE = 1;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommodityCollectionViewModel"/> class
        /// </summary>
        /// <param name="source">All commodities</param>
        /// <param name="index">Index of page</param>
        /// <param name="size">Number of commodity on page</param>
        /// <param name="textToSearch">Substring to search</param>
        public CommodityCollectionViewModel(IEnumerable<CommodityDto> source, int? index, int size, string textToSearch)
        {
            TextToSearch = textToSearch;
            Size = size;
            PageNumber = index ?? FIRST_PAGE;
            NumberOfPages = (int)Math.Ceiling(source.Count() / (double)Size);

            if ((PageNumber > NumberOfPages) || (PageNumber < FIRST_PAGE))
            {
                throw new ArgumentOutOfRangeException();
            }

            var commodityList = new List<CommodityViewModel>(source.Skip((PageNumber - 1) * Size)
                            .Take(Size)
                            .ToList()
                            .Select(p => CommodityViewModel.Map(p)));

            List = new List<CommodityItemViewModel>();
            foreach (var commodity in commodityList)
            {
                List.Add(CommodityItemViewModel.Map(commodity));
            }
        }

        /// <summary>
        /// Gets or sets substring to search commodity
        /// </summary>
        public string TextToSearch { get; set; }

        /// <summary>
        /// Gets index of page
        /// </summary>
        public int PageNumber { get; private set; }

        /// <summary>
        /// Gets number of commodity on page
        /// </summary>
        public int Size { get; private set; }

        /// <summary>
        /// Gets number of pages
        /// </summary>
        public int NumberOfPages { get; private set; }

        /// <summary>
        /// Gets list of Commodities
        /// </summary>
        public List<CommodityItemViewModel> List { get; private set; }
    }
}