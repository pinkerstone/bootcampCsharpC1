using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase11Ejecicio2
{
    public class Producto : IDescuento
    {
        public double Precio {  get; set; }
        public double Descuento()
        {
            return Precio * 0.1;
        }
    }
}
