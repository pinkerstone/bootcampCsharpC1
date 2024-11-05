// See https://aka.ms/new-console-template for more information


using PatronClonar;
using System.Runtime.CompilerServices;

#region Ejecutor

Ejercicio3();
#endregion

#region Ejercicio 1
void Ejercicio1()
{
    Persona persona = new Persona("Hugo", "Torrico", "", "", 36);

    Console.WriteLine(persona.Nombres + persona.Apellidos);


    //Aquie se llama al método para clonar definido en la clase
    Persona persona1 = persona.ManualClone();

    Console.WriteLine(persona1.Nombres + persona1.Apellidos);

    persona1.Apellidos = "Ulloa";
    persona1.Nombres = "Luis";

    Console.WriteLine(persona1.Nombres + persona1.Apellidos);

}

#endregion


#region Ejercicio 2
void Ejercicio2()
{
    Laptop laptop = new Laptop("HP", 500, 500);


    Laptop laptop2 = laptop.ManualClone();
    laptop2.Nombre = "Toshiba";
    laptop2.Precio = 450;
    laptop2.Stock = 300;

    Laptop laptop3 = laptop.ManualClone();
    laptop3.Nombre = "Dell";
    laptop3.Precio = 550;
    laptop3.Stock = 350;

    Console.WriteLine(laptop.Nombre + " " + laptop.Precio + " " + laptop.Stock);
    Console.WriteLine(laptop2.Nombre + " " + laptop2.Precio + " " + laptop2.Stock);
    Console.WriteLine(laptop3.Nombre + " " + laptop3.Precio + " " + laptop3.Stock);
}
#endregion

#region Ejercicio 3
//Usando la funcion de clonar de la IDE
void Ejercicio3()
{
    Laptop laptop = new Laptop("HP", 500, 500);


    Laptop laptop2 = laptop.Clone();
    laptop2.Nombre = "Toshiba";
    laptop2.Precio = 450;
    laptop2.Stock = 300;

    Laptop laptop3 = laptop.Clone();
    laptop3.Nombre = "Dell";
    laptop3.Precio = 550;
    laptop3.Stock = 350;

    Console.WriteLine(laptop.Nombre + " " + laptop.Precio + " " + laptop.Stock);
    Console.WriteLine(laptop2.Nombre + " " + laptop2.Precio + " " + laptop2.Stock);
    Console.WriteLine(laptop3.Nombre + " " + laptop3.Precio + " " + laptop3.Stock);
}


#endregion