using SimpleC.Grammar.LexicalElements.Identifiers;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    public class StructOrUnionSpecifier : GrammarBase
    {
        StructOrUnion _structOrUnion1;
        Identifier? _identifier1;
        public const char StructDeclarationListBracketCurlyLeft1 = GrammarCConstants.BracketCurlyLeft;
        StructDeclaration _structDeclarationList1;
        public const char StructDeclarationListBracketCurlyRight1 = GrammarCConstants.BracketCurlyRight;

        StructOrUnion _structOrUnion2;
        Identifier _identifier2;

        public StructOrUnion StructOrUnion1
        {
            get { return _structOrUnion1; }
            set { this.RaiseAndSetIfChanged(ref _structOrUnion1, value); }
        }
        public Identifier? Identifier1
        {
            get { return _identifier1; }
            set { this.RaiseAndSetIfChanged(ref _identifier1, value); }
        }
        public StructDeclaration StructDeclarationList1
        {
            get { return _structDeclarationList1; }
            set { this.RaiseAndSetIfChanged(ref _structDeclarationList1, value); }
        }
        public StructOrUnion StructOrUnion2
        {
            get { return _structOrUnion2; }
            set { this.RaiseAndSetIfChanged(ref _structOrUnion2, value); }
        }
        public Identifier Identifier2
        {
            get { return _identifier2; }
            set { this.RaiseAndSetIfChanged(ref _identifier2, value); }
        }

        public StructOrUnionSpecifier()
        {
            this.StructOrUnion1 = new StructOrUnion();
            this.StructDeclarationList1 = new StructDeclaration();
            this.Identifier1 = new Identifier();
            this.Identifier2 = new Identifier();
            this.StructOrUnion2 = new StructOrUnion();
        }
    }
}
