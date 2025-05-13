namespace SimpleC.Grammar.LexicalElements.Constants
{
    public class HexadecimalEscapeSequence : GrammarBase
    {
        /// <summary>
        /// Specific escape sequence to this grammar element
        /// </summary>
        public const string PrefixEscapeSequence1 = "\\x";
        HexadecimalDigit _hexadecimalDigit1;

        HexadecimalEscapeSequence _hexadecimalEscapeSequence2;
        HexadecimalDigit _hexadecimalDigit2;

        public HexadecimalDigit HexadecimalDigit1
        {
            get { return _hexadecimalDigit1; }
            set { this.RaiseAndSetIfChanged(ref _hexadecimalDigit1, value); }
        }
        public HexadecimalEscapeSequence HexadecimalEscapeSequence2
        {
            get { return _hexadecimalEscapeSequence2; }
            set { this.RaiseAndSetIfChanged(ref _hexadecimalEscapeSequence2, value); }
        }
        public HexadecimalDigit HexadecimalDigit2
        {
            get { return _hexadecimalDigit2; }
            set { this.RaiseAndSetIfChanged(ref _hexadecimalDigit2, value); }
        }

        public HexadecimalEscapeSequence()
        {
            this.HexadecimalDigit1 = new HexadecimalDigit();
            this.HexadecimalDigit2 = new HexadecimalDigit();
            this.HexadecimalEscapeSequence2 = new HexadecimalEscapeSequence();
        }
    }
}
