using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Exceptions
{
    public class InvalidRequestException : Exception
    {
        public InvalidRequestException() : base() { }
        public InvalidRequestException(string message) : base(message) { }
        public InvalidRequestException(string message, Exception inner)
            : base(message, inner) { }
        public override string ToString()
        {
            return Message;
        }
    }
}
