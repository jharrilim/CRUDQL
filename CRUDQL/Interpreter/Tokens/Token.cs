using System;
using System.Collections.Generic;
using System.Text;

namespace CRUDQL.Interpreter.Tokens
{
    public class Token
    {
        public TokenType Type { get; }
        public TokenPosition Position { get; }

        public string Value { get; }

        public Token(TokenType type, TokenPosition position, string val = "")
        {
            Type = type;
            Position = position;
            if (val == "")
                val = type.ToString();
            Value = val;
        }

    }
}
