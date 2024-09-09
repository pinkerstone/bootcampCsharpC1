// See https://aka.ms/new-console-template for more information
//string ciudad = "Arequipa";
//string[] ciudades = new string[4];

//ciudades[0] = "Lima";
//ciudades[1] = "Puno";
//ciudades[2] = "Cusco";
//ciudades[3] = "Trujillo";

//foreach (string elemento in ciudades)
//{
//    Console.WriteLine(elemento);
//}

//Queue<float> ingresos = new Queue<float>();

//ingresos.Enqueue(25.5f);
//ingresos.Enqueue(3f);
//ingresos.Enqueue(8f);
//ingresos.Enqueue(20.58f);

//foreach (float elemento in ingresos)
//{
//    Console.WriteLine($"{elemento}");
//}

//float salida = ingresos.Dequeue();
//Console.WriteLine(salida);
//foreach (float elemento in ingresos)
//{
//    Console.WriteLine($"{elemento}");
//}

Stack<string> animales = new Stack<string>();

animales.Push("Loro");
animales.Push("Vaca");
animales.Push("Canario");
animales.Push("Perro");

foreach (string elemento in animales)
{
    Console.WriteLine(elemento);
}

string animalSaliente = animales.Pop();
Console.WriteLine(animalSaliente);

foreach (string elemento in animales)
{
    Console.WriteLine(elemento);
}


