using System;
using System.Collections.Generic;
using System.Text;

namespace CRUDQL.Interpreter.Exceptions
{
    class SyntaxException : Exception
    {
        public SyntaxException() : base() { }
        public SyntaxException(string msg) : base(msg) { }
        public SyntaxException(string msg, Exception inner) : base(msg, inner) { }
    }
}
