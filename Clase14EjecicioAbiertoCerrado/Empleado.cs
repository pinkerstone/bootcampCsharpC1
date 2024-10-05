using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14EjecicioAbiertoCerrado
{
    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public double SalarioBase { get; set; }

        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Sueldo base: {SalarioBase}");
        }

        public abstract void CalcularBonificacion ();
    }
}
