namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    public class StructDeclaration : GrammarBase
    {
        SpecifierQualifierList _specifierQualifierList1;
        StructDeclaratorList _structDeclaratorList1;
        public const char SemicolonSeparator = GrammarCConstants.Semicolon;

        public SpecifierQualifierList SpecifierQualifierList1
        {
            get { return _specifierQualifierList1; }
            set { this.RaiseAndSetIfChanged(ref _specifierQualifierList1, value); }
        }
        public StructDeclaratorList StructDeclaratorList1
        {
            get { return _structDeclaratorList1; }
            set { this.RaiseAndSetIfChanged(ref _structDeclaratorList1, value); }
        }

        public StructDeclaration()
        {
            this.StructDeclaratorList1 = new StructDeclaratorList();
            this.SpecifierQualifierList1 = new SpecifierQualifierList();
        }
    }
}
