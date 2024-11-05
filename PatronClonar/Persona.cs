using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PatronClonar
{
    public class Persona
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion {  get; set; }
        public string Telefono { get; set; }
        public int Edad {  get; set; }
        
        public Persona(string nombres, string apellidos, string direccion, string telefono, int edad)
        {
            Nombres = nombres;
            Apellidos = apellidos;
            Direccion = direccion;
            Telefono = telefono;
            Edad = edad;
        }

        //Método de clonacion: Instanciamos un nuevo objeto basado en el objeto actual pero es independiente y no tiene referencia al objeto base
        public Persona ManualClone()
        {

            return new Persona(Nombres, Apellidos, Direccion, Telefono, Edad);
        }

        public Persona Clonar()
        {
            //Funcion propia de IDE para clonar sin usar el constructor
            return (Persona)this.MemberwiseClone();
        }
    }
}
