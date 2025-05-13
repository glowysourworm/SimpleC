namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    public class ConstantExpression : GrammarBase
    {
        ConditionalExpression _conditionalExpression;

        public ConditionalExpression ConditionalExpression
        {
            get { return _conditionalExpression; }
            set { this.RaiseAndSetIfChanged(ref _conditionalExpression, value); }
        }

        public ConstantExpression()
        {
            this.ConditionalExpression = new ConditionalExpression();
        }
    }
}
