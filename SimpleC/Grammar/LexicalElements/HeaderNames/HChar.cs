namespace SimpleC.Grammar.LexicalElements.HeaderNames
{
    public class HChar : GrammarBase
    {
        // "Any member of the source character set except the new-line character and >"   (see A.1.8 -> 6.4.7)
        char _character;

        public char Character
        {
            get { return _character; }
            set { this.RaiseAndSetIfChanged(ref _character, value); }
        }

        public HChar()
        {
            this.Character = GrammarCConstants.Letter_a;
        }
    }
}
