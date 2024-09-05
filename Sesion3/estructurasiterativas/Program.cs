// See https://aka.ms/new-console-template for more information

Console.WriteLine("Ingresa los numeros a operar");
double numero1 = double.Parse(Console.ReadLine());
double numero2 = double.Parse(Console.ReadLine());
double resultado = 0;

//int resultado = numero1 + numero2;

//Console.WriteLine(resultado);

//Console.WriteLine("Ingresa el numero limite WHILE");
//int numeroLimite = int.Parse(Console.ReadLine());
//int contador = 0;
//while (contador < numeroLimite)
//{
//    contador++;
//    Console.WriteLine(contador);
//}

//Console.WriteLine("Ingresa el numero limite DO WHILE");
//contador = 0;
//do
//{
//    contador++;
//    Console.WriteLine(contador);
//} while (contador < numeroLimite);

int opcion = 0;
while (opcion != 7)
{
Console.WriteLine("Menu ---->");
Console.WriteLine("1. Sumar");
Console.WriteLine("2. Restar");
Console.WriteLine("3. Multiplicar");
Console.WriteLine("4. Dividir");
Console.WriteLine("5. Potencia");
Console.WriteLine("6. Raiz");
Console.WriteLine("7. Salir");
Console.WriteLine("Ingresa tu opcion");
opcion = int.Parse(Console.ReadLine());

switch (opcion)
    {
        case 1:
            {
                resultado = numero1 + numero2;
                break;
            }
        case 2:
            resultado = numero1 - numero2;
            break;
        case 3:
            resultado = numero1 * numero2;
            break;
        case 4:
            if (numero2 > 0)
            {
                resultado = numero1 / numero2;
            }
            else
            {
                Console.WriteLine("No se puede dividir");
            }
            break;
        case 5:
            break;
        case 6:
            break;
        default:
            break;
            
    }
    Console.WriteLine($"El resultado es {resultado}");
}
Console.WriteLine("Salida");