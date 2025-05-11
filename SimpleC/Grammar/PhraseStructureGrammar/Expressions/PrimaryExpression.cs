using SimpleC.Grammar.LexicalElements.Constants;
using SimpleC.Grammar.LexicalElements.Identifiers;
using SimpleC.Grammar.LexicalElements.StringLiterals;

namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    /// <summary>
    /// (See C99, Appendix A.2.1 -> 6.5.1)
    /// </summary>
    public class PrimaryExpression : GrammarBase
    {
        Identifier _identifier;
        Constant _constant;
        StringLiteral _literal;

        // TODO: Must be surrounded by brackets
        Expression _expression;
    }
}
