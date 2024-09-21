// See https://aka.ms/new-console-template for more information


using CodigoClase09;

//Persona persona1 = new Persona()
//{
//    Nombres = "Luis Gabriel",
//    Apellidos = "Ulloa Flores"
//};

//persona1.MostrarNombresCompletos();

//Profesor profesor1 = new Profesor()
//{
//    Nombres = "Fernando",
//    Apellidos = "Marquez",
//    SueldoNeto = 2000
//};

Estudiante estudiante1 = new Estudiante
{
    Nombres = "Luis Gabriel",
    Apellidos = "Ulloa Flores",
    FechaNacimiento = Convert.ToDateTime("1980-09-02"),
    CodigoEstudiante = "19971743"
};

estudiante1.MostrarDatosEstudiante();

