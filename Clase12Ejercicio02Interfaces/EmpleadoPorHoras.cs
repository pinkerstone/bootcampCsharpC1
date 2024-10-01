using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase12Ejercicio02Interfaces
{
    public class EmpleadoPorHoras : IPagable
    {
        public int NumeroHoras { get; set; }
        public double CostoPorHora { get; set; }

        public double CalcularPago()
        {
            return NumeroHoras*CostoPorHora;
        }
    }
}
