using System;
using Xunit;

using CRUDQL.Interpreter;
using System.Diagnostics;

namespace CRUDQL.Tests
{
    public class LexerTests
    {
        [Fact]
        public void LexerTest()
        {
            var tokens = Lexer.Tokenize("create a new table called People with name as text, birthday as date, and age as number.");
            foreach(var t in tokens)
            {
                Debug.WriteLine($"Type: {t.Type} Value: {t.Value} Position: ({t.Position.Row},{t.Position.Column})");
            }
        }

    }
}
