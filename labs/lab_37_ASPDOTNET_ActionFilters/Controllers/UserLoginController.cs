using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab_37_ASPDOTNET_ActionFilters.Models;

namespace lab_37_ASPDOTNET_ActionFilters.Controllers
{
    public class UserLoginController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Login(LoginModel model)      
        {
            if (model.Username =="Test" && model.Password == "Test")
            {
                Session["UserID"] = Guid.NewGuid(); //Setting User Session
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Invalid login attempt.");
                return View(model);
            }
        }
    }
}