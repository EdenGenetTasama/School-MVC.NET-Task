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

        // GET: api/StudentApi

        public IHttpActionResult Get()
        {
            return Ok(new { Student.listOfStudents });
        }

        // GET: api/StudentApi/5
        public IHttpActionResult Get(int id)
        {
            Student student = Student.listOfStudents.Find(item => item.Id == id);
            return Ok(new { student});
        }

        // POST: api/StudentApi
        public IHttpActionResult Post([FromBody] Student student)
        {
            Student.listOfStudents.Add(student);
            return Ok("Added");
        }

        // PUT: api/StudentApi/5
        public IHttpActionResult Put(int id, [FromBody] Student student)
        {
            Student studentToUpdate = Student.listOfStudents.First(item => item.Id == id);
            if (studentToUpdate !=  null)
            {
                studentToUpdate.
            }
            return Ok();
        }

        // DELETE: api/StudentApi/5
        public IHttpActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
