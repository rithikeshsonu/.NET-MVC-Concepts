using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedirectToRouteResultDemo.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ViewResult Register()
        {
            return View();
        }
    }
}