using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase14
{
    public abstract class Cliente
    {

        public string Nombre { get; set; }
        public double MontoPagar { get; set; }

        public abstract double CalcularDescuento();

    }
}
