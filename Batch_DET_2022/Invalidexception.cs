using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
 
        internal class InvalidAgeException : Exception
        {
            public InvalidAgeException()
            {
            }

            public InvalidAgeException(string? message) : base(message)
            {
            }

            public InvalidAgeException(string? message, Exception? innerException) : base(message, innerException)
            {
            }

            protected InvalidAgeException(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
    
}
