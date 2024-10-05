using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14Ejercicio01
{
    public class ReservaHotel
    { 
        public string NombreCliente { get; set; }
        public DateTime FechaReserva { get; set; }
        public string Correocliente { get; set; }

        public void HacerReserva()
        {
            Console.WriteLine($"Reserva heca para {NombreCliente} el {FechaReserva}");
        }
    }
}
