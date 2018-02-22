using System;
using System.Collections.Generic;
using System.Text;

namespace CRUDQL.Interpreter
{
    enum ParserState
    {
        Verb,
        Article,
        Object,
        Predicate,
        Preposition
    }
}
