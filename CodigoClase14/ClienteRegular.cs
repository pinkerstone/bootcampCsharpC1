using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase14
{
    public class ClienteRegular : Cliente
    {
        public override double CalcularDescuento()
        {
            return MontoPagar * 0.05;
        }
    }
}
