// See https://aka.ms/new-console-template for more information
using POO;

Guerrero nuevoGuerrero = new Guerrero();

nuevoGuerrero.nombre = "Pedrito";

Console.WriteLine($"El nombre del guerrero es {nuevoGuerrero.nombre}");
nuevoGuerrero.Atacar();
Console.WriteLine(nuevoGuerrero.nivel);
Console.WriteLine($"El nivel del guerro es {nuevoGuerrero.experiencia}");
nuevoGuerrero.RecibirExperiencia(5);
Console.WriteLine(nuevoGuerrero.nivel);
Console.WriteLine(nuevoGuerrero.experiencia);

Guerrero Guerrero2 = new Guerrero("Jose");
Console.WriteLine(Guerrero2.nombre);