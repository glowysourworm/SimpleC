using SimpleC.Grammar.PhraseStructureGrammar.Declarations;

namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    public class CastExpression : GrammarBase
    {
        UnaryExpression _unaryExpression1;

        public const char BracketLeftOpen2 = GrammarCConstants.BracketLeft;
        TypeName _typeName2;
        public const char BracketRightClose2 = GrammarCConstants.BracketRight;
        CastExpression _castExpression2;

        public UnaryExpression UnaryExpression1
        {
            get { return _unaryExpression1; }
            set { this.RaiseAndSetIfChanged(ref _unaryExpression1, value); }
        }
        public TypeName TypeName2
        {
            get { return _typeName2; }
            set { this.RaiseAndSetIfChanged(ref _typeName2, value); }
        }
        public CastExpression CastExpression2
        {
            get { return _castExpression2; }
            set { this.RaiseAndSetIfChanged(ref _castExpression2, value); }
        }

        public CastExpression()
        {
            this.UnaryExpression1 = new UnaryExpression();
            this.TypeName2 = new TypeName();
            this.CastExpression2 = new CastExpression();
        }
    }
}
