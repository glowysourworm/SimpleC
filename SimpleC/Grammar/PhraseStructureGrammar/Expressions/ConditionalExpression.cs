namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    public class ConditionalExpression : GrammarBase
    {
        LogicalORExpression _logicalORExpression1;

        LogicalORExpression _logicalORExpression2;
        public const string TertiaryBranchOperatorQuestionMark = GrammarCOperators.TertiaryIfThenQuestionMark;
        Expression _expression2;
        public const string TertiaryBranchOperatorColon = GrammarCOperators.TertiaryIfThenColon;
        ConditionalExpression _conditionalExpression2;

        public LogicalORExpression LogicalORExpression1
        {
            get { return _logicalORExpression1; }
            set { this.RaiseAndSetIfChanged(ref _logicalORExpression1, value); }
        }
        public LogicalORExpression LogicalORExpression2
        {
            get { return _logicalORExpression2; }
            set { this.RaiseAndSetIfChanged(ref _logicalORExpression2, value); }
        }
        public Expression Expression2
        {
            get { return _expression2; }
            set { this.RaiseAndSetIfChanged(ref _expression2, value); }
        }
        public ConditionalExpression ConditionalExpression2
        {
            get { return _conditionalExpression2; }
            set { this.RaiseAndSetIfChanged(ref _conditionalExpression2, value); }
        }


        public ConditionalExpression()
        {
            this.ConditionalExpression2 = new ConditionalExpression();
            this.Expression2 = new Expression();
            this.LogicalORExpression1 = new LogicalORExpression();
            this.LogicalORExpression2 = new LogicalORExpression();
        }
    }
}
