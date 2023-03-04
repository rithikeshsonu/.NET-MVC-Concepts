using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StateManagement.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //ViewBag and viewdata works similar. Only type casting is different /
            ViewData["subject"] = "Asp.net mvc";
            ViewBag.version = 5;
            ViewBag.colorList = new string[] { "Red", "orange", "blue" };
            //TempData data can be read only once 
            TempData["language"] = "English";
            TempData["age"] = "20-50 years";
            TempData["computer"] = "MS-Office";
            //Session will last for 20 minutes - default - We can change it in config file
            Session["username"] = "admin";

            HttpCookie myCookie = new HttpCookie("role");
            myCookie.Value = "Prime user";
            myCookie.Expires = DateTime.Now.AddMinutes(10);
            Response.Cookies.Add(myCookie);

            return View();
        }
        
        public ViewResult About()
        {
            if (Request.Cookies["role"] != null)
            {
                ViewBag.msg = Request.Cookies["role"].Value;
            }
            else
            {
                ViewBag.msg = "Cookie expired";
            }
            return View();
        }
    }
}