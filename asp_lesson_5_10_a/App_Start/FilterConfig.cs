﻿using System.Web;
using System.Web.Mvc;

namespace asp_lesson_5_10_a
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
