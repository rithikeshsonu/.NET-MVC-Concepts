using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutView.Controllers
{
    public class CourseDetailsController : Controller
    {
        // GET: CourseDetails
        public ViewResult DotNet()
        {
            return View();
        }
        public ViewResult PHP()
        {
            return View();
        }
        [ChildActionOnly] //--Only executed when called from within a view. Can't directly execute it. Only accepted by child request 
        public PartialViewResult Sidebar()
        {
            string[] courses = { "PHP", "Dotnet", "Java", "DBMS" };
            return PartialView("_Sidebar", courses);
        }

    }
}