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

        public const char LeftBracket = GrammarCConstants.BracketLeft;
        Expression _expression;
        public const char RightBracket = GrammarCConstants.BracketRight;

        public Identifier Identifier
        {
            get { return _identifier; }
            set { this.RaiseAndSetIfChanged(ref _identifier, value); }
        }
        public Constant Constant
        {
            get { return _constant; }
            set { this.RaiseAndSetIfChanged(ref _constant, value); }
        }
        public StringLiteral Literal
        {
            get { return _literal; }
            set { this.RaiseAndSetIfChanged(ref _literal, value); }
        }
        public Expression Expression
        {
            get { return _expression; }
            set { this.RaiseAndSetIfChanged(ref _expression, value); }
        }

        public PrimaryExpression()
        {
            this.Identifier = new Identifier();
            this.Constant = new Constant();
            this.Literal = new StringLiteral();
            this.Expression = new Expression();
        }
    }
}
