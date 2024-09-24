// See https://aka.ms/new-console-template for more information

using CodigoClase101;

#region Ejercicio1
Empleado empleado1 = new EmpleadoFijo
{   
    Nombre = "Luis",
    SalarioBase = 1000
};

Empleado empleado2 = new EmpleadoPorHora
{
    Nombre = "Jose",
    SalarioBase = 500,
    Horas = 3
};

List<Empleado> empleados = new List<Empleado>();
empleados.Add(empleado1);
empleados.Add(empleado2);

foreach (var item in empleados)
{
    Console.WriteLine(item.Nombre);
    item.CalcularSalario();
}
#endregion