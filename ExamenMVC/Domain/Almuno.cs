using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Correo {  get; set; }
        public bool Estado { get; set; }
    }
}
