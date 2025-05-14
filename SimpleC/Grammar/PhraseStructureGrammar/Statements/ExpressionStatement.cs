using SimpleC.Grammar.PhraseStructureGrammar.Expressions;

namespace SimpleC.Grammar.PhraseStructureGrammar.Statements
{
    public class ExpressionStatement : Statement
    {
        Expression? _expression1;
        public const char StatementSeparator = GrammarCConstants.Semicolon;

        public Expression? Expression1
        {
            get { return _expression1; }
            set { this.RaiseAndSetIfChanged(ref _expression1, value); }
        }

        public ExpressionStatement()
        {
            this.Expression1 = null;
        }
    }
}
