using SimpleC.Grammar.LexicalElements.Identifiers;
using SimpleC.Grammar.PhraseStructureGrammar.Expressions;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    public class Designator : GrammarBase
    {
        public const char DesignatorBracketOpen1 = GrammarCConstants.BracketSquareLeft;
        ConstantExpression _constantExpression1;
        public const char DesignatorBracketClose1 = GrammarCConstants.BracketSquareRight;

        public const char DesignatorPeriodPunctuator2 = GrammarCConstants.Period;
        Identifier _identifier2;

        public ConstantExpression ConstantExpression1
        {
            get { return _constantExpression1; }
            set { this.RaiseAndSetIfChanged(ref _constantExpression1, value); }
        }
        public Identifier Identifier2
        {
            get { return _identifier2; }
            set { this.RaiseAndSetIfChanged(ref _identifier2, value); }
        }

        public Designator()
        {
            this.ConstantExpression1 = new ConstantExpression();
            this.Identifier2 = new Identifier();
        }
    }
}
