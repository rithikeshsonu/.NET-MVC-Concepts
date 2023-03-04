using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewResultDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //View name and action method should be same.
        public ViewResult About()
        {
            return View();
        }
        public ViewResult Contact()
        {
            return View("ContactUs"); //When our View name and action method name is different specifty the view name in params
        }

        public ViewResult Product() //Automatically scans shared folder if no view is present in respective controller-view folder
        {
            return View();
        }
        //Displaying view of different controller.
        //We need to specify complete path from root of which ever controller's view you want to use.
        public ViewResult Display()
        {
            return View("~/Views/Account/Dashboard.cshtml");
        }
    }
}