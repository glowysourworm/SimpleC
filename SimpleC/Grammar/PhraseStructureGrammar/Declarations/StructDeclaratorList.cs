namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    public class StructDeclaratorList : GrammarBase
    {
        StructDeclarator _structDeclarator1;

        StructDeclaratorList _structDeclaratorList2;
        public const char CommaSeparator = GrammarCConstants.Comma;
        StructDeclarator _structDeclarator2;

        public StructDeclarator StructDeclarator1
        {
            get { return _structDeclarator1; }
            set { this.RaiseAndSetIfChanged(ref _structDeclarator1, value); }
        }
        public StructDeclaratorList StructDeclaratorList2
        {
            get { return _structDeclaratorList2; }
            set { this.RaiseAndSetIfChanged(ref _structDeclaratorList2, value); }
        }
        public StructDeclarator StructDeclarator2
        {
            get { return _structDeclarator2; }
            set { this.RaiseAndSetIfChanged(ref _structDeclarator2, value); }
        }

        public StructDeclaratorList()
        {
            this.StructDeclaratorList2 = new StructDeclaratorList();
            this.StructDeclarator1 = new StructDeclarator();
            this.StructDeclarator2 = new StructDeclarator();
        }
    }
}
