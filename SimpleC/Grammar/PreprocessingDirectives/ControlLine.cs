using SimpleC.Grammar.LexicalElements.Identifiers;
using SimpleC.Grammar.PhraseStructureGrammar.Declarations;

namespace SimpleC.Grammar.PreprocessingDirectives
{
    public class ControlLine : GrammarBase
    {
        public const char IncludeHashtag1 = GrammarCConstants.Hashtag;
        public const string IncludeKeyword1 = GrammarCKeywords.Keyword_include;
        PreprocessingTokens _preprocessingTokens1;
        NewLine _newLine1;

        public const char DefineHashtag2 = GrammarCConstants.Hashtag;
        public const string DefineKeyword2 = GrammarCKeywords.Keyword_define;
        Identifier _identifier2;
        ReplacementList _replacementList2;
        NewLine _newLine2;

        public const char DefineHashtag3 = GrammarCConstants.Hashtag;
        public const string DefineKeyword3 = GrammarCKeywords.Keyword_define;
        Identifier _identifier3;
        LParen _lparen3;
        IdentifierList? _identifierList3;
        public const char IdentifierListCloseBracket3 = GrammarCConstants.BracketRight;
        ReplacementList _replacementList3;
        NewLine _newLine3;

        public const char DefineHashtag4 = GrammarCConstants.Hashtag;
        public const string DefineKeyword4 = GrammarCKeywords.Keyword_define;
        Identifier _identifier4;
        LParen _lparen4;
        public const string VariadicParameters4 = GrammarCOperators.VariadicParameterPack;
        public const char ParametersCloseBracket4 = GrammarCConstants.BracketRight;
        ReplacementList _replacementList4;
        NewLine _newLine4;

        public const char DefineHashtag5 = GrammarCConstants.Hashtag;
        public const string DefineKeyword5 = GrammarCKeywords.Keyword_define;
        Identifier _identifier5;
        LParen _lparen5;
        IdentifierList _identifierList5;
        public const char CommaSeparator5 = GrammarCConstants.Comma;
        public const string VariadicParameters5 = GrammarCOperators.VariadicParameterPack;
        public const char ParametersCloseBracket5 = GrammarCConstants.BracketRight;
        ReplacementList _replacementList5;
        NewLine _newLine5;

        public const char UndefHashtag6 = GrammarCConstants.Hashtag;
        public const string UndefKeyword6 = GrammarCKeywords.Keyword_undef;
        Identifier _identifier6;
        NewLine _newLine6;

        public const char LineHashtag7 = GrammarCConstants.Hashtag;
        public const string LineKeyword7 = GrammarCKeywords.Keyword_line;
        PreprocessingTokens _preprocessingTokens7;
        NewLine _newLine7;

        public const char ErrorHashtag8 = GrammarCConstants.Hashtag;
        public const string ErrorKeyword8 = GrammarCKeywords.Keyword_error;
        PreprocessingTokens? _preprocessingTokens8;
        NewLine _newLine8;

        public const char PragmaHashtag9 = GrammarCConstants.Hashtag;
        public const string PragmaKeyword9 = GrammarCKeywords.Keyword_pragma;
        PreprocessingTokens? _preprocessingTokens9;
        NewLine _newLine9;

        public const char NewlineHashtag10 = GrammarCConstants.Hashtag;
        NewLine _newLine10;

