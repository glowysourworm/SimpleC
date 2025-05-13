namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    public class ShiftExpression : GrammarBase
    {
        AdditiveExpression _additiveExpression1;

        ShiftExpression _shiftExpression2;
        public const string BitwiseLeftShiftOperator2 = GrammarCOperators.BitwiseLeftShift;
        AdditiveExpression _additiveExpression2;

        ShiftExpression _shiftExpression3;
        public const string BitwiseRightShiftOperator3 = GrammarCOperators.BitwiseRightShift;
        AdditiveExpression _additiveExpression3;

        public AdditiveExpression AdditiveExpression1
        {
            get { return _additiveExpression1; }
            set { this.RaiseAndSetIfChanged(ref _additiveExpression1, value); }
        }
        public ShiftExpression ShiftExpression2
        {
            get { return _shiftExpression2; }
            set { this.RaiseAndSetIfChanged(ref _shiftExpression2, value); }
        }
        public AdditiveExpression AdditiveExpression2
        {
            get { return _additiveExpression2; }
            set { this.RaiseAndSetIfChanged(ref _additiveExpression2, value); }
        }
        public ShiftExpression ShiftExpression3
        {
            get { return _shiftExpression3; }
            set { this.RaiseAndSetIfChanged(ref _shiftExpression3, value); }
        }
        public AdditiveExpression AdditiveExpression3
        {
            get { return _additiveExpression3; }
            set { this.RaiseAndSetIfChanged(ref _additiveExpression3, value); }
        }

        public ShiftExpression()
        {
            this.AdditiveExpression1 = new AdditiveExpression();
            this.AdditiveExpression2 = new AdditiveExpression();
            this.AdditiveExpression3 = new AdditiveExpression();
            this.ShiftExpression2 = new ShiftExpression();
            this.ShiftExpression3 = new ShiftExpression();
        }
    }
}
