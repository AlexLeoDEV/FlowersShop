﻿namespace FlowersShop.WEB.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using FlowersShop.WEB.Models.Menu;

    /// <summary>
    /// Represents navigation menu controller
    /// </summary>
    public class NavigationController : Controller
    {
        /// <summary>
        /// Create list of menu items
        /// </summary>
        /// <returns> Partial view of the menu. </returns>
        public PartialViewResult Menu()
        {
            string controllerName = (string)Request.RequestContext.RouteData.Values["controller"];
            var items = new List<MenuItemViewModel>
            {
                new MenuItemViewModel { Name = "Bouquets", Controller = "CommoditiesByCategoryController", Action = "GetBouquets" },
                new MenuItemViewModel { Name = "Baskets", Controller = "CommoditiesByCategoryController", Action = "GetBaskets" },
                new MenuItemViewModel { Name = "Mono bouquets", Controller = "CommoditiesByCategoryController", Action = "GetMonoBouquets" },
                new MenuItemViewModel { Name = "Compositions", Controller = "CommoditiesByCategoryController", Action = "GetCompositions" },
                new MenuItemViewModel { Name = "Dream Bouquet", Controller = "CommoditiesByCategoryController", Action = "GetDreamBouquet" }
            };

            var queryableItems = items.AsQueryable();

            var currentItem = queryableItems.Where(item =>
                string.Equals(item.Controller, controllerName, StringComparison.OrdinalIgnoreCase));

            if (currentItem.Count() > 0)
            {
                currentItem.First().IsCurrent = true;
            }

            return PartialView(queryableItems);
        }
    }
}