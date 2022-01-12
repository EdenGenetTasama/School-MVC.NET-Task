using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers.api
{
    public class StudentApiController : ApiController
    {
        List<Student> listOfStudents = new List<Student>()
        {
           new Student(0, "Eden" , "Tasama" , 7 , 25),
           new Student(1, "Yafit" , "Samuel" , 8 , 28),
           new Student(2, "Keren" , "Hailu" ,9 , 50),
           new Student(3, "Tikva" , "Yosef" , 10 , 70),
        };
        // GET: api/StudentApi
        public IHttpActionResult Get()
        {
            return Ok(listOfStudents);
        }

        // GET: api/StudentApi/5
        public IHttpActionResult Get(int id)
        {
            Student student = listOfStudents.Find(item => item.Id == id);
            return Ok(student);
        }

        // POST: api/StudentApi
        public IHttpActionResult Post([FromBody] Student student)
        {
            Student studentAdd = new Student( 5,"Daniel" , "Tal" , 10 , 23 );
            listOfStudents.Add(studentAdd);
            return Ok("Added");
        }

        // PUT: api/StudentApi/5
        public IHttpActionResult Put(int id, [FromBody] string value)
        {
            return Ok();
        }

        // DELETE: api/StudentApi/5
        public IHttpActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
