// See https://aka.ms/new-console-template for more information
using System.Dynamic;
using System.Net.Mail;

Console.WriteLine("Hello, World!");
int edad = 20;
long altura = 181;
string nombre = "Gonzalo";
double dinero = 1651.36;
float danio = 124.4f;
decimal montoBanco = 1245151.4m;
char letra = 'A';
bool tieneGorro = false;

Console.WriteLine("Mi nombre es {0}", nombre);
Console.WriteLine($"Mi altura es {altura}");


Console.WriteLine("Escribe tu nombre");
nombre = Console.ReadLine();
Console.WriteLine($"Mi nombre es {nombre}");

Console.WriteLine("Escribe tu dinero");
dinero = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Mi dinero es {dinero}");
