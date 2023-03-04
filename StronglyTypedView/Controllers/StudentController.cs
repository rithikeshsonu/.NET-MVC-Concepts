using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StronglyTypedView.Models; //We need to import Model namespace

namespace StronglyTypedView.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ViewResult Index()
        {
            Student st = new Student() { Rollno = 1, Name = "Priya", Address = "Hyderabad", Course = "MBA" };
            return View(st);
        }
        public ViewResult List()
        {
            List<Student> lst = new List<Student>()
            {
                new Student{Rollno = 1, Name = "x", Address = "Mum", Course = "Btech"},
                new Student{Rollno = 2, Name = "y", Address = "Pune", Course = "MCA"},
                new Student{Rollno = 3, Name = "z", Address = "Pune", Course = "MCA"},
            };
            return View(lst);
        }
    }
}