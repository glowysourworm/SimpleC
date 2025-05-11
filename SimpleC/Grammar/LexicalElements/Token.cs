using SimpleC.Grammar.LexicalElements.Constants;
using SimpleC.Grammar.LexicalElements.Identifiers;
using SimpleC.Grammar.LexicalElements.StringLiterals;

namespace SimpleC.Grammar.LexicalElements
{
    /// <summary>
    /// (See A.1.1 -> 6.4) token:
    /// </summary>
    public class Token : GrammarBase
    {
        Keyword _keyword;
        Identifier _identifier;
        Constant _constant;
        StringLiteral _stringLiteral;
        Punctuator _punctuator;
    }
}
