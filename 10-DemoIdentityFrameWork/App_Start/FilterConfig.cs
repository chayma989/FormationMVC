using System.Web;
using System.Web.Mvc;

namespace _10_DemoIdentityFrameWork
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
