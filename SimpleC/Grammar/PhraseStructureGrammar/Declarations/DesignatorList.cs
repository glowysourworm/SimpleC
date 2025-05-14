namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    public class DesignatorList : GrammarBase
    {
        Designator _designator1;
        DesignatorList _designatorList2;
        Designator _designator2;

        public Designator Designator1
        {
            get { return _designator1; }
            set { this.RaiseAndSetIfChanged(ref _designator1, value); }
        }
        public DesignatorList DesignatorList2
        {
            get { return _designatorList2; }
            set { this.RaiseAndSetIfChanged(ref _designatorList2, value); }
        }
        public Designator Designator2
        {
            get { return _designator2; }
            set { this.RaiseAndSetIfChanged(ref _designator2, value); }
        }

        public DesignatorList()
        {
            this.DesignatorList2 = new DesignatorList();
            this.Designator1 = new Designator();
            this.Designator2 = new Designator();
        }
    }
}
