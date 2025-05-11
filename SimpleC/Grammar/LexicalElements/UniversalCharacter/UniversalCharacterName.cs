namespace SimpleC.Grammar.LexicalElements.UniversalCharacter
{
    /// <summary>
    /// (see A.1.4 -> 6.4.3) universal-character-name:
    /// </summary>
    public class UniversalCharacterName : GrammarBase
    {
        HexQuad _hexQuad1;
        HexQuad _hexQuad2;

        public HexQuad HexQuad1
        {
            get { return _hexQuad1; }
            set { RaiseAndSetIfChanged(ref _hexQuad1, value); }
        }
        public HexQuad HexQuad2
        {
            get { return _hexQuad2; }
            set { RaiseAndSetIfChanged(ref _hexQuad2, value); }
        }

        public UniversalCharacterName()
        {
            this.HexQuad1 = new HexQuad();
            this.HexQuad2 = new HexQuad();
        }
    }
}
