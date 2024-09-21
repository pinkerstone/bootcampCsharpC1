using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase09
{
    public class Persona
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }


        //private solo funciona dentro de la clase
        private string RetornarNombresCompletos()
        {
            return $"{Nombres} {Apellidos}";
        }

        //public se puede usar desde cualquier lugar
        public void MostrarNombresCompletos()
        {
            Console.WriteLine($"{Nombres} {Apellidos}");
        }

        //protected se puede utilizar desde las clases vinculadas
        protected int ObtenerEdad()
        {
            return DateTime.Now.Year - FechaNacimiento.Year;
        }
        
    }
}
