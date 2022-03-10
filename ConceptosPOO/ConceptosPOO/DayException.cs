using System;
using System.Runtime.Serialization;

namespace ConceptosPOO
{
    [Serializable]
    internal class DayException : Exception
    {
        private char v;

        public DayException()
        {
        }

        public DayException(char v)
        {
            this.v = v;
        }

        public DayException(string message) : base(message)
        {
        }

        public DayException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DayException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}