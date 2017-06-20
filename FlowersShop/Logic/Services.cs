using FlowersShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlowersShop.Logic
{
    public static class Services
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