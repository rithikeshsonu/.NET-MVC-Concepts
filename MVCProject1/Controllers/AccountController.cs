using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject1.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ViewResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection values)
        {
            if (values["user"] == "admin" && values["pass"] == "1234")
            {
                Session["uname"] = "admin";
                return RedirectToAction("personal", "student");
            }
            else
            {
                ViewBag.msg = "Invalid";
                return View();
            }
        }

    }
}