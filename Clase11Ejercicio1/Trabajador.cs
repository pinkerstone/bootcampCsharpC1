using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase11Ejercicio1
{
    public class Trabajador
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NumDocumento { get; set; }
        public double Sueldo { get; set; }

        public double CalcularDescuento ()
        {
            return Sueldo * 0.05;
        }
    }
}
