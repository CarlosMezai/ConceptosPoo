using System;
using System.Runtime.Serialization;

namespace CoceptosPoo
{
    [Serializable]
    internal class MonthExceptions : Exception
    {
        public MonthExceptions()
        {
        }

        public MonthExceptions(string message) : base(message)
        {
        }

        public MonthExceptions(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MonthExceptions(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}