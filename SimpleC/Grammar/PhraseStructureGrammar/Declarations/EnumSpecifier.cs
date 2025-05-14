using SimpleC.Grammar.LexicalElements.Identifiers;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    public class EnumSpecifier : GrammarBase
    {
        public const string EnumKeywordPrefix1 = GrammarCKeywords.Keyword_enum;
        Identifier? _identifier1;
        public const char EnumeratorListBracketCurlyLeft1 = GrammarCConstants.BracketCurlyLeft;
        EnumeratorList _enumeratorList1;
        public const char EnumeratorListBracketCurlyRight1 = GrammarCConstants.BracketCurlyRight;

        public const string EnumKeywordPrefix2 = GrammarCKeywords.Keyword_enum;
        Identifier? _identifier2;
        public const char EnumeratorListBracketCurlyLeft2 = GrammarCConstants.BracketCurlyLeft;
        EnumeratorList _enumeratorList2;
        public const char EnumeratorListBracketCurlyRight2 = GrammarCConstants.BracketCurlyRight;
        public const char EnumeratorListCommaSeparator2 = GrammarCConstants.Comma;

        public const string EnumKeywordPrefix3 = GrammarCKeywords.Keyword_enum;
        Identifier _identifier3;

        public Identifier? Identifier1
        {
            get { return _identifier1; }
            set { this.RaiseAndSetIfChanged(ref _identifier1, value); }
        }
        public EnumeratorList EnumeratorList1
        {
            get { return _enumeratorList1; }
            set { this.RaiseAndSetIfChanged(ref _enumeratorList1, value); }
        }
        public Identifier? Identifier2
        {
            get { return _identifier2; }
            set { this.RaiseAndSetIfChanged(ref _identifier2, value); }
        }
        public EnumeratorList EnumeratorList2
        {
            get { return _enumeratorList2; }
            set { this.RaiseAndSetIfChanged(ref _enumeratorList2, value); }
        }
        public Identifier Identifier3
        {
            get { return _identifier3; }
            set { this.RaiseAndSetIfChanged(ref _identifier3, value); }
        }

        public EnumSpecifier()
        {
            this.Identifier2 = null;
            this.Identifier1 = null;
            this.Identifier3 = new Identifier();
            this.EnumeratorList1 = new EnumeratorList();
            this.EnumeratorList2 = new EnumeratorList();
        }
    }
}
