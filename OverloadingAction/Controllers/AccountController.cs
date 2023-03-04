using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OverloadingAction.Controllers
{
    public class AccountController : Controller
    {
        
        // GET: Account
        [HttpGet] //default
        public ActionResult Register()
        {
            return View();
        }
        //if we don't mention http action verb, GET will be used by default
        [HttpPost]
        public ContentResult Register(string name, string address, string phone, string email, string pass, string confirmPass)
        {
            if (pass == confirmPass)
                return Content("Registration success");
            else
                return Content("Registration fail");
        }
    }
}