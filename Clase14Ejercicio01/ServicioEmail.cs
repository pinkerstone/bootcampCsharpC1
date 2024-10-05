using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14Ejercicio01
{
    public class ServicioEmail
    {
        public void EnviarConfirmacion(string correo)
        {
            Console.WriteLine($"Enviando confirmación a {correo}");
        }

        public void EnviarReporte(string correo)
        {
            Console.WriteLine($"Enviando reporte a {correo}");
        }
    }
}
