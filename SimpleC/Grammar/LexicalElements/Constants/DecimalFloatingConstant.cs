namespace SimpleC.Grammar.LexicalElements.Constants
{
    public class DecimalFloatingConstant : GrammarBase
    {
        FractionalConstant _fractionalConstant1;
        ExponentPart _exponentPart1;
        FloatingSuffix _floatingSuffix1;
        DigitSequence _digitSequence2;
        ExponentPart _exponentPart2;
        FloatingSuffix _floatingSuffix2;

        public FractionalConstant FractionalConstant1
        {
            get { return _fractionalConstant1; }
            set { this.RaiseAndSetIfChanged(ref _fractionalConstant1, value); }
        }
        public ExponentPart ExponentPart1
        {
            get { return _exponentPart1; }
            set { this.RaiseAndSetIfChanged(ref _exponentPart1, value); }
        }
        public FloatingSuffix FloatingSuffix1
        {
            get { return _floatingSuffix1; }
            set { this.RaiseAndSetIfChanged(ref _floatingSuffix1, value); }
        }
        public DigitSequence DigitSequence2
        {
            get { return _digitSequence2; }
            set { this.RaiseAndSetIfChanged(ref _digitSequence2, value); }
        }
        public ExponentPart ExponentPart2
        {
            get { return _exponentPart2; }
            set { this.RaiseAndSetIfChanged(ref _exponentPart2, value); }
        }
        public FloatingSuffix FloatingSuffix2
        {
            get { return _floatingSuffix2; }
            set { this.RaiseAndSetIfChanged(ref _floatingSuffix2, value); }
        }

        public DecimalFloatingConstant()
        {
            this.FloatingSuffix1 = new FloatingSuffix();
            this.FractionalConstant1 = new FractionalConstant();
            this.ExponentPart1 = new ExponentPart();
            this.DigitSequence2 = new DigitSequence();
            this.ExponentPart2 = new ExponentPart();
            this.FloatingSuffix2 = new FloatingSuffix();
        }
    }
}
