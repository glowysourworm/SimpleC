namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    public class EnumeratorList : GrammarBase
    {
        Enumerator _enumerator1;

        EnumeratorList _enumeratorList2;
        public const char CommaSeparator2 = GrammarCConstants.Comma;
        Enumerator _enumerator2;

        public Enumerator Enumerator1
        {
            get { return _enumerator1; }
            set { this.RaiseAndSetIfChanged(ref _enumerator1, value); }
        }
        public EnumeratorList EnumeratorList2
        {
            get { return _enumeratorList2; }
            set { this.RaiseAndSetIfChanged(ref _enumeratorList2, value); }
        }
        public Enumerator Enumerator2
        {
            get { return _enumerator2; }
            set { this.RaiseAndSetIfChanged(ref _enumerator2, value); }
        }

        public EnumeratorList()
        {
            this.Enumerator1 = new Enumerator();
            this.Enumerator2 = new Enumerator();
            this.EnumeratorList2 = new EnumeratorList();
        }
    }
}
