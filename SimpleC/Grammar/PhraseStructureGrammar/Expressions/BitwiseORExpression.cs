namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    public class BitwiseORExpression : GrammarBase
    {
        BitwiseXORExpression _bitwiseXORExpression1;

        BitwiseORExpression _bitwiseORExpression2;
        public const string BitwiseOROperator2 = GrammarCOperators.BitwiseOR;
        BitwiseXORExpression _bitwiseXORExpression2;

        public BitwiseXORExpression BitwiseXORExpression1
        {
            get { return _bitwiseXORExpression1; }
            set { this.RaiseAndSetIfChanged(ref _bitwiseXORExpression1, value); }
        }
        public BitwiseORExpression BitwiseORExpression2
        {
            get { return _bitwiseORExpression2; }
            set { this.RaiseAndSetIfChanged(ref _bitwiseORExpression2, value); }
        }
        public BitwiseXORExpression BitwiseXORExpression2
        {
            get { return _bitwiseXORExpression2; }
            set { this.RaiseAndSetIfChanged(ref _bitwiseXORExpression2, value); }
        }

        public BitwiseORExpression()
        {
            this.BitwiseORExpression2 = new BitwiseORExpression();
            this.BitwiseXORExpression1 = new BitwiseXORExpression();
            this.BitwiseXORExpression2 = new BitwiseXORExpression();
        }
    }
}
