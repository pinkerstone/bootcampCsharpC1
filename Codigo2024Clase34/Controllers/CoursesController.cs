using Codigo2024Clase34.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Codigo2024Clase34.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {

        [HttpGet]
        public List<Course> Get()
        {
            using(var context = new DataBaseContext())
            {
                return context.Courses.Where(x=> x.Enable == true).ToList();
            }
        }

        [HttpGet]
        public Course GetById(int _courseID)
        {
            using( var context = new DataBaseContext())
            {
                //return context.Courses.Find(_courseID);
                return context.Courses.Where(x=> x.Enable == true && x.CourseID == _courseID).FirstOrDefault();
            }
        }

        [HttpPost]
        public Response Insert(Course _course)
        {
            Response response = new Response();
            using(var context = new DataBaseContext())
            {
                try
                {
                    context.Courses.Add(_course);
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
        public Response Update(Course _course)
        {
            Response response = new Response();
            using( var context = new DataBaseContext())
            {
                try
                {
                    context.Entry(_course).State = EntityState.Modified;
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

        [HttpDelete]
        public Response Delete(int _CourseID)
        {
            Response response = new Response();
            using (var context = new DataBaseContext())
            {
                try
                {
                    var course = context.Grades.Find(_CourseID);
                    course.Enable = false;
                    context.Entry(course).State = EntityState.Modified;
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    response.ResponseCode = 500;
                    response.ResponseMessage = ex.Message;
                }
                return response;
            }
        }
    }
}
