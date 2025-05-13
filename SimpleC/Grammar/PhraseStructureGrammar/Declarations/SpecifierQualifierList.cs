namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    public class SpecifierQualifierList : GrammarBase
    {
        TypeSpecifier _typeSpecifier1;
        SpecifierQualifierList? _specifierQualifierList1;

        TypeQualifier _typeQualifier2;
        SpecifierQualifierList? _specifierQualifierList2;

        public TypeSpecifier TypeSpecifier1
        {
            get { return _typeSpecifier1; }
            set { this.RaiseAndSetIfChanged(ref _typeSpecifier1, value); }
        }
        public SpecifierQualifierList? SpecifierQualifierList1
        {
            get { return _specifierQualifierList1; }
            set { this.RaiseAndSetIfChanged(ref _specifierQualifierList1, value); }
        }
        public TypeQualifier TypeQualifier2
        {
            get { return _typeQualifier2; }
            set { this.RaiseAndSetIfChanged(ref _typeQualifier2, value); }
        }
        public SpecifierQualifierList? SpecifierQualifierList2
        {
            get { return _specifierQualifierList2; }
            set { this.RaiseAndSetIfChanged(ref _specifierQualifierList2, value); }
        }

        public SpecifierQualifierList()
        {
            this.SpecifierQualifierList1 = null;
            this.SpecifierQualifierList2 = null;
            this.TypeSpecifier1 = new TypeSpecifier();
            this.TypeQualifier2 = new TypeQualifier();
        }
    }
}
