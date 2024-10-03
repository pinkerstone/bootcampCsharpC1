// See https://aka.ms/new-console-template for more information


void PruebaArreglo()
{
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
}

//PruebaArreglo();

void Personalizado()
{
    try
    {
        Console.Write("Ingresa tu edad: ");
        int edad = Convert.ToInt32(Console.ReadLine());
        if (edad < 0 || edad > 120)
        {
            throw new InvalidCustomException();
        }


        Console.WriteLine($"Tu edad es: {edad}");
    }
    catch(InvalidCustomException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch(FormatException ex)
    {
        Console.WriteLine("Error de formato");
    }

}

//Personalizado();

void EjercicioNota()
{
    try
    {
        Console.Write("Ingresa la nota: ");
        double nota = Convert.ToDouble(Console.ReadLine());

        if (nota < 0 || nota > 20)
        {
            throw new InvalidCustomException();
        }

        Console.WriteLine($"La nota es: {nota}");
    }
    catch (InvalidCustomException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (FormatException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
EjercicioNota();


