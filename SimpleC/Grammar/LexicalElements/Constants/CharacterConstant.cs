namespace SimpleC.Grammar.LexicalElements.Constants
{
    public class CharacterConstant : GrammarBase
    {
        const char PrefixApostrophe1 = GrammarCConstants.SingleQuote;
        CCharSequence _sequence1;
        const char PostfixApostrophe1 = GrammarCConstants.SingleQuote;

        const char PrefixLiteralConstant = GrammarCConstants.Letter_L;
        const char PrefixApostrophe2 = GrammarCConstants.SingleQuote;
        CCharSequence _sequence2;
        const char PostfixApostrophe2 = GrammarCConstants.SingleQuote;

        public CCharSequence Sequence1
        {
            get { return _sequence1; }
            set { this.RaiseAndSetIfChanged(ref _sequence1, value); }
        }
        public CCharSequence Sequence2
        {
            get { return _sequence2; }
            set { this.RaiseAndSetIfChanged(ref _sequence2, value); }
        }

        public CharacterConstant()
        {
            this.Sequence1 = new CCharSequence();
            this.Sequence2 = new CCharSequence();
        }
    }
}
