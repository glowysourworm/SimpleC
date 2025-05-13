namespace SimpleC.Grammar.LexicalElements.Constants
{
    public class HexadecimalFractionalConstant : GrammarBase
    {
        HexadecimalDigitSequence? _hexadecimalDigitSequence1a;
        const char Dot1 = GrammarCConstants.Period;
        HexadecimalDigitSequence _hexadecimalDigitSequence1b;

        HexadecimalDigitSequence _hexadecimalDigitSequence2;
        const char Dot2 = GrammarCConstants.Period;

        public HexadecimalDigitSequence? HexadecimalDigitSequence1a
        {
            get { return _hexadecimalDigitSequence1a; }
            set { this.RaiseAndSetIfChanged(ref _hexadecimalDigitSequence1a, value); }
        }
        public HexadecimalDigitSequence HexadecimalDigitSequence1b
        {
            get { return _hexadecimalDigitSequence1b; }
            set { this.RaiseAndSetIfChanged(ref _hexadecimalDigitSequence1b, value); }
        }
        public HexadecimalDigitSequence HexadecimalDigitSequence2
        {
            get { return _hexadecimalDigitSequence2; }
            set { this.RaiseAndSetIfChanged(ref _hexadecimalDigitSequence2, value); }
        }

        public HexadecimalFractionalConstant()
        {
            this.HexadecimalDigitSequence1a = null;
            this.HexadecimalDigitSequence1b = new HexadecimalDigitSequence();
            this.HexadecimalDigitSequence2 = new HexadecimalDigitSequence();
        }
    }
}
