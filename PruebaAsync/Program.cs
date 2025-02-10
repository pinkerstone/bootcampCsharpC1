// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static async void CalentarAgua()
{
    Console.WriteLine("Calentando agua...");
    await Task.Delay(2000);
    Console.WriteLine("Agua caliente");
}

static async void ComprarPan()
{
    Console.WriteLine("Comprando pan...");
    await Task.Delay(500); // Simula que comprar pan toma 2 segundos
    Console.WriteLine("Pan comprado.");
}

static async void ComprarHuevos()
{
    Console.WriteLine("Comprando huevos...");
    await Task.Delay(1000);
    Console.WriteLine("Huevos comprados.");
}

static async void PrepararCafe()
{
    Console.WriteLine("Preparando café...");
    await Task.Delay(4000); // Simula que comprar pan toma 2 segundos
    Console.WriteLine("Café listo.");
}

static async void FreirHuevo()
{
    Console.WriteLine("Friendo huevo...");
    await Task.Delay(3000); // Simula que comprar pan toma 2 segundos
    Console.WriteLine("Huevo listo.");
}

FreirHuevo();
PrepararCafe();
ComprarHuevos();
ComprarPan();
CalentarAgua();

Console.ReadKey();