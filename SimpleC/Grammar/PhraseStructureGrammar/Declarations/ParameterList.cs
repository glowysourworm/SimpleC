namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    public class ParameterList : GrammarBase
    {
        ParameterDeclaration _parameterDeclaration1;

        ParameterList _parameterList2;
        public const char CommaSeparator2 = GrammarCConstants.Comma;
        ParameterDeclaration _parameterDeclaration2;

        public ParameterDeclaration ParameterDeclaration1
        {
            get { return _parameterDeclaration1; }
            set { this.RaiseAndSetIfChanged(ref _parameterDeclaration1, value); }
        }
        public ParameterList ParameterList2
        {
            get { return _parameterList2; }
            set { this.RaiseAndSetIfChanged(ref _parameterList2, value); }
        }
        public ParameterDeclaration ParameterDeclaration2
        {
            get { return _parameterDeclaration2; }
            set { this.RaiseAndSetIfChanged(ref _parameterDeclaration2, value); }
        }

        public ParameterList()
        {
            this.ParameterList2 = new ParameterList();
            this.ParameterDeclaration1 = new ParameterDeclaration();
            this.ParameterDeclaration2 = new ParameterDeclaration();
        }
    }
}
