using SimpleC.Grammar.PhraseStructureGrammar.Declarations;
using SimpleC.Grammar.PhraseStructureGrammar.Statements;

namespace SimpleC.Grammar.PhraseStructureGrammar.ExternalDefinitions
{
    public class FunctionDefinition : GrammarBase
    {
        DeclarationSpecifiers _declarationSpecifiers1;
        Declarator _declarator1;
        DeclarationList? _declarationList1;
        CompoundStatement _compoundStatement1;

        public DeclarationSpecifiers DeclarationSpecifiers1
        {
            get { return _declarationSpecifiers1; }
            set { this.RaiseAndSetIfChanged(ref _declarationSpecifiers1, value); }
        }
        public Declarator Declarator1
        {
            get { return _declarator1; }
            set { this.RaiseAndSetIfChanged(ref _declarator1, value); }
        }
        public DeclarationList? DeclarationList1
        {
            get { return _declarationList1; }
            set { this.RaiseAndSetIfChanged(ref _declarationList1, value); }
        }
        public CompoundStatement CompoundStatement1
        {
            get { return _compoundStatement1; }
            set { this.RaiseAndSetIfChanged(ref _compoundStatement1, value); }
        }

        public FunctionDefinition()
        {
            this.CompoundStatement1 = new CompoundStatement();
            this.DeclarationList1 = null;
            this.Declarator1 = new Declarator();
            this.DeclarationSpecifiers1 = new DeclarationSpecifiers();
        }
    }
}
