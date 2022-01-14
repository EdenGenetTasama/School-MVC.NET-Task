using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            try
            {

                return Ok(new { Student.listOfStudents });
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/StudentApi/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                Student student = Student.listOfStudents.Find(item => item.Id == id);
                return Ok(new { student });
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/StudentApi
        public IHttpActionResult Post([FromBody] Student student)
        {
            try
            {
                Student.listOfStudents.Add(student);
                return Ok("Added");
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/StudentApi/5
        public IHttpActionResult Put(int id, [FromBody] Student student)
        {
            try
            {

                Student studentToUpdate = Student.listOfStudents.First(item => item.Id == id);
                if (studentToUpdate !=  null)
                {
                    studentToUpdate.FirstName = student.FirstName;
                    studentToUpdate.LastName = student.LastName;
                    studentToUpdate.Age = student.Age;
                    studentToUpdate.Class = student.Class;
                }
                return Ok(studentToUpdate);
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/StudentApi/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                Student.listOfStudents.Remove(Student.listOfStudents.First(item => item.Id == id));
                return Ok("Delete");
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
