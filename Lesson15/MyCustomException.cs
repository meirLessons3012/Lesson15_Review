using System.Runtime.Serialization;

[Serializable]
internal class MyCustomException : Exception
{
    public int N1 { get; set; }
    public int N2 { get; set; }

    public MyCustomException(int n1, int n2, string message) : base(message)
    {
        N1 = n1;
        N2 = n2;
    }

    public MyCustomException(string? message) : base(message)
    {
    }

    public MyCustomException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected MyCustomException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}