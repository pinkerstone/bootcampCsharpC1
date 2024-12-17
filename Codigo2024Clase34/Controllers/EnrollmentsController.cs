using Codigo2024Clase34.Models;
using Codigo2024Clase34.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Codigo2024Clase34.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EnrollmentsController : ControllerBase
    {
        [HttpGet]
        public List<Enrollment> Get()
        {
            using(var context = new DataBaseContext())
            {
                return context.Enrollments.Where(x=> x.Enable == true).ToList();
            }
        }

        [HttpGet]
        public Enrollment GetById(int _enrollmentID)
        {
            using( var context = new DataBaseContext())
            {
                //return context.Enrollments.Find(_enrollmentID);
                return context.Enrollments.Where(x => x.Enable && x.EnrollmentID == _enrollmentID).FirstOrDefault();
            }
        }

        [HttpPost]
        public Response Insert(EnrollmentDTO _enrollmentDTO)
        {
            Response response = new Response();
            using( var context = new DataBaseContext())
            {
                try
                {
                    Enrollment enrollment = new Enrollment
                    {
                        Enable = _enrollmentDTO.Enable,
                        Date = DateTime.Now,
                        StudentID = _enrollmentDTO.StudentID,
                        CourseID = _enrollmentDTO.CourseID,
                    };
                    context.Enrollments.Add(enrollment);
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

        [HttpPut]
        public Response Update(Enrollment enrollment)
        {
            Response response = new Response();
            using(var context = new DataBaseContext())
            {
                try
                {
                    context.Entry(enrollment).State = EntityState.Modified;
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
        public Response Delete(int _enrollmentID)
        {
            Response response = new Response();
            using( var context = new DataBaseContext())
            {
                try
                {
                    var enrollment = context.Enrollments.Find(_enrollmentID);
                    enrollment.Enable = false;
                    context.Entry(enrollment).State = EntityState.Modified;
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
