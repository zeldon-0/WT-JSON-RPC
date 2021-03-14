using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Exceptions
{
    public class ParseException : Exception
    {
        public ParseException() : base() { }
        public ParseException(string message) : base(message) { }
        public ParseException(string message, Exception inner)
            : base(message, inner) { }
        public override string ToString()
        {
            return Message;
        }
    }
}
