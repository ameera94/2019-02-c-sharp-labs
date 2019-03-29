using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace lab_37_ASPDOTNET_ActionFilters.Controllers
{
    public class TestingFilters : ActionFilterAttribute
    {
        private void LoggingMethod(RouteData rd)
        {
            var controller = rd.Values["Controller"];
            var action = rd.Values["action"];
            string message = string.Format("Controller: {0}: Action: {1}", controller, action);

        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            LoggingMethod(filterContext.RouteData);
        }

    }
}