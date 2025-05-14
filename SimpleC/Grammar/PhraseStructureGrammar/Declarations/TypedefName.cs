using SimpleC.Grammar.LexicalElements.Identifiers;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    public class TypedefName : GrammarBase
    {
        Identifier _identifier;

        public Identifier Identifier
        {
            get { return _identifier; }
            set { this.RaiseAndSetIfChanged(ref _identifier, value); }
        }

        public TypedefName()
        {
            this.Identifier = new Identifier();
        }
    }
}
