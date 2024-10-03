// See https://aka.ms/new-console-template for more information

int[] arr = new int[] { 2, 6, 7, 8, 3 };

try
{
    Console.WriteLine("Ingresa un indice a mostrar");
    int indice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(arr[indice]);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Error en el indice");
}
catch (FormatException ex)
{
    Console.WriteLine("Error de formato");
}
catch (Exception ex)
{
    Console.WriteLine("Error del programa");
}



