namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    public class DeclarationSpecifiers : GrammarBase
    {
        StorageClassSpecifier _storageClassSpecifier1;
        DeclarationSpecifiers? _declarationSpecifiers1;

        TypeSpecifier _typeSpecifier2;
        DeclarationSpecifiers? _declarationSpecifiers2;

        TypeQualifier _typeQualifier3;
        DeclarationSpecifiers? _declarationSpecifiers3;

        FunctionSpecifier _functionSpecifier4;
        DeclarationSpecifiers? _declarationSpecifiers4;

        public StorageClassSpecifier StorageClassSpecifier1
        {
            get { return _storageClassSpecifier1; }
            set { this.RaiseAndSetIfChanged(ref _storageClassSpecifier1, value); }
        }
        public DeclarationSpecifiers? DeclarationSpecifiers1
        {
            get { return _declarationSpecifiers1; }
            set { this.RaiseAndSetIfChanged(ref _declarationSpecifiers1, value); }
        }
        public TypeSpecifier TypeSpecifier2
        {
            get { return _typeSpecifier2; }
            set { this.RaiseAndSetIfChanged(ref _typeSpecifier2, value); }
        }
        public DeclarationSpecifiers? DeclarationSpecifiers2
        {
            get { return _declarationSpecifiers2; }
            set { this.RaiseAndSetIfChanged(ref _declarationSpecifiers2, value); }
        }
        public TypeQualifier TypeQualifier3
        {
            get { return _typeQualifier3; }
            set { this.RaiseAndSetIfChanged(ref _typeQualifier3, value); }
        }
        public DeclarationSpecifiers? DeclarationSpecifiers3
        {
            get { return _declarationSpecifiers3; }
            set { this.RaiseAndSetIfChanged(ref _declarationSpecifiers3, value); }
        }
        public FunctionSpecifier FunctionSpecifier4
        {
            get { return _functionSpecifier4; }
            set { this.RaiseAndSetIfChanged(ref _functionSpecifier4, value); }
        }
        public DeclarationSpecifiers? DeclarationSpecifiers4
        {
            get { return _declarationSpecifiers4; }
            set { this.RaiseAndSetIfChanged(ref _declarationSpecifiers4, value); }
        }

        public DeclarationSpecifiers()
        {
            this.DeclarationSpecifiers1 = null;
            this.DeclarationSpecifiers2 = null;
            this.DeclarationSpecifiers3 = null;
            this.DeclarationSpecifiers4 = null;

            this.FunctionSpecifier4 = new FunctionSpecifier();
            this.TypeSpecifier2 = new TypeSpecifier();
            this.TypeQualifier3 = new TypeQualifier();
            this.StorageClassSpecifier1 = new StorageClassSpecifier();
        }
    }
}
