using SimpleC.Grammar.LexicalElements.Identifiers;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    public class EnumerationConstant : GrammarBase
    {
        Identifier _identifier;

        public Identifier Identifier
        {
            get { return _identifier; }
            set { this.RaiseAndSetIfChanged(ref _identifier, value); }
        }

        public EnumerationConstant()
        {
            this.Identifier = new Identifier();
        }
    }
}
