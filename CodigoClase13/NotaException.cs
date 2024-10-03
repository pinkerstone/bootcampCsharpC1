// See https://aka.ms/new-console-template for more information




[Serializable]
internal class NotaException : Exception
{
    public NotaException()
    {
    }

    public NotaException(string? message) : base(message)
    {
    }

    public NotaException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}