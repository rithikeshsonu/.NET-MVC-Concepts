using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel.Models;

namespace ViewModel.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult WithoutViewModel()
        {
            Student Sobj = new Student() {Rollno = 3, Name = "Priya" };
            Assessment aObj = new Assessment() { CSharpMarks = 30, MVCMarks = 40, BootStrapMarks = 50 };
            ViewBag.assessmentDetails = aObj;

            return View(Sobj);
        }
        public ViewResult WithViewModel()
        {
            Student Sobj = new Student() { Rollno = 3, Name = "Priya" };
            Assessment aObj = new Assessment() { CSharpMarks = 30, MVCMarks = 40, BootStrapMarks = 50 };
            Marksheet mObj = new Marksheet();
            mObj.MyStudent = Sobj;
            mObj.MyAssessment = aObj;
            return View(mObj);
        }
    }
}