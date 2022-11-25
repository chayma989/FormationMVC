using _4_DemoActionFilter.Filtres;
using System.Web;
using System.Web.Mvc;

namespace _4_DemoActionFilter
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LogFilter());
        }
    }
}
