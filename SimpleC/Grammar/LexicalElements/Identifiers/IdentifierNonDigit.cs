using SimpleC.Grammar.LexicalElements.UniversalCharacter;

namespace SimpleC.Grammar.LexicalElements.Identifiers
{
    /// <summary>
    /// (See A.1.3 -> 6.4.2.1) identifier-nondigit:
    /// </summary>
    public class IdentifierNonDigit : GrammarBase
    {
        NonDigit _nonDigit;
        UniversalCharacterName _universalCharacterName;

        // TODO: "Other implementation defined non-characters" (What's a non-digit (?))

        public NonDigit NonDigit
        {
            get { return _nonDigit; }
            set { RaiseAndSetIfChanged(ref _nonDigit, value); }
        }
        public UniversalCharacterName UniversalCharacterName
        {
            get { return _universalCharacterName; }
            set { RaiseAndSetIfChanged(ref _universalCharacterName, value); }
        }

        public IdentifierNonDigit()
        {
            this.NonDigit = new NonDigit();
            this.UniversalCharacterName = new UniversalCharacterName();
        }
    }
}
