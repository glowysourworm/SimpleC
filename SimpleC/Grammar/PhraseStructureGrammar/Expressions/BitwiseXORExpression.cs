namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    public class BitwiseXORExpression : GrammarBase
    {
        BitwiseANDExpression _bitwiseANDExpression1;

        BitwiseXORExpression _bitwiseXORExpression2;
        public const string BitwiseXOROperator = GrammarCOperators.BitwiseXOR;
        BitwiseANDExpression _bitwiseANDExpression2;

        public BitwiseANDExpression BitwiseANDExpression1
        {
            get { return _bitwiseANDExpression1; }
            set { this.RaiseAndSetIfChanged(ref _bitwiseANDExpression1, value); }
        }
        public BitwiseXORExpression BitwiseXORExpression2
        {
            get { return _bitwiseXORExpression2; }
            set { this.RaiseAndSetIfChanged(ref _bitwiseXORExpression2, value); }
        }
        public BitwiseANDExpression BitwiseANDExpression2
        {
            get { return _bitwiseANDExpression2; }
            set { this.RaiseAndSetIfChanged(ref _bitwiseANDExpression2, value); }
        }


        public BitwiseXORExpression()
        {
            this.BitwiseANDExpression1 = new BitwiseANDExpression();
            this.BitwiseXORExpression2 = new BitwiseXORExpression();
            this.BitwiseANDExpression2 = new BitwiseANDExpression();
        }
    }
}
