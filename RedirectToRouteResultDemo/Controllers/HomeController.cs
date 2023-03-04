using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedirectToRouteResultDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Contact()
        {
            return View();
        }
        public RedirectToRouteResult ShowContact()
        {
            //redirect to home controller's contact view
            //return RedirectToRoute(new { Controller = "home", action = "contact" });
            return RedirectToAction("contact");
        }
        public RedirectToRouteResult SignUp()
        {
            return RedirectToAction("Register", "Account");
        }
        private void DefineAnonymous()
        {
            var student = new { rollno = 10, name = "Sonu" };
        }
    }
}