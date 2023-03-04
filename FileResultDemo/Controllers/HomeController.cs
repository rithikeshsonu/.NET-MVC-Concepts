using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FileResultDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //FileResult is used to display files on web page
        public FileResult Show()
        {
            //This line takes the file from specified path and displays when home/show is called
            return File(Server.MapPath("~/Content/TextFile1.txt"), "text/plain");
        }
        public FileResult DownloadFile()
        {
            return File(Server.MapPath("~/Content/TextFile1.txt"), "text/plain", "MVC5.txt");
            //first argument is the path Second arg is the type of file Third is the name which user will see on their page for downloading
        }
    }
}