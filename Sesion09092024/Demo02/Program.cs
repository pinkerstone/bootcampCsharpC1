// See https://aka.ms/new-console-template for more information


//Crear una función Sumar los primeros n numeros naturales
//1+2+3+4+5+...+n;
int SumarNaturales(int cantidad)
{
    int suma = 0;

    for (int i = 1; i <= cantidad; i++)
    {
        suma = suma + i;
    }
    return suma;
}


//Crear una función Sumar los primeros n numeros pares n=4
//2+4+6+8+10
//2 * (1+2+3+4+...n)
int SumarPares(int cantidad)
{
    return 2 * SumarNaturales(cantidad);
}

//Crear una función Sumar los primeros n numeros impares n=4
//1+3+5+7=16
int SumarImpares(int cantidad)
{
    int suma = 0;
    int impar = 0;

    for (int i = 1; i <= cantidad; i++)
    {
        impar = 2 * i - 1;
        suma = suma + impar;
    }
    return suma;
}

//Console.WriteLine( SumarNaturales(5));
//Console.WriteLine(SumarPares(5));
Console.WriteLine(SumarImpares(20));//16

void CrearTablaMultiplicar(int numero)
{
    int cantidad = 12;
    int i = 1;

    while (i <=12)
    {
        Console.WriteLine($"{numero} * {i} = {numero * i}");
        i++;
    }

}

CrearTablaMultiplicar(5);

double SumaCuadrados(double numero)
{
    double suma = 0;
    double i = 1;

    while(i <=numero)
    {
        suma = suma + Math.Pow(i,2);
        i++;
    }
    return suma;
}
Console.WriteLine(SumaCuadrados(5));

void CrearTablaMultiplicarReves(int numero)
{
    int cantidad = 12;
    int i = cantidad;

    while (i > 0)
    {
        Console.WriteLine($"{numero} * {i} = {numero * i}");
        i--;
    }

    //for (int j = 12; j > 0; j--)
    //{
    //    Console.WriteLine($"{numero} * {j} = {numero * j}");
    //}

}
CrearTablaMultiplicarReves(5);

Console.Read();