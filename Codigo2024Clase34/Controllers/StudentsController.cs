using Codigo2024Clase34.Models;
using Codigo2024Clase34.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace Codigo2024Clase34.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public List<Student> Get()
        {
            using(var context = new DataBaseContext())
            {
                return context.Students.Where(x => x.Enable == true).ToList();
            }
        }
        [HttpGet]
        public Student GetById(int _studentID)
        {
            using(var context = new DataBaseContext())
            {
                return context.Students.Find(_studentID);
            }
        }

        [HttpPost]
        public Response Insert(StudentDTO _student)
        {
            Response response = new Response();
            using(var context = new DataBaseContext())
            {
                try
                {
                    Student student = new Student();
                    context.Students.Add(student);
                    context.SaveChanges();
                    response.ResponseCode = 200;
                    response.ResponseMessage = "OK";
                }
                catch(Exception ex)
                {
                    response.ResponseCode = 500;
                    response.ResponseMessage = ex.Message;
                }
            }
            return response;
        }

        [HttpPut]
        public Response Update(Student _student)
        {
            Response response = new Response();
            using (var context = new DataBaseContext())
            {
                try
                {
                    context.Entry(_student).State = EntityState.Modified;
                    context.SaveChanges();
                    response.ResponseCode = 200;
                    response.ResponseMessage = "OK";
                }
                catch (Exception ex)
                {
                    response.ResponseCode = 500;
                    response.ResponseMessage = ex.Message;
                }
            }
            return response;
        }

        [HttpDelete]
        public Response Delete(int _studentID)
        {
            Response response = new Response();
            using( var context = new DataBaseContext())
            {
                try
                {
                    var student = context.Students.Find(_studentID);
                    student.Enable = false;
                    context.Entry(student).State = EntityState.Modified;
                    context.SaveChanges();
                    response.ResponseCode = 200;
                    response.ResponseMessage = "OK";
                }
                catch (Exception ex)
                {
                    response.ResponseCode = 500;
                    response.ResponseMessage = ex.Message;
                }
            }
            return response;
        }
    }

}
