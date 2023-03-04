using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContentResultDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //ContentResult returns a string
        public ContentResult Greet()
        {
            return Content("Hello, World!");
        }
        //This works similar to above snippet(ContentResult)
        public string Say()
        {
            return "Hello, everyone!";
        }
        public int Add()
        {
            int num1 = 4;
            int num2 = 5;
            int sum = num1 + num2;
            return sum;
        }
    }
}