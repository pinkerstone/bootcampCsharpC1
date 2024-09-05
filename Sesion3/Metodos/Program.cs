// See https://aka.ms/new-console-template for more information

double numero1 = 10, numero2 = 5;
void Sumar(double n1, double n2)
{
    double resultado = n1 + n2;
    Console.WriteLine(resultado);
}

void Sumar1()
{
    double resultado = numero1 + numero2;
    Console.WriteLine(resultado);
}

double Sumar2(double n1, double n2)
{
    double resultado = n1 + n2;
    return resultado;
}


Sumar(5, 6);
Sumar1();
double result = Sumar2(7, 6);
Console.WriteLine(result);