using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14Ejercicio01
{
    public class GestorReservas
    {
        private ReservaHotel _reservaHotel;
        private ServicioEmail _servicioEmail;
        private ReporteReservas _reporteReservas;
        
        public GestorReservas (ReservaHotel reservaHotal, ServicioEmail serivicioEmail, ReporteReservas reporteReservas)
        {
            _reservaHotel = reservaHotal;
            _servicioEmail = serivicioEmail;
            _reporteReservas = reporteReservas;

        }
        
        public void ProcesarReserva()
        {
            _reservaHotel.HacerReserva();
            _servicioEmail.EnviarConfirmacion(_reservaHotel.Correocliente);
            _reporteReservas.GenerarReporte();
        }
    }
}
