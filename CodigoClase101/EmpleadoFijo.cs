using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase101
{
    public class EmpleadoFijo : Empleado
    {
        public override void CalcularSalario()
        {
            Console.WriteLine($"El salario es: {SalarioBase}");
        }
    }
}
