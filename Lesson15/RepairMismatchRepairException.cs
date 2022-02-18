using System.Runtime.Serialization;

namespace Lesson15
{
    [Serializable]
    internal class RepairMismatchRepairException : Exception
    {
        public RepairMismatchRepairException()
        {
        }

        public RepairMismatchRepairException(string? message) : base(message)
        {
        }

        public RepairMismatchRepairException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected RepairMismatchRepairException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}