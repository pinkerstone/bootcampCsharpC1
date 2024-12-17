using Codigo2024Clase34.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;


namespace Codigo2024Clase34.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GradesController : ControllerBase
    {

        [HttpGet]
        public List<Grade> Get()
        {
            using(var context = new DataBaseContext())
            {
                return context.Grades.Where(x=> x.Enable == true).ToList();
            }
        }

        [HttpGet]
        public Grade GetById(int _gradeID)
        {
            using( var context = new DataBaseContext())
            {
                return context.Grades.Find(_gradeID);
            }
        }

        [HttpPost]
        public Response Insert(Grade _grade)
        {
            Response response = new Response();
            using (var context = new DataBaseContext())
            {
                try
                {
                    context.Grades.Add(_grade);
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
        public Response Update(Grade _grade)
        {
            Response response = new Response();
            using(var context = new DataBaseContext())
            {
                try
                {
                    context.Entry(_grade).State = EntityState.Modified;
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
        public Response Delete(int _gradeID)
        {
            Response response = new Response();
            using(var context = new DataBaseContext())
            {
                try
                {
                    var grade = context.Grades.Find(_gradeID);
                    grade.Enable = false;
                    context.Entry(grade).State = EntityState.Modified;
                    context.SaveChanges();
                    response.ResponseCode = 200;
                    response.ResponseMessage = "OK";
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
