// See https://aka.ms/new-console-template for more information


using Clase11Ejercicio1;

Empresa empresa1 = new Empresa()
{
    Nombre = "Desarrollo SAC",
    Direccion = "Calle 1, Lima",
    Trabajadores = new List<Trabajador>(),
};

empresa1.Trabajadores.Add(new Trabajador
{
    Nombres = "Luis",
    Apellidos = "Ulloa",
    NumDocumento = "10101010",
    Sueldo = 1000,
});

empresa1.Trabajadores.Add(new Trabajador
{
    Nombres = "Jose",
    Apellidos = "Perez",
    NumDocumento = "20202020",
    Sueldo = 2000,
});

Console.WriteLine(empresa1.Nombre);
Console.WriteLine(empresa1.Direccion);

foreach (var trabajador in empresa1.Trabajadores)
{
    Console.WriteLine("______________");
    Console.WriteLine($"{trabajador.Nombres} {trabajador.Apellidos}");
    Console.WriteLine(trabajador.Sueldo);
    Console.WriteLine(trabajador.CalcularDescuento());
}