namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    public class Pointer : GrammarBase
    {
        public const char PointerPrefix1 = GrammarCConstants.Asterix;
        TypeQualifierList? _typeQualifierList1;

        public const char PointerPrefix2 = GrammarCConstants.Asterix;
        TypeQualifierList? _typeQualifierList2;
        Pointer _pointer2;

        public TypeQualifierList? TypeQualifierList1
        {
            get { return _typeQualifierList1; }
            set { this.RaiseAndSetIfChanged(ref _typeQualifierList1, value); }
        }
        public TypeQualifierList? TypeQualifierList2
        {
            get { return _typeQualifierList2; }
            set { this.RaiseAndSetIfChanged(ref _typeQualifierList2, value); }
        }
        public Pointer Pointer2
        {
            get { return _pointer2; }
            set { this.RaiseAndSetIfChanged(ref _pointer2, value); }
        }

        public Pointer()
        {
            this.TypeQualifierList1 = null;
            this.TypeQualifierList2 = null;
            this.Pointer2 = new Pointer();
        }
    }
}
