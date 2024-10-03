// See https://aka.ms/new-console-template for more information




[Serializable]
internal class InvalidCustomException : Exception
{

    public InvalidCustomException() : base("La edad es inválida por estar fuera del rango") {}

}