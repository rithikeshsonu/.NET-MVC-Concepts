using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HTMLHelperMVC.Models; //imported from Model class

namespace HTMLHelperMVC.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            ViewBag.username = "test";
            return View();
        }
        [HttpPost]
        public ViewResult Login(FormCollection values)
        {
            return View();
        }
        //Strongly typed HTML Helpers 
        public ViewResult Register()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Register(RegisterViewModel model)
        {
            return View();
        }
    }
}