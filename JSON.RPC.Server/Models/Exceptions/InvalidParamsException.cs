using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Exceptions
{
    public class InvalidParamsException : Exception
    {
        public InvalidParamsException() : base() { }
        public InvalidParamsException(string message) : base(message) { }
        public InvalidParamsException(string message, Exception inner)
            : base(message, inner) { }
        public override string ToString()
        {
            return Message;
        }
    }
}
