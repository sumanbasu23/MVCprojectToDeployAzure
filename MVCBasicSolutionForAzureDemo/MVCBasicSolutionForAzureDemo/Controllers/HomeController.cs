using MVCBasics.Filters;
using MVCBasics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasics.Controllers
{
    public class HomeController : Controller
    {
        
        // GET: Home
       // [CustomAuthentification]
        public ActionResult Index()
        {
            ViewBag.Countries = new List<string>()
            {
                "USA",
                "UK",
                "AUSTRALIA",
                "INDIA"

            };
            return View();
        }

        public ActionResult Registration()
        {
            Registration registrationModel = new Registration();
            return View(registrationModel);
        }

        [HttpPost]
        public ActionResult Registration(Registration registration)
        {
            
            if(ModelState.IsValid)
            {
               return RedirectToAction("Index");
            }
            else
             return View(registration);
        }

        public ActionResult CheckUserExist(string UserName)
        {
            if (UserName.Equals("SBasu"))
            {
                return Json("UserName is already exist", JsonRequestBehavior.AllowGet);
            }
            else
                return Json("true", JsonRequestBehavior.AllowGet);
        }
    }
}