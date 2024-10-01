// See https://aka.ms/new-console-template for more information

using Clase12Ejercicio01;
using System.ComponentModel;

List<IPedido> pedidos = new List<IPedido>();

pedidos.Add(new ProductoElectronico());
pedidos.Add(new ProductoRopa());

foreach (var item in pedidos)
{
    item.EnviarPedido();
}