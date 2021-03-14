using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Exceptions
{
    class MethodNotFoundException : Exception
    {
        public MethodNotFoundException() : base() { }
        public MethodNotFoundException(string message) : base(message) { }
        public MethodNotFoundException(string message, Exception inner)
            : base(message, inner) { }
        public override string ToString()
        {
            return Message;
        }
    }
}
