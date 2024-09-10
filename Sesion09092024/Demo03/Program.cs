// See https://aka.ms/new-console-template for more information

void EjemploDoWhile()
{
    int valor = 0;
    do
    {
        valor++;
        Console.WriteLine(valor);
    }
    while (valor < 12);
}

//EjemploDoWhile();

void LeerNumerosPositivo()
{
    int numero = 0;
    do
    {
        Console.WriteLine("Ingresa un numero positivo");
        numero = Convert.ToInt32(Console.ReadLine());
    }
    while (numero <= 0);

    Console.WriteLine($"Has ingresado el numero positivo {numero}");

}
//LeerNumerosPositivo();

void LeerNota()
{
    double nota = 0;
    do
    {
        Console.WriteLine("Ingresa una nota");
        nota = Convert.ToDouble(Console.ReadLine());

    }
    while ((nota < 0) || (nota > 20));

    Console.WriteLine($"La nota es: {nota}");
}
//LeerNota();

void ValidarContrasena()
{
    string contrasena1, contrasena2;
    Console.WriteLine("Registra tu contraseña");
    contrasena1 = Console.ReadLine();

    do
    {
        Console.WriteLine("Valida tu contraseña\n");
        Console.WriteLine("Ingresa la contraseña");
        contrasena2 = Console.ReadLine();
    }
    while (contrasena1 != contrasena2);
    Console.WriteLine("Contraseña correcta");
}
ValidarContrasena();

int numero1, numero2;
Console.WriteLine("Ingresa un numero 1");
numero1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingresa un numero 2");
numero2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("El doble del numero 1 es");
Console.WriteLine(numero1 * 2);
Console.WriteLine("La suma de los numeros es");
Console.WriteLine(numero1 * numero2);

Console.ReadKey();