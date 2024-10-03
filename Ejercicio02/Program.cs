// See https://aka.ms/new-console-template for more information

using Ejercicio02;
using Microsoft.VisualBasic.FileIO;
using System;

void EjecutarOperaciones()
{
    Operaciones operacion; 
    try
    {
        operacion = new Operaciones();
        Console.Write("Ingresa primer número: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingresa segundo número: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        operacion.AsignarValores(numero1, numero2);
        Console.WriteLine($"La division es: {operacion.Dividir()}");
        Console.WriteLine($"La suma es: {operacion.Sumar()}");
        Console.WriteLine($"La resta es: {operacion.Restar()}");
    }
    catch (FormatException ex)
    {
        Console.WriteLine($"error: {ex.Message}");
    }
    catch ( CustomException ex)
    {
        Console.WriteLine($"error: {ex.Message}");
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"error: {ex.Message}");

    }
    finally
    {
        operacion = null;
    }
}

EjecutarOperaciones();