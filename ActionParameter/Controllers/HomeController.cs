using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionParameter.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult List()
        {
            return View();
        }
        //public ContentResult Details()
        //{
        //    int a = Convert.ToInt32(Request["id"]);
        //    string country = "";
        //    switch (a)
        //    {
        //        case 1: country = "India"; break;
        //        case 2: country = "USA"; break;
        //        case 3: country = "China"; break;
        //        default: country = "You are out of this world!!"; break;
        //    }
        //    return Content(country); //returns string
        //}

        //TRADITIONAL method
        /*
        public ContentResult Details()
        {
            int a = Convert.ToInt32(Request.QueryString["id"]);
            //Works same as above line
            //int a = Convert.ToInt32(Request["id"]); 
            string country = "";
            switch (a)
            {
                case 1: country = "India"; break;
                case 2: country = "USA"; break;
                case 3: country = "China"; break;
                default: country = "You are out of this world!!"; break;
            }
            return Content(country); //returns string
        }
        */
        public ContentResult Details(int id)
        {
            string country = "";
            switch (id)
            {
                case 1: country = "India"; break;
                case 2: country = "USA"; break;
                case 3: country = "China"; break;
                default: country = "You are out of this world!!"; break;
            }
            return Content(country); //returns string
        }
    }
}