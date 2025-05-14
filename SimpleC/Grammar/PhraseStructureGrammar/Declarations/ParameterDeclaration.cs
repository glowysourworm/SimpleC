namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    public class ParameterDeclaration : GrammarBase
    {
        DeclarationSpecifiers _declarationSpecifiers1;
        Declarator _declarator1;

        DeclarationSpecifiers _declarationSpecifiers2;
        AbstractDeclarator? _abstractDeclarator;

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
        public DeclarationSpecifiers DeclarationSpecifiers2
        {
            get { return _declarationSpecifiers2; }
            set { this.RaiseAndSetIfChanged(ref _declarationSpecifiers2, value); }
        }
        public AbstractDeclarator? AbstractDeclarator
        {
            get { return _abstractDeclarator; }
            set { this.RaiseAndSetIfChanged(ref _abstractDeclarator, value); }
        }

        public ParameterDeclaration()
        {
            this.AbstractDeclarator = null;
            this.Declarator1 = new Declarator();
            this.DeclarationSpecifiers1 = new DeclarationSpecifiers();
            this.DeclarationSpecifiers2 = new DeclarationSpecifiers();
        }
    }
}
