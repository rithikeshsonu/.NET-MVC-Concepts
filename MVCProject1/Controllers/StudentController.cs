using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject1.Controllers
{
    [RoutePrefix("student")]
    public class StudentController : Controller
    {
        [Route("personal-details")]
        // GET: Student
        public ViewResult Personal()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Personal(string sname, string contact, string address)
        {
            if(sname == "" || contact== "" || address == "")
            {
                ViewBag.msg = "Please enter all details";
                return View();
            }
            else
            {
                TempData["sname"] = sname;
                TempData["address"] = address;
                TempData["contact"] = contact;
                return RedirectToAction("marks"); // view in same controller
            }
        }
        [Route("mark-details")]
        public ViewResult Marks()
        {
            return View();
        }
        [HttpPost]
        //public ActionResult Marks(int theory, int practical, int oral)
        public ActionResult Marks(int theory = 0, int practical = 0, int oral = 0)
        {
            if(theory < 0 || theory > 100 || practical < 0 || practical > 100 || oral < 0 || oral > 100)
            {
                ViewData["msg"] = "Invalid marks. Please enter between 0-100";
                return View();
            }
            else
            {
                TempData["theory"] = theory;
                TempData["practical"] = practical;
                TempData["oral"] = oral;

                return RedirectToAction("displayResult");

            }
        }
        [Route("marksheet")]
        public ViewResult DisplayResult()
        {
            return View();
        }
    }
}