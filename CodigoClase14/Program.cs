// See https://aka.ms/new-console-template for more information

using CodigoClase14;

List<Cliente> clientes = new List<Cliente>();

clientes.Add(new ClienteVip { Nombre = "Luis", MontoPagar = 1000 });
clientes.Add(new ClienteRegular { Nombre = "Pedro", MontoPagar = 500 });
clientes.Add(new ClienteMayorista { Nombre = "Bodega", MontoPagar = 5000 });

foreach (Cliente item in clientes)
{
    Console.WriteLine(item.CalcularDescuento());
}