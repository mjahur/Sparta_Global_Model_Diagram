﻿using System.Web;
using System.Web.Mvc;

namespace ASPDOTNETDataModelling_Users
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
