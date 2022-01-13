using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Class { get; set; }
        public int Age { get; set; }
        public Student(int id, string firstName, string lastName, int @class, int age)
        {
            this.Id=id;
            this.FirstName=firstName;
            this.LastName=lastName;
            this.Class=@class;
            this.Age=age;
        }



       public static List<Student> listOfStudents = new List<Student>()
        {
           new Student(0, "Eden" , "Tasama" , 7 , 25),
           new Student(1, "Yafit" , "Samuel" , 8 , 28),
           new Student(2, "Keren" , "Hailu" ,9 , 50),
           new Student(3, "Tikva" , "Yosef" , 10 , 70),
        };
    }
}