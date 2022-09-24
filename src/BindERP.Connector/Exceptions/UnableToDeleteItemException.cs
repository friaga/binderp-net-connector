using System.Runtime.Serialization;

namespace BindERP.Connector.Exceptions;

[Serializable]
public class UnableToDeleteItemException : Exception
{
    public UnableToDeleteItemException()
    {
    }

    public UnableToDeleteItemException(string? message) 
        : base(message)
    {
    }

    public UnableToDeleteItemException(string? message, Exception? innerException) 
        : base(message, innerException)
    {
    }

    protected UnableToDeleteItemException(SerializationInfo info, StreamingContext context) 
        : base(info, context)
    {
    }
}