// See https://aka.ms/new-console-template for more information


using Clase11Ejecicio2;

List<IDescuento> descuentos = new List<IDescuento>();

descuentos.Add(new Producto
{ Precio = 1000});
descuentos.Add(new Servicio
{ Precio = 1000});

foreach (var item in descuentos)
{
    Console.WriteLine(item.Descuento());
}


