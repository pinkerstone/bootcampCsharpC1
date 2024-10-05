// See https://aka.ms/new-console-template for more information

using Clase14Ejercicio01;

GestorReservas reserva = new GestorReservas(new ReservaHotel {NombreCliente = "Luis Ulloa", FechaReserva = DateTime.Now, Correocliente = "luisulloa@hotmail.com"}, new ServicioEmail(), new ReporteReservas());

reserva.ProcesarReserva();
