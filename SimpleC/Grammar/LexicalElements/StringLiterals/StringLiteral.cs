namespace SimpleC.Grammar.LexicalElements.StringLiterals
{
    public class StringLiteral : GrammarBase
    {
        public const char PrefixDoubleQuote1 = GrammarCConstants.DoubleQuote;
        public SCharSequence? _sequence1;
        public const char SuffixDoubleQuote1 = GrammarCConstants.DoubleQuote;

        public const char PrefixLiteralConstant2 = GrammarCConstants.Letter_L;
        public const char PrefixDoubleQuote2 = GrammarCConstants.DoubleQuote;
        public SCharSequence? _sequence2;
        public const char SuffixDoubleQuote2 = GrammarCConstants.DoubleQuote;

        public SCharSequence? Sequence1
        {
            get { return _sequence1; }
            set { this.RaiseAndSetIfChanged(ref _sequence1, value); }
        }
        public SCharSequence? Sequence2
        {
            get { return _sequence2; }
            set { this.RaiseAndSetIfChanged(ref _sequence2, value); }
        }

        public StringLiteral()
        {
            this.Sequence1 = null;
            this.Sequence2 = null;
        }
    }
}
