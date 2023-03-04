using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AttributeRouting.Controllers
{
    [RoutePrefix("admin")] //If all the views are using same controller's actions, use routePrefix
    public class AccountController : Controller
    {
        // GET: Account
        [Route("signin")] //our current URL looks like this -> admin/signin
        public ViewResult Login() //Default URL-> account/login ; Make it URL Pattern-> admin/signin
        {
            return View();
        }

        [Route("signup")]
        public ViewResult Register()
        {
            return View();
        }

        [Route("reset-password")]
        public  ViewResult ChangePassword()
        {
            return View();
        }
        //[Route("Display/{sid:range(1, 100)}")] //only takes 1 to 100 in input , else shows error
        [Route("Display/{sid:regex(\\d{3})}")] //only takes 3/more digit number as input
        public ContentResult Show(int sid) //admin/display/1 -> Called Route Value
        {
            return Content(sid.ToString());
        }
    }
}