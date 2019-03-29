using System.Web;
using System.Web.Mvc;

namespace lab_37_ASPDOTNET_ActionFilters
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
