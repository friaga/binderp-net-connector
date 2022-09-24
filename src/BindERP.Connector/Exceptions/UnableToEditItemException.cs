using System.Runtime.Serialization;

namespace BindERP.Connector.Exceptions
{
    [Serializable]
    internal class UnableToEditItemException : Exception
    {
        public UnableToEditItemException()
        {
        }

        public UnableToEditItemException(string? message) : base(message)
        {
        }

        public UnableToEditItemException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected UnableToEditItemException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}