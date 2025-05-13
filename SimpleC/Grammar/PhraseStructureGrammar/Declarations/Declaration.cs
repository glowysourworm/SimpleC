namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    public class Declaration : GrammarBase
    {
        DeclarationSpecifiers _declarationSpecifiers1;
        InitDeclaratorList? _initDeclaratorList1;
        public const char SeparatorSemicolon = GrammarCConstants.Semicolon;

        public DeclarationSpecifiers DeclarationSpecifiers1
        {
            get { return _declarationSpecifiers1; }
            set { this.RaiseAndSetIfChanged(ref _declarationSpecifiers1, value); }
        }
        public InitDeclaratorList? InitDeclaratorList1
        {
            get { return _initDeclaratorList1; }
            set { this.RaiseAndSetIfChanged(ref _initDeclaratorList1, value); }
        }

        public Declaration()
        {
            this.DeclarationSpecifiers1 = new DeclarationSpecifiers();
            this.InitDeclaratorList1 = null;
        }
    }
}
