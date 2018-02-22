using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CRUDQL.Interpreter.Tokens
{
    class TokenDefinition
    {
        private Regex regex;
        public TokenType Type { get; }

        public TokenDefinition(string pattern, TokenType type)
        {
            regex = new Regex(pattern);
            Type = type;
        }
        
        public Boolean IsMatch(string s)
        {
            return regex.IsMatch(s);
        }
    }
}
