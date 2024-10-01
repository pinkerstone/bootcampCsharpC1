using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase12Ejercicio02Interfaces
{
    public class EmpleadoContratado : IPagable
    {
        public double SalarioFijo { get; set; }
        public double CalcularPago()
        {
            return SalarioFijo;
        }
    }
}
