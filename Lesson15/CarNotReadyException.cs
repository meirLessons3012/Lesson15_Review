using System.Runtime.Serialization;

namespace Lesson15
{
    [Serializable]
    internal class CarNotReadyException : Exception
    {
        public CarNotReadyException()
        {
        }

        public CarNotReadyException(string? message) : base(message)
        {
        }

        public CarNotReadyException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CarNotReadyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}