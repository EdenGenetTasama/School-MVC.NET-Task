using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        Student[] studentArray = new Student[]
        {
           new Student(0, "Eden" , "Tasama" , 7 , 25),
           new Student(1, "Yafit" , "Samuel" , 8 , 28),
           new Student(2, "Keren" , "Hailu" ,9 , 50),
           new Student(3, "Tikva" , "Yosef" , 10 , 70),

        };

        // GET: Student
        public ActionResult GetStudentName()
        {
            ViewBag.StudentName = studentArray[0].FirstName;
            return View();
        }

        public ActionResult GetStudentInfo()
        {

            return View(studentArray);
        }

        public ActionResult GetById(int Id)
        {
            foreach (Student student in studentArray)
            {
                if (student.Id == Id)
                {
                    ViewBag.matchId = $"{student.Id}, {student.FirstName} , {student.LastName} , {student.Age}, {student.Class}";
                }
                ViewBag.Massage = "Not Found";
            }
            return View();
        }


    }
}