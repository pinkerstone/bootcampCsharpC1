using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Persona
    {
        private string nombres;
        private string apellidos;

        
        public Persona()
        {

        }
        public Persona(string argNombres, string argApellidos)
        {
            this.nombres = argNombres;
            this.apellidos = argApellidos;
        }
        public string RetornarNombresCompletos()
        {
            return $"{nombres} {apellidos}";
            //return nombres + " " + apellidos;
        }
    }
}
