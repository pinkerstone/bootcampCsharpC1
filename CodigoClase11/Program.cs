// See https://aka.ms/new-console-template for more information

using CodigoClase11;
using System.Runtime.InteropServices;

Estudiante estudiante1 = new Estudiante
{
    Apellidos = "Sosa",
    Nombres = "Edson",
    Codigo = "20054124",
    Cursos = new List<Curso>(),
};
estudiante1.Cursos.Add(new Curso
{
    Nombre = "Matemática",
    Descripcion = "Descripción cualquiera",
    Creditos = 4
});
estudiante1.Cursos.Add(new Curso
{
    Nombre = "Religión",
    Descripcion = "Descripción cualquiera",
    Creditos = 3
});

Console.WriteLine($"{estudiante1.Apellidos} {estudiante1.Nombres}");
Console.WriteLine(estudiante1.Codigo);
foreach (var item in estudiante1.Cursos)
{
    Console.WriteLine(item.Nombre);
    Console.WriteLine(item.Descripcion);
    Console.WriteLine(item.Creditos);
};