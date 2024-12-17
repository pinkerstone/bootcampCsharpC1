namespace Codigo2024Clase34.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone {  get; set; }
        public string Email { get; set; }
        public bool Enable {  get; set; }

        //Llaves
        public int GradeId { get; set; }
        public Grade Grade { get; set; }
    }
}
