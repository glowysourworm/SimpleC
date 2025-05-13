using System.Runtime.Serialization;

namespace SimpleC.Base.Exception
{
    /// <summary>
    /// Marker class for all exceptions internal to this application
    /// </summary>
    public class SimpleCException : System.Exception
    {
        public SimpleCException()
        {
        }

        public SimpleCException(string? message) : base(message)
        {
        }

        public SimpleCException(string? message, System.Exception? innerException) : base(message, innerException)
        {
        }

        protected SimpleCException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
