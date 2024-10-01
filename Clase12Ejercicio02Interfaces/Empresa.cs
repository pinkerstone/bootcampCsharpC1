using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase12Ejercicio02Interfaces
{
    public class Empresa
    {
        public List<IPagable> Empleados {  get; set; }

        public void CalcularPagosEmpleados()
        {
            double total = 0;
            
            foreach (var empleado in Empleados)
            {    
                total = total + empleado.CalcularPago();
            }
            Console.WriteLine($"El total de sueldos es: {total}");
        }
    }
}
