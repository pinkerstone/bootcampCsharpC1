using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase101
{
    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public double SalarioBase { get; set; }

        public abstract void CalcularSalario();
    }
}
