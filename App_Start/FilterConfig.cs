using System.Web;
using System.Web.Mvc;

namespace u24987230_INF_272_PRACTICAL_1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
