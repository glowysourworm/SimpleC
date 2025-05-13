using SimpleC.Grammar.LexicalElements;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    /// <summary>
    /// (see A.2.2 -> 6.7.2) type-specifier:
    /// </summary>
    public class TypeSpecifier : GrammarBase
    {
        Keyword _keyword1;

        StructOrUnionSpecifier _structOrUnionSpecifier2;

        EnumSpecifier _enumSpecifier3;

        TypedefName _typedefName4;

        public Keyword Keyword1
        {
            get { return _keyword1; }
            set { this.RaiseAndSetIfChanged(ref _keyword1, value); }
        }
        public StructOrUnionSpecifier StructOrUnionSpecifier2
        {
            get { return _structOrUnionSpecifier2; }
            set { this.RaiseAndSetIfChanged(ref _structOrUnionSpecifier2, value); }
        }
        public EnumSpecifier EnumSpecifier3
        {
            get { return _enumSpecifier3; }
            set { this.RaiseAndSetIfChanged(ref _enumSpecifier3, value); }
        }
        public TypedefName TypedefName4
        {
            get { return _typedefName4; }
            set { this.RaiseAndSetIfChanged(ref _typedefName4, value); }
        }

        public TypeSpecifier()
        {
            this.Keyword1 = new Keyword();
            this.EnumSpecifier3 = new EnumSpecifier();
            this.StructOrUnionSpecifier2 = new StructOrUnionSpecifier();
            this.TypedefName4 = new TypedefName();
        }
    }
}
