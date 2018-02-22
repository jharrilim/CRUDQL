using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

using CRUDQL.Interpreter.Tokens;
using CRUDQL.Interpreter.Exceptions;

namespace CRUDQL.Interpreter
{
    public partial class Lexer
    {
        private Lexer() { }

        public static List<Token> Tokenize(string text)
        {  // TODO: Fix position issues
            List<Token> tokens = new List<Token>();
            TokenPosition position = new TokenPosition();
            for(int i = 0; i < text.Length; i++)
            {
                if (Char.IsWhiteSpace(text[i]))
                {
                    position.Column++;
                    continue;
                }

                if (text[i] == '\r')
                {
                    position.Column = 1;
                    continue;
                }
                if (text[i] == '\n')
                {
                    position.Column = 1;
                    position.Row++;
                    continue;
                }

                StringBuilder sb = new StringBuilder();
                if (Char.IsLetter(text[i]))
                {
                    while (Char.IsLetter(text[i]))
                    {
                        sb.Append(text[i]);
                        i++;
                        position.Column++;
                    }
                    i--;  // TODO: This feels like a hack
                }
                else sb.Append(text[i]);
                string str = sb.ToString();
                foreach (var def in definitions)
                {
                    if (def.IsMatch(str))
                    {
                        tokens.Add
                        (
                            new Token(def.Type, position, str)
                        );
                        break;
                    }
                }
            }

            return tokens;
        }


        public void Tokenize(StreamReader streamReader) => Tokenize(streamReader.ReadToEnd());
    }


}
