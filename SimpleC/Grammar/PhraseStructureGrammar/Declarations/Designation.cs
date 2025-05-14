namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    public class Designation : GrammarBase
    {
        DesignatorList _designatorList1;
        public const string AssignmentOperator1 = GrammarCOperators.Assignment;

        public DesignatorList DesignatorList1
        {
            get { return _designatorList1; }
            set { this.RaiseAndSetIfChanged(ref _designatorList1, value); }
        }

        public Designation()
        {
            this.DesignatorList1 = new DesignatorList();
        }
    }
}
