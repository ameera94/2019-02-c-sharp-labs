using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab_36_ASPDOTNETIIS.Models;

namespace lab_36_ASPDOTNETIIS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Message = "Your application description page.";

            return View("CreateFormEmpty");
        }

        [HttpPost]
        public ActionResult Create(Pet pet) //overload - must use http annotations to differentiate
        {
            ViewBag.Message = "Your application description page.";

            return View("Create");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}