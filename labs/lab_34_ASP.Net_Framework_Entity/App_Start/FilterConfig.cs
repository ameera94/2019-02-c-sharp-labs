using System.Web;
using System.Web.Mvc;

namespace lab_34_ASP.Net_Framework_Entity
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
