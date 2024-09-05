// See https://aka.ms/new-console-template for more information

DateTime fechaNacimiento = new DateTime(1985, 6, 8);

var fechaActual = DateTime.Now;

Console.WriteLine($"La fecha actual es {fechaActual.ToString("MM,dd,YY")}");
Console.WriteLine($"Naci en la fecha {fechaNacimiento.ToString("dd/mm/yy")}");

var restaFechas = fechaActual - fechaNacimiento;

Console.WriteLine($"Tu edad es {restaFechas.Days/360}");


