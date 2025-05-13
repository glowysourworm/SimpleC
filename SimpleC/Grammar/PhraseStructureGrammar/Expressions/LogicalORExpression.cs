namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    public class LogicalORExpression : GrammarBase
    {
        // See Annex (6.5.14)
        LogicalANDExpression _logicalANDExpression1;

        LogicalORExpression _logicalORExpression2;
        public const string LogicalOROperator = GrammarCOperators.LogicalOR;
        LogicalANDExpression _logicalANDExpression2;

        public LogicalANDExpression LogicalANDExpression1
        {
            get { return _logicalANDExpression1; }
            set { this.RaiseAndSetIfChanged(ref _logicalANDExpression1, value); }
        }
        public LogicalORExpression LogicalORExpression2
        {
            get { return _logicalORExpression2; }
            set { this.RaiseAndSetIfChanged(ref _logicalORExpression2, value); }
        }
        public LogicalANDExpression LogicalANDExpression2
        {
            get { return _logicalANDExpression2; }
            set { this.RaiseAndSetIfChanged(ref _logicalANDExpression2, value); }
        }


        public LogicalORExpression()
        {
            this.LogicalANDExpression1 = new LogicalANDExpression();
            this.LogicalANDExpression2 = new LogicalANDExpression();
            this.LogicalORExpression2 = new LogicalORExpression();
        }
    }
}
