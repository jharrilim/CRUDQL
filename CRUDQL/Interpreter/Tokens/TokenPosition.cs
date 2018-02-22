using System;
using System.Collections.Generic;
using System.Text;

namespace CRUDQL.Interpreter.Tokens
{
    public class TokenPosition
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public TokenPosition()
        {
            Row = 0;
            Column = 0;
        }
    }
}
