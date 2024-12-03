using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BStudent
    {
        public List<Student> Get(string name, string lastname)
        {
            List<Student> students = new List<Student>();
            DStudent student = new DStudent();
            students = student.Get(name, lastname);
            
            return students;
        }
    }
}
