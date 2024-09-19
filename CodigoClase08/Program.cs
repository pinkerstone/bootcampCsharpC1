// See https://aka.ms/new-console-template for more information


using CodigoClase08;

Profesor profesor = new Profesor
{
    Apellidos = "Torrico Marquez",
    Nombres = "Hugo Felipe",
    EscalaSalarial = 1,
    TipoDocumento = "DNI",
};

//Console.WriteLine(profesor.ObtenerNombresCompletos());

Trabajador trabajador1 = new Trabajador
{
    Nombres = "Luis",
    Apellidos = "Ulloa",
    TipoDocumento = "DNI",
    SueldoBruto = 1000
};

//Console.WriteLine(trabajador1.CalcularSueldoNeto());

Estudiante estudiante1 = new Estudiante
{
    Nombres = "Ronal",
    Apellidos = "Cueva",
    Materias = new List<string>(),
    Notas = new List<double>()
};

estudiante1.Materias.Add("Matematica");
estudiante1.Materias.Add("Fisica");
estudiante1.Notas.Add(10);
estudiante1.Notas.Add(20);


foreach (var item in estudiante1.Materias)
{
    Console.WriteLine(item);
}

Console.WriteLine(estudiante1.CalcularPromedio());

