using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedirectResultDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index() //localhost/home/Index
        {
            return View();
        }
        //Redirecting to internal URL
        public RedirectResult ShowInternal() //localhost/home/showinternal
        {
            return Redirect("/home/index"); //redirects to the url mentioned in the string
        }
        public RedirectResult ShowExternal()
        {
            return Redirect("https://www.google.com/");
        }
    }
}