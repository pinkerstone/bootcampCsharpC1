// See https://aka.ms/new-console-template for more information

using System.Numerics;

List<int> PruebaList()
{
    List<int> numeros = new List<int>();

    numeros.Add(20);
    numeros.Add(30);
    numeros.Add(21);
    numeros.Add(18);

    //numeros.Sort();

    //Console.WriteLine(numeros.IndexOf(21));
    //foreach (int elemento in numeros)
    //{
    //    Console.WriteLine(elemento);
    //}
    return numeros;
}

void AgregarNombres(int cantidad)
{
    List<string> nombres = new List<string>();
    string nombre = string.Empty;

    for (int i = 1; i <= cantidad; i++)
    {
        Console.Clear();
        Console.WriteLine($"Integresa el nombre {i}:");
        nombre = Console.ReadLine();
        nombres.Add(nombre);
        Console.Clear();
    }

    nombres.Sort();

    Console.WriteLine("La lista de nombres es:");
    foreach (string elemento in nombres)
    {
        Console.WriteLine(elemento);
    }
}

//PRUEBA EJERCICIO 1
//AgregarNombres(5);

int CalcularNotaMenor(List<int> notas)
{
    int notaMenor = notas[0];

    foreach (int elemento in notas)
    {
        if (elemento < notaMenor)
        {
            notaMenor = elemento;
        }
    }
    return notaMenor;
}

int CalcularNotaMayor(List<int> notas)
{
    int notaMayor = notas[0];

    foreach (int elemento in notas)
    {
        if (elemento > notaMayor)
        {
            notaMayor = elemento;
        }
    }
    return notaMayor;
}

//PRUEBA EJERCICIO 2:
//Console.WriteLine(CalcularNotaMenor(PruebaList()));
//Console.WriteLine(PruebaList().Min());
//Console.WriteLine(CalcularNotaMayor(PruebaList()));
//Console.WriteLine(PruebaList().Max());

int ObtenerPosicion(List<int> argNumeros)
{
    int posicion = 0;
    int numero;
    Console.WriteLine("Ingresa el número a buscar");
    numero = Convert.ToInt32(Console.ReadLine());
    posicion = argNumeros.IndexOf(numero);

    return posicion;
}

//EJERCICIO 3

//Console.WriteLine(ObtenerPosicion(PruebaList()));

//FUNCION ADDRANGE:
//Inserta una lista completa dentro de otra lista

void ProgramaCalificaciones()
{
    List<float> calificaciones = new List<float>();
    int opcion = 0;

    do
    {
        Console.Clear();
        Console.WriteLine("1. Ingresar calificación");
        Console.WriteLine("2. Calcular promedio");
        Console.WriteLine("3. Salir");
        Console.WriteLine("----------------");
        opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                {
                    Console.Clear();
                    Console.WriteLine("Ingresa una calificación:");
                    calificaciones.Add(Convert.ToSingle(Console.ReadLine()));
                    break;
                }
            case 2:
                {
                    float promedioNotas = 0;
                    promedioNotas = CalculoPromedio(calificaciones);
                    Console.WriteLine($"La calificación promedio es: {promedioNotas}");
                    Console.ReadKey();
                    break;
                }
            default:
                {
                    break;
                }
        }
    }
    while (opcion != 3);
    Console.ReadKey();
}


float CalculoPromedio (List<float> argCalificaciones)
{
    float promedio = argCalificaciones.Average();
    //float sumaCalificaciones = 0;
    //sumaCalificaciones = argCalificaciones.Sum();
    //promedio = sumaCalificaciones / argCalificaciones.Count();
    return promedio;
}

//EJERCICIO 4
//ProgramaCalificaciones();



