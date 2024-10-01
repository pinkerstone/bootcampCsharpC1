// See https://aka.ms/new-console-template for more information


using Clase12Ejercicio02Interfaces;

Empresa empresa = new Empresa();

empresa.Empleados = new List<IPagable>();

empresa.Empleados.Add(new EmpleadoContratado { SalarioFijo = 2000 });
empresa.Empleados.Add(new EmpleadoPorHoras { CostoPorHora = 10, NumeroHoras= 2});
empresa.Empleados.Add(new EmpleadoTiempoCompleto { ValorContrato = 3000});

empresa.CalcularPagosEmpleados();
