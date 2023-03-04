using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionSelectors.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //We specify action name when we want a particular method to be called by other name and we pass the name of view in return Type.
        [ActionName("aboutus")]
        public ViewResult About()
        {
            return View("about");
        }
        [NonAction]
        //We use non action when we don't want a method to not function anymore.
        public string Greet()
        {
            return "Hello, world!";
        }
        //By default, it uses action verb "GET" - [HttpGet]
        //[HttpPost] - Won't work because we can't call from Address bar. We can use it in form tag
        public ViewResult Contact()
        {
            return View();
        }
    }
}