// See https://aka.ms/new-console-template for more information

using Demo03;

Console.WriteLine(Matematica.Sumar(4, 5));
Console.WriteLine(Matematica.Sumar(4, 5, 3));
Console.WriteLine(Matematica.Sumar(4, 5, 3, 2));

//Uso de sobrecarga cuadrado
Console.WriteLine(Poligono.CalcularArea(4));
//uso de sobrecarga rectangulo
Console.WriteLine(Poligono.CalcularArea(4, 3));