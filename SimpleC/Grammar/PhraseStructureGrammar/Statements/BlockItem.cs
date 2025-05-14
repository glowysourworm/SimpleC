using SimpleC.Grammar.PhraseStructureGrammar.Declarations;

namespace SimpleC.Grammar.PhraseStructureGrammar.Statements
{
    public class BlockItem : GrammarBase
    {
        Declaration _declaration1;
        Statement _statement2;

        public Declaration Declaration1
        {
            get { return _declaration1; }
            set { this.RaiseAndSetIfChanged(ref _declaration1, value); }
        }
        public Statement Statement2
        {
            get { return _statement2; }
            set { this.RaiseAndSetIfChanged(ref _statement2, value); }
        }

        public BlockItem()
        {
            this.Declaration1 = new Declaration();
            this.Statement2 = new Statement();
        }
    }
}
