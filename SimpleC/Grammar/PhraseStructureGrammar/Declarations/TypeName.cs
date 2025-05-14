namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    public class TypeName : GrammarBase
    {
        SpecifierQualifierList _specifierQualifierList1;
        AbstractDeclarator? _abstractDeclarator1;

        public SpecifierQualifierList SpecifierQualifierList1
        {
            get { return _specifierQualifierList1; }
            set { this.RaiseAndSetIfChanged(ref _specifierQualifierList1, value); }
        }
        public AbstractDeclarator? AbstractDeclarator1
        {
            get { return _abstractDeclarator1; }
            set { this.RaiseAndSetIfChanged(ref _abstractDeclarator1, value); }
        }

        public TypeName()
        {
            this.SpecifierQualifierList1 = new SpecifierQualifierList();
            this.AbstractDeclarator1 = null;
        }
    }
}
