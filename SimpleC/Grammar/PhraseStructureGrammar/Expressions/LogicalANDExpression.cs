namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    public class LogicalANDExpression : GrammarBase
    {
        // See Annex (6.5.13)
        BitwiseORExpression _bitwiseORExpression1;

        LogicalANDExpression _logicalANDExpression2;
        public const string LogicalANDOperator = GrammarCOperators.LogicalAND;
        BitwiseORExpression _bitwiseORExpression2;

        public BitwiseORExpression BitwiseORExpression1
        {
            get { return _bitwiseORExpression1; }
            set { this.RaiseAndSetIfChanged(ref _bitwiseORExpression1, value); }
        }
        public LogicalANDExpression LogicalANDExpression2
        {
            get { return _logicalANDExpression2; }
            set { this.RaiseAndSetIfChanged(ref _logicalANDExpression2, value); }
        }
        public BitwiseORExpression BitwiseORExpression2
        {
            get { return _bitwiseORExpression2; }
            set { this.RaiseAndSetIfChanged(ref _bitwiseORExpression2, value); }
        }


        public LogicalANDExpression()
        {
            this.BitwiseORExpression1 = new BitwiseORExpression();
            this.LogicalANDExpression2 = new LogicalANDExpression();
            this.BitwiseORExpression2 = new BitwiseORExpression();
        }
    }
}
