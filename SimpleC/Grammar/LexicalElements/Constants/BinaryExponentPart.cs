namespace SimpleC.Grammar.LexicalElements.Constants
{
    public class BinaryExponentPart : GrammarBase
    {
        public const char PrefixLowerCase = GrammarCConstants.Letter_p;
        public const char PrefixUpperCase = GrammarCConstants.Letter_P;

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

        public BinaryExponentPart()
        {
            this.Sign = null;
            this.DigitSequence = new DigitSequence();
        }
    }
}
