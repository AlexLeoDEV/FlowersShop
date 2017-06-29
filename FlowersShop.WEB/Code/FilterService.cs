using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlowersShop.WEB.Code
{
    public static class FilterService
    {
        public static bool CheckFilter(string item)
        {
            if (!String.IsNullOrEmpty(item))
            {
                if (!item.Equals("All"))
                {
                    return true;
                }
            }
            return false;
        }
    }
}