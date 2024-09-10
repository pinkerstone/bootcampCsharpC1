// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information

//Función
int Sumar(int a, int b)
{
    return a + b;
}

//Procedimiento
void Restar(int a, int b)
{
    Console.WriteLine(a - b);
}


double CalcularDistancia(double x1, double y1, double x2, double y2)
{
    double valor1 = Math.Pow(x2 - x1, 2);
    double valor2 = Math.Pow(y2 - y1, 2);
    double distancia = Math.Sqrt(valor1 + valor2);
    return distancia;
}


double CalcularArea(double base1, double altura)
{
    return base1 * altura;
}

double CalcularPerimetro(double base1, double altura)
{
    return 2 * (base1 + altura);
}

void MostrarArea(double base1, double altura)
{
    double area = CalcularArea(base1, altura);
    Console.WriteLine("el área es : ");
    Console.WriteLine(area);
}
void MostrarPerimetro(double base1, double altura)
{
    double perimetro = CalcularPerimetro(base1, altura);
    Console.WriteLine("el perímetro es : ");
    Console.WriteLine(perimetro);
}


double x1 = 0;
double y1 = 0;
double x2 = 4;
double y2 = 0;
double x3 = 4;
double y3 = 6;
double x4 = 0;
double y4 = 6;


double base1 = CalcularDistancia(x1, y1, x2, y2);
double altura = CalcularDistancia(x2, y2, x3, y3);

MostrarPerimetro(base1, altura);
MostrarArea(base1, altura);

Console.Read();
