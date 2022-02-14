using System;
using System.Runtime.Serialization;

namespace CabInvoiceGenerator
{
    [Serializable]
    internal class CabInvoiceException : Exception
    {
        private object iNVALID_USER_ID;
        private string v;

        public CabInvoiceException()
        {
        }

        public CabInvoiceException(string message) : base(message)
        {
        }

        public CabInvoiceException(object iNVALID_USER_ID, string v)
        {
            this.iNVALID_USER_ID = iNVALID_USER_ID;
            this.v = v;
        }

        public CabInvoiceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CabInvoiceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public static object ExceptionType { get; internal set; }
    }
}