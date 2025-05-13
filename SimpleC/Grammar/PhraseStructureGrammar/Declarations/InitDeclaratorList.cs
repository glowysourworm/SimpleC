namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    public class InitDeclaratorList : GrammarBase
    {
        InitDeclarator _initDeclarator1;

        InitDeclaratorList _initDeclaratorList2;
        public const char CommaSeparator = GrammarCConstants.Comma;
        InitDeclarator _initDeclarator2;

        public InitDeclarator InitDeclarator1
        {
            get { return _initDeclarator1; }
            set { this.RaiseAndSetIfChanged(ref _initDeclarator1, value); }
        }
        public InitDeclaratorList InitDeclaratorList2
        {
            get { return _initDeclaratorList2; }
            set { this.RaiseAndSetIfChanged(ref _initDeclaratorList2, value); }
        }
        public InitDeclarator InitDeclarator2
        {
            get { return _initDeclarator2; }
            set { this.RaiseAndSetIfChanged(ref _initDeclarator2, value); }
        }

        public InitDeclaratorList()
        {
            this.InitDeclaratorList2 = new InitDeclaratorList();
            this.InitDeclarator1 = new InitDeclarator();
            this.InitDeclarator2 = new InitDeclarator();
        }
    }
}
