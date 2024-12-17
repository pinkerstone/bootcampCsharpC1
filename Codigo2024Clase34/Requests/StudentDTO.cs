using Codigo2024Clase34.Models;

namespace Codigo2024Clase34.Requests
{
    public class StudentDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool Enable { get; set; }

        //Llaves
        public int GradeId { get; set; }
        public Grade Grade { get; set; }
    }
}
