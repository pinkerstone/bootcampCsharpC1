// See https://aka.ms/new-console-template for more information


using Clases;

Rectangulo rectangulo = new Rectangulo();

rectangulo.altura = 20;
rectangulo.base1 = 30;

Console.WriteLine($"El área es: {rectangulo.CalcularArea()}");
Console.WriteLine($"El perímetro es: {rectangulo.CalcularPerimetro()}");

Persona persona = new Persona();

//persona.nombres = "Luis Gabriel";
//persona.apellidos = "Ulloa Flores";

//Console.WriteLine(persona.RetornarNombresCompletos());

Persona persona1 = new Persona("Pedro", "Perez");
Console.WriteLine(persona1.RetornarNombresCompletos());