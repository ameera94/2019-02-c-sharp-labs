using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc; 
using System.Web.Mvc.Filters;


namespace lab_37_ASPDOTNET_ActionFilters.AuthData
{
    public class UserAuthenticationFilter : ActionFilterAttribute, IAuthenticationFilter
    {
        //    //executed first and can be used to the perform any needed authentication
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            //check session is empty then set as result is HttpUnauthorizedResult 
            if (string.IsNullOrEmpty(Convert.ToString(filterContext.HttpContext.Session["UserID"])))
            {
                filterContext.Result = new HttpUnauthorizedResult();
            }
            

        }

        //    //used to restrict access based upon the authenticated user's principal. Runs after the OnAuthentication method.
        //OnAuthenticationChallenge: if method gets called when Authentication or Authorization is failed and this method is called after
        //Execution of Action Method but before rendering of View. 
        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            //We are checking Result is null or Result is HttpUnauthorizedResult
            //if yes then we are Redirect to Error View
            if (filterContext.Result == null || filterContext.Result is HttpUnauthorizedResult)
            {
                filterContext.Result = new ViewResult
                {
                    ViewName = "Error"
                };
            }

        }
    }
}