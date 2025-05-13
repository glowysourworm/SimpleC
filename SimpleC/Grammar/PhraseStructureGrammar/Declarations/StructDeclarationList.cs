namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    public class StructDeclarationList : GrammarBase
    {
        StructDeclaration _structDeclaration1;

        StructDeclarationList _structDeclarationList2;
        StructDeclaration _structDeclaration2;

        public StructDeclaration StructDeclaration1
        {
            get { return _structDeclaration1; }
            set { this.RaiseAndSetIfChanged(ref _structDeclaration1, value); }
        }
        public StructDeclarationList StructDeclarationList2
        {
            get { return _structDeclarationList2; }
            set { this.RaiseAndSetIfChanged(ref _structDeclarationList2, value); }
        }
        public StructDeclaration StructDeclaration2
        {
            get { return _structDeclaration2; }
            set { this.RaiseAndSetIfChanged(ref _structDeclaration2, value); }
        }

        public StructDeclarationList()
        {
            this.StructDeclarationList2 = new StructDeclarationList();
            this.StructDeclaration1 = new StructDeclaration();
            this.StructDeclaration2 = new StructDeclaration();  
        }
    }
}
