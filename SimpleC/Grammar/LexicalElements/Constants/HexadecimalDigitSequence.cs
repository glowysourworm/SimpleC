namespace SimpleC.Grammar.LexicalElements.Constants
{
    public class HexadecimalDigitSequence : GrammarBase
    {
        HexadecimalDigit _hexadecimalDigit1;
        HexadecimalDigitSequence _hexadecimalDigitSequence2;
        HexadecimalDigit _hexadecimalDigit2;

        public HexadecimalDigit HexadecimalDigit1
        {
            get { return _hexadecimalDigit1; }
            set { this.RaiseAndSetIfChanged(ref _hexadecimalDigit1, value); }
        }
        public HexadecimalDigitSequence HexadecimalDigitSequence2
        {
            get { return _hexadecimalDigitSequence2; }
            set { this.RaiseAndSetIfChanged(ref _hexadecimalDigitSequence2, value); }
        }
        public HexadecimalDigit HexadecimalDigit2
        {
            get { return _hexadecimalDigit2; }
            set { this.RaiseAndSetIfChanged(ref _hexadecimalDigit2, value); }
        }

        public HexadecimalDigitSequence()
        {
            this.HexadecimalDigit1 = new HexadecimalDigit();
            this.HexadecimalDigitSequence2 = new HexadecimalDigitSequence();
            this.HexadecimalDigit2 = new HexadecimalDigit();
        }
    }
}
