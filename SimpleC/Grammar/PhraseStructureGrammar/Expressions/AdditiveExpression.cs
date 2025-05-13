namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    public class AdditiveExpression : GrammarBase
    {
        MultiplicativeExpression _multiplicativeExpression1;

        AdditiveExpression _additiveExpression2;
        public const string AdditionOperator2 = GrammarCOperators.Addition;
        MultiplicativeExpression _multiplicativeExpression2;

        AdditiveExpression _additiveExpression3;
        public const string SubtractionOperator3 = GrammarCOperators.Subtraction;
        MultiplicativeExpression _multiplicativeExpression3;

        public MultiplicativeExpression MultiplicativeExpression1
        {
            get { return _multiplicativeExpression1; }
            set { this.RaiseAndSetIfChanged(ref _multiplicativeExpression1, value); }
        }
        public AdditiveExpression AdditiveExpression2
        {
            get { return _additiveExpression2; }
            set { this.RaiseAndSetIfChanged(ref _additiveExpression2, value); }
        }
        public MultiplicativeExpression MultiplicativeExpression2
        {
            get { return _multiplicativeExpression2; }
            set { this.RaiseAndSetIfChanged(ref _multiplicativeExpression2, value); }
        }
        public AdditiveExpression AdditiveExpression3
        {
            get { return _additiveExpression3; }
            set { this.RaiseAndSetIfChanged(ref _additiveExpression3, value); }
        }
        public MultiplicativeExpression MultiplicativeExpression3
        {
            get { return _multiplicativeExpression3; }
            set { this.RaiseAndSetIfChanged(ref _multiplicativeExpression3, value); }
        }

        public AdditiveExpression()
        {
            this.AdditiveExpression2 = new AdditiveExpression();
            this.AdditiveExpression3 = new AdditiveExpression();
            this.MultiplicativeExpression1 = new MultiplicativeExpression();
            this.MultiplicativeExpression2 = new MultiplicativeExpression();
            this.MultiplicativeExpression3 = new MultiplicativeExpression();
        }
    }
}
