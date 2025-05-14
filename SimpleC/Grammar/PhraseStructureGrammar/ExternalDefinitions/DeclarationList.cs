using SimpleC.Grammar.PhraseStructureGrammar.Declarations;

namespace SimpleC.Grammar.PhraseStructureGrammar.ExternalDefinitions
{
    public class DeclarationList : GrammarBase
    {
        Declaration _declaration1;

        DeclarationList _declarationList2;
        Declaration _declaration2;

        public Declaration Declaration1
        {
            get { return _declaration1; }
            set { this.RaiseAndSetIfChanged(ref _declaration1, value); }
        }
        public DeclarationList DeclarationList2
        {
            get { return _declarationList2; }
            set { this.RaiseAndSetIfChanged(ref _declarationList2, value); }
        }
        public Declaration Declaration2
        {
            get { return _declaration2; }
            set { this.RaiseAndSetIfChanged(ref _declaration2, value); }
        }

        public DeclarationList()
        {
            this.Declaration1 = new Declaration();
            this.Declaration2 = new Declaration();
            this.DeclarationList2 = new DeclarationList();
        }
    }
}
