namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    public class ParameterTypeList : GrammarBase
    {
        ParameterList _parameterList1;

        ParameterList _parameterList2;
        public const char CommaSeparator = GrammarCConstants.Comma;
        public const string VariadicParameters = GrammarCOperators.VariadicParameterPack;

        public ParameterList ParameterList1
        {
            get { return _parameterList1; }
            set { this.RaiseAndSetIfChanged(ref _parameterList1, value); }
        }
        public ParameterList ParameterList2
        {
            get { return _parameterList2; }
            set { this.RaiseAndSetIfChanged(ref _parameterList2, value); }
        }

        public ParameterTypeList()
        {
            this.ParameterList1 = new ParameterList();
            this.ParameterList2 = new ParameterList();
        }
    }
}
