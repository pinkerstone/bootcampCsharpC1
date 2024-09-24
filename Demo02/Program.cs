// See https://aka.ms/new-console-template for more information

using Demo02;

List<Vehiculo> vehiculos = new List<Vehiculo> ();

vehiculos.Add(new Automovil { Marca = "Audi", Modelo = "A3", Pantalla = true });
vehiculos.Add(new Automovil { Marca = "Audi", Modelo = "A4", Pantalla = true });
vehiculos.Add(new Motocicleta { Marca = "Honda", Modelo = "CBR" });

foreach (var item in vehiculos)
{
    item.MostrarInformacion();
    item.PrecioVenta();
}