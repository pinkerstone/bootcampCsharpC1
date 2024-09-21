using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase09
{
    public class Estudiante : Persona
    {
        public string CodigoEstudiante { get; set; }

        public void MostrarDatosEstudiante()
        {
            MostrarNombresCompletos();
            Console.WriteLine(CodigoEstudiante);
            Console.WriteLine(ObtenerEdad());
        }
    }


}
