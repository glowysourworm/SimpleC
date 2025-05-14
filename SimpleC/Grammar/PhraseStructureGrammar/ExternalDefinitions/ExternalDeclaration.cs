using SimpleC.Grammar.PhraseStructureGrammar.Declarations;

namespace SimpleC.Grammar.PhraseStructureGrammar.ExternalDefinitions
{
    public class ExternalDeclaration : GrammarBase
    {
        FunctionDefinition _functionDefinition1;

        Declaration _declaration2;

        public FunctionDefinition FunctionDefinition1
        {
            get { return _functionDefinition1; }
            set { this.RaiseAndSetIfChanged(ref _functionDefinition1, value); }
        }
        public Declaration Declaration2
        {
            get { return _declaration2; }
            set { this.RaiseAndSetIfChanged(ref _declaration2, value); }
        }

        public ExternalDeclaration()
        {
            this.FunctionDefinition1 = new FunctionDefinition();
            this.Declaration2 = new Declaration();
        }
    }
}
