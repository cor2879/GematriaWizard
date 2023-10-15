using System;
using System.Runtime.Serialization;

namespace GematriaWizard.Utility.Exceptions
{
    public class GematriaException : Exception
    {
        public GematriaException() { }

        public GematriaException(string message) : base(message) { }

        public GematriaException(string message, Exception innerException) : base(message, innerException) { }
    }
}
