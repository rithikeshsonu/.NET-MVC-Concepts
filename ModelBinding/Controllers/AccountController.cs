using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelBinding.Models; //imported from User model

namespace ModelBinding.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        /*
        //primitive model binding(Primitive data types)
        [HttpPost]
        public ContentResult Login(string username, string password)
        {
            if (username == "scott" && password == "tiger")
            {
                return Content("Welcome Scott");
            }
            else
            {
                return Content("Sorry " + username);
            }
        }
        */
        //Complex model binding
        //only create one object and start writing each fields in the code unlike primitive model binding
        [HttpPost]
        public ContentResult Login(User obj)
        {
            if (obj.Username == "scott" && obj.Password == "tiger")
            {
                return Content("Welcome Scott");
            }
            else
            {
                return Content("Sorry " + obj.Username);
            }
        }
    }
}