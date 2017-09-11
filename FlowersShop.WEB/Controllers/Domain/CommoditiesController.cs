namespace FlowersShop.WEB.Controllers
{
    using BLL.Interfaces;
    using System.Linq;
    using System.Web.Mvc;
    using Models.Commodities;

    /// <summary>
    /// Defines commodities controller
    /// </summary>
    public class CommoditiesController : Controller
    {
        private readonly ICommoditiesService _commoditiesService;

        private const int MAX_ITEMS_ON_PAGE = 8;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommoditiesController"/> class
        /// </summary>
        /// <param name="commoditiesService">The interface reference of commodities service</param>
        public CommoditiesController(ICommoditiesService commoditiesService)
        {
            _commoditiesService = commoditiesService;
        }

        public CommoditiesController()
        {
        }

        /// <summary>
        /// Gets commodities list from CommoditiesService
        /// </summary>
        /// <param name="searchCommodity"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public ViewResult Index(string searchCommodity, int page = 1)
        {
            var commodities = GetCommodityCollectionViewModel(page, searchCommodity);
            var referrerViewModel =  new CommodityCollectionRefererViewModel(commodities, HttpContext.Request.RawUrl);

            return View(referrerViewModel);
        }

        /// <summary>
        /// Gets details for specific commodity
        /// </summary>
        /// <param name="id">Commodity Id</param>
        /// <param name="returnUrl">URL for back link</param>
        /// <returns>View with specific player.</returns>
        public ActionResult Details(int id, string returnUrl = "")
        {
            var commodity = _commoditiesService.GetCommodity(id);

            if (commodity == null)
            {
                return HttpNotFound();
            }

            var model = new CommodityRefererViewModel(commodity, HttpContext.Request.RawUrl);
            return View(model);
        }

        private CommodityCollectionViewModel GetCommodityCollectionViewModel(int? page, string textToSearch = "")
        {
            var allCommodities = _commoditiesService.GetCommodities();

            if (!string.IsNullOrEmpty(textToSearch))
            {
                textToSearch = textToSearch.Trim();
                allCommodities = allCommodities.Where(p => (p.Name).Contains(textToSearch)
                                                   || (p.Name).Contains(textToSearch));
            }

            return new CommodityCollectionViewModel(allCommodities, page, MAX_ITEMS_ON_PAGE, textToSearch);
        }
    }
}