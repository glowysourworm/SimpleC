namespace SimpleC.Grammar.LexicalElements.Constants
{
    public class ExponentPart : GrammarBase
    {
        const char PrefixLowerCase = GrammarCConstants.Letter_e;
        const char PrefixUpperCase = GrammarCConstants.Letter_E;

        Sign? _sign;

        DigitSequence _digitSequence;

        public Sign? Sign
        {
            get { return _sign; }
            set { this.RaiseAndSetIfChanged(ref _sign, value); }
        }
        public DigitSequence DigitSequence
        {
            get { return _digitSequence; }
            set { this.RaiseAndSetIfChanged(ref _digitSequence, value); }
        }

        public ExponentPart()
        {
            this.Sign = null;
            this.DigitSequence = new DigitSequence();
        }
    }
}