        public PreprocessingTokens PreprocessingTokens1
        {
            get { return _preprocessingTokens1; }
            set { this.RaiseAndSetIfChanged(ref _preprocessingTokens1, value); }
        }
        public NewLine NewLine1
        {
            get { return _newLine1; }
            set { this.RaiseAndSetIfChanged(ref _newLine1, value); }
        }
        public Identifier Identifier2
        {
            get { return _identifier2; }
            set { this.RaiseAndSetIfChanged(ref _identifier2, value); }
        }
        public ReplacementList ReplacementList2
        {
            get { return _replacementList2; }
            set { this.RaiseAndSetIfChanged(ref _replacementList2, value); }
        }
        public NewLine NewLine2
        {
            get { return _newLine2; }
            set { this.RaiseAndSetIfChanged(ref _newLine2, value); }
        }
        public Identifier Identifier3
        {
            get { return _identifier3; }
            set { this.RaiseAndSetIfChanged(ref _identifier3, value); }
        }
        public LParen Lparen3
        {
            get { return _lparen3; }
            set { this.RaiseAndSetIfChanged(ref _lparen3, value); }
        }
        public IdentifierList? IdentifierList3
        {
            get { return _identifierList3; }
            set { this.RaiseAndSetIfChanged(ref _identifierList3, value); }
        }
        public ReplacementList ReplacementList3
        {
            get { return _replacementList3; }
            set { this.RaiseAndSetIfChanged(ref _replacementList3, value); }
        }
        public NewLine NewLine3
        {
            get { return _newLine3; }
            set { this.RaiseAndSetIfChanged(ref _newLine3, value); }
        }
        public Identifier Identifier4
        {
            get { return _identifier4; }
            set { this.RaiseAndSetIfChanged(ref _identifier4, value); }
        }
        public LParen Lparen4
        {
            get { return _lparen4; }
            set { this.RaiseAndSetIfChanged(ref _lparen4, value); }
        }
        public ReplacementList ReplacementList4
        {
            get { return _replacementList4; }
            set { this.RaiseAndSetIfChanged(ref _replacementList4, value); }
        }
        public NewLine NewLine4
        {
            get { return _newLine4; }
            set { this.RaiseAndSetIfChanged(ref _newLine4, value); }
        }
        public Identifier Identifier5
        {
            get { return _identifier5; }
            set { this.RaiseAndSetIfChanged(ref _identifier5, value); }
        }
        public LParen Lparen5
        {
            get { return _lparen5; }
            set { this.RaiseAndSetIfChanged(ref _lparen5, value); }
        }
        public IdentifierList IdentifierList5
        {
            get { return _identifierList5; }
            set { this.RaiseAndSetIfChanged(ref _identifierList5, value); }
        }
        public ReplacementList ReplacementList5
        {
            get { return _replacementList5; }
            set { this.RaiseAndSetIfChanged(ref _replacementList5, value); }
        }
        public NewLine NewLine5
        {
            get { return _newLine5; }
            set { this.RaiseAndSetIfChanged(ref _newLine5, value); }
        }
        public Identifier Identifier6
        {
            get { return _identifier6; }
            set { this.RaiseAndSetIfChanged(ref _identifier6, value); }
        }
        public NewLine NewLine6
        {
            get { return _newLine6; }
            set { this.RaiseAndSetIfChanged(ref _newLine6, value); }
        }
        public PreprocessingTokens PreprocessingTokens7
        {
            get { return _preprocessingTokens7; }
            set { this.RaiseAndSetIfChanged(ref _preprocessingTokens7, value); }
        }
        public NewLine NewLine7
        {
            get { return _newLine7; }
            set { this.RaiseAndSetIfChanged(ref _newLine7, value); }
        }
        public PreprocessingTokens? PreprocessingTokens8
        {
            get { return _preprocessingTokens8; }
            set { this.RaiseAndSetIfChanged(ref _preprocessingTokens8, value); }
        }
        public NewLine NewLine8
        {
            get { return _newLine8; }
            set { this.RaiseAndSetIfChanged(ref _newLine8, value); }
        }
        public PreprocessingTokens? PreprocessingTokens9
        {
            get { return _preprocessingTokens9; }
            set { this.RaiseAndSetIfChanged(ref _preprocessingTokens9, value); }
        }
        public NewLine NewLine9
        {
            get { return _newLine9; }
            set { this.RaiseAndSetIfChanged(ref _newLine9, value); }
        }
        public NewLine NewLine10
        {
            get { return _newLine10; }
            set { this.RaiseAndSetIfChanged(ref _newLine10, value); }
        }

        public ControlLine()
        {
            this.Identifier2 = new Identifier();
            this.Identifier3 = new Identifier();
            this.Identifier4 = new Identifier();
            this.Identifier5 = new Identifier();
            this.Identifier6 = new Identifier();
            this.IdentifierList3 = new IdentifierList();
            this.IdentifierList5 = new IdentifierList();
            this.Lparen3 = new LParen();
            this.Lparen4 = new LParen();
            this.Lparen5 = new LParen();
            this.NewLine1 = new NewLine();
            this.NewLine10 = new NewLine();
            this.NewLine2 = new NewLine();
            this.NewLine3 = new NewLine();
            this.NewLine4 = new NewLine();
            this.NewLine5 = new NewLine();
            this.NewLine6 = new NewLine();
            this.NewLine7 = new NewLine();
            this.NewLine8 = new NewLine();
            this.NewLine9 = new NewLine();
            this.PreprocessingTokens1 = new PreprocessingTokens();
            this.PreprocessingTokens7 = new PreprocessingTokens();
            this.PreprocessingTokens8 = new PreprocessingTokens();
            this.PreprocessingTokens9 = new PreprocessingTokens();
            this.ReplacementList2 = new ReplacementList();
            this.ReplacementList3 = new ReplacementList();
            this.ReplacementList4 = new ReplacementList();
            this.ReplacementList5 = new ReplacementList();
        }
    }
}
