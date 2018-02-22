using System;
using System.Collections.Generic;
using System.Text;

namespace CRUDQL.Interpreter.Tokens
{
    public enum TokenType
    {
        Create,
        Read,
        Update,
        Delete,
        DataType,
        FullStop,
        Comma,
        Where,
        With,
        Is,
        IsNot,
        Word
    }
}
