using Business;
using Data;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {

        [HttpGet]
        public List<Student> GetStudent(string? name, string? lastName)
        {
            List<Student> students = new List<Student>();
            BStudent student = new BStudent();
            students = student.Get(name, lastName);
            return students;
            
        }
    }
}
