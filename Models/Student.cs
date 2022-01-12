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



    }
}