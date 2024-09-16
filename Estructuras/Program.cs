// See https://aka.ms/new-console-template for more information

public struct Persona
{
    public string nombre;
    public string ciudad;
    public int edad;
}

public class Producto
{

}
class Program
{
    static void Main(string[] args)
    {
        Persona persona = new Persona();
        persona.edad = 36;
        persona.nombre = "Hugo";
        persona.ciudad = "Nasca";

    }
}
