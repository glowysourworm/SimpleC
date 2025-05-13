namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    public class InitDeclarator : GrammarBase
    {
        Declarator _declarator1;

        Declarator _declarator2;
        public const string AssignmentOperator = GrammarCOperators.Assignment;
        Initializer _initializer2;

        public Declarator Declarator1
        {
            get { return _declarator1; }
            set { this.RaiseAndSetIfChanged(ref _declarator1, value); }
        }
        public Declarator Declarator2
        {
            get { return _declarator2; }
            set { this.RaiseAndSetIfChanged(ref _declarator2, value); }
        }
        public Initializer Initializer2
        {
            get { return _initializer2; }
            set { this.RaiseAndSetIfChanged(ref _initializer2, value); }
        }

        public InitDeclarator()
        {
            this.Initializer2 = new Initializer();
            this.Declarator1 = new Declarator();
            this.Declarator2 = new Declarator();
        }
    }
}
