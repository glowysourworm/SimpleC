using SimpleC.Grammar.LexicalElements.Identifiers;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    public class InitializerList : GrammarBase
    {
        Designation? _designation1;
        Initializer _initializer1;

        InitializerList _initializerList2;
        public const char CommaSeparator2 = GrammarCConstants.Comma;
        Designation? _designation2;
        Initializer _initializer2;

        public Designation? Designation1
        {
            get { return _designation1; }
            set { this.RaiseAndSetIfChanged(ref _designation1, value); }
        }
        public Initializer Initializer1
        {
            get { return _initializer1; }
            set { this.RaiseAndSetIfChanged(ref _initializer1, value); }
        }
        public InitializerList InitializerList2
        {
            get { return _initializerList2; }
            set { this.RaiseAndSetIfChanged(ref _initializerList2, value); }
        }
        public Designation? Designation2
        {
            get { return _designation2; }
            set { this.RaiseAndSetIfChanged(ref _designation2, value); }
        }
        public Initializer Initializer2
        {
            get { return _initializer2; }
            set { this.RaiseAndSetIfChanged(ref _initializer2, value); }
        }


        public InitializerList()
        {
            this.Initializer1 = new Initializer();
            this.InitializerList2 = new InitializerList();
            this.Initializer2 = new Initializer();
            this.Designation1 = null;
            this.Designation2 = null;
        }
    }
}
