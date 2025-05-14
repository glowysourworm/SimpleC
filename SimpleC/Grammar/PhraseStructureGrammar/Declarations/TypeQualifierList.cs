namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    public class TypeQualifierList : GrammarBase
    {
        TypeQualifier _typeQualifier1;

        TypeQualifierList _typeQualifierList2;
        TypeQualifier _typeQualifier2;

        public TypeQualifier TypeQualifier1
        {
            get { return _typeQualifier1; }
            set { this.RaiseAndSetIfChanged(ref _typeQualifier1, value); }
        }
        public TypeQualifierList TypeQualifierList2
        {
            get { return _typeQualifierList2; }
            set { this.RaiseAndSetIfChanged(ref _typeQualifierList2, value); }
        }
        public TypeQualifier TypeQualifier2
        {
            get { return _typeQualifier2; }
            set { this.RaiseAndSetIfChanged(ref _typeQualifier2, value); }
        }

        public TypeQualifierList()
        {
            this.TypeQualifier1 = new TypeQualifier();
            this.TypeQualifier2 = new TypeQualifier();
            this.TypeQualifierList2 = new TypeQualifierList();
        }
    }
}
