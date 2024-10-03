// See https://aka.ms/new-console-template for more information


[Serializable]
public class CustomException : Exception
{
    public CustomException() : base("Valor 2 mayor que valor 1") { }

}