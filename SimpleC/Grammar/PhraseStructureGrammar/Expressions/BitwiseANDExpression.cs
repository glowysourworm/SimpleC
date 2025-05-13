namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    public class BitwiseANDExpression : GrammarBase
    {
        EqualityExpression _equalityExpression1;

        BitwiseANDExpression _bitwiseANDExpression2;
        public const string BitwiseANDOperator = GrammarCOperators.BitwiseAND;
        EqualityExpression _equalityExpression2;

        public EqualityExpression EqualityExpression1
        {
            get { return _equalityExpression1; }
            set { this.RaiseAndSetIfChanged(ref _equalityExpression1, value); }
        }
        public BitwiseANDExpression BitwiseANDExpression2
        {
            get { return _bitwiseANDExpression2; }
            set { this.RaiseAndSetIfChanged(ref _bitwiseANDExpression2, value); }
        }
        public EqualityExpression EqualityExpression2
        {
            get { return _equalityExpression2; }
            set { this.RaiseAndSetIfChanged(ref _equalityExpression2, value); }
        }

        public BitwiseANDExpression()
        {
            this.EqualityExpression1 = new EqualityExpression();
            this.BitwiseANDExpression2 = new BitwiseANDExpression();
            this.EqualityExpression2 = new EqualityExpression();
        }
    }
}
