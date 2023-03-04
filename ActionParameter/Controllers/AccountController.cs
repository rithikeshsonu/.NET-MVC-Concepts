using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionParameter.Controllers
{
    public class AccountController : Controller
    {
        public ViewResult Login()
        {
            return View();
        }
        //Can't browse/directly go to the url home/validate when using httppost, we only have to go through form(after entering details).
        /*[HttpPost]
        public ContentResult Validate()
        {
            string u = Request["uname"];
            string p = Request["pass"];

            if (u == "Sonu" && p == "Hrithik") //Hardcoding
                return Content("welcome");
            else
                return Content("Sorry! Wrong credentials");
        }
        */
        //Works same like above code
        //TRADITIONAL METHOD
        /*
        public ContentResult Validate(FormCollection values)
        {
            string u = values["uname"];
            string p = values["pass"];
            if (u == "Sonu" && p == "Hrithik") //Hardcoding
                return Content("welcome");
            else
                return Content("Sorry! Wrong credentials");
        }
        */

        //Model binding - Feasible with less number of input fields.
        //[HttpPost]
        //Works same as above snipped
        public ContentResult Validate(string uname, string pass)
        {
            if (uname == "Sonu" && pass == "Hrithik")
                return Content("Welcome "+ uname);
            else
                return Content("Sorry, wrong credentials");
        }
    }
}