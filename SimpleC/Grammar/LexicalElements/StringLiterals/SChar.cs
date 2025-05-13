using SimpleC.Grammar.LexicalElements.Constants;

namespace SimpleC.Grammar.LexicalElements.StringLiterals
{
    public class SChar : GrammarBase
    {
        // "Any member of the source character set except the single-quote ', backslash \, or new-line character"
        char _char;
        EscapeSequence _escapeSequence;

        public char Char
        {
            get { return _char; }
            set { this.RaiseAndSetIfChanged(ref _char, value); }
        }
        public EscapeSequence EscapeSequence
        {
            get { return _escapeSequence; }
            set { this.RaiseAndSetIfChanged(ref _escapeSequence, value); }
        }

        public SChar()
        {
            this.Char = GrammarCConstants.Letter_a;
            this.EscapeSequence = new EscapeSequence();
        }
    }
}
