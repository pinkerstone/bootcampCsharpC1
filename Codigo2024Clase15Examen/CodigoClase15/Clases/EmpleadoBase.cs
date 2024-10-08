using CodigoClase15.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase15.Clases
{
    public abstract class EmpleadoBase : IEmpleado
    {
        public abstract int SueldoBase { get; }
        public string IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Puesto { get; set; }
      
        public abstract decimal CalcularSueldo();
        public void MostrarDetalle()
        {
            Console.WriteLine($"ID Empleado: {IdEmpleado}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Puesto: {Puesto}");
            Console.WriteLine($"Sueldo base: {SueldoBase}");
        }
    }
}
