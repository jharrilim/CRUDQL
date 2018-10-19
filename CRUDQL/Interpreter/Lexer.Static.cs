using System.Collections.Generic;
using CRUDQL.Interpreter.Tokens;

namespace CRUDQL.Interpreter
{
    partial class Lexer
    {
        private static readonly List<TokenDefinition> definitions;

        static Lexer()
        {
            definitions = new List<TokenDefinition>()
            {
                new TokenDefinition("[,]", TokenType.Comma),
                new TokenDefinition("(create)", TokenType.Create),
                new TokenDefinition("(number|text|date|boolean)", TokenType.DataType),
                new TokenDefinition("(delete)", TokenType.Delete),
                new TokenDefinition("[.]", TokenType.FullStop),
                new TokenDefinition("(is not|isn't)", TokenType.IsNot),
                new TokenDefinition("(is|equals)", TokenType.Is),
                new TokenDefinition("(view|show|get|read)", TokenType.Read),
                new TokenDefinition("(change|update|modify)", TokenType.Update),
                new TokenDefinition("(where)", TokenType.Where),
                new TokenDefinition("(with)", TokenType.With),
                new TokenDefinition("(table)", TokenType.Table),
                new TokenDefinition("(user)", TokenType.User),
                new TokenDefinition("(record)", TokenType.Record),
                new TokenDefinition(@"[^\s-]", TokenType.Word)
            };
        }

    }
}
