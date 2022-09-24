using System.Runtime.Serialization;

namespace BindERP.Connector.Exceptions
{
    [Serializable]
    public class UnableToSerializeException : Exception
    {
        public UnableToSerializeException()
        {
        }

        public UnableToSerializeException(string? message) : base(message)
        {
        }

        public UnableToSerializeException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected UnableToSerializeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}