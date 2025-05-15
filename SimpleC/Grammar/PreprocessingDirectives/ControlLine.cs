using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.LexicalElements.Identifiers;
using SimpleC.Grammar.PhraseStructureGrammar.Declarations;

namespace SimpleC.Grammar.PreprocessingDirectives
{
    [Grammar(Name = "control-line (base)",
             Description = "control-line: (10 variants)",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public abstract class ControlLine : GrammarBase
    {
        protected ControlLine(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "control-line (variant 1)",
             Description = "control-line: # include pp-tokens new-line",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public class ControlLine_V1 : ControlLine
    {
        public const char HashtagPrefix = GrammarCConstants.Hashtag;
        public const string IncludeKeyword = GrammarCKeywords.Keyword_include;
        PreprocessingTokens PreprocessingTokens;
        NewLine NewLine;

        public ControlLine_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "control-line (variant 2)",
             Description = "control-line: # define identifier replacement-list new-line",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public class ControlLine_V2 : ControlLine
    {
        public const char HashtagPrefix = GrammarCConstants.Hashtag;
        public const string DefineKeyword = GrammarCKeywords.Keyword_define;
        Identifier Identifier;
        ReplacementList ReplacementList;
        NewLine NewLine;

        public ControlLine_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }


    [Grammar(Name = "control-line (variant 3)",
             Description = "control-line: # define identifier lparen identifier-list_opt ) replacement-list new-line",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public class ControlLine_V3 : ControlLine
    {
        public const char HashtagPrefix = GrammarCConstants.Hashtag;
        public const string DefineKeyword = GrammarCKeywords.Keyword_define;
        Identifier Identifier;
        LParen Lparen;
        IdentifierList? IdentifierList;
        public const char IdentifierListCloseBracket = GrammarCConstants.BracketRight;
        ReplacementList ReplacementList;
        NewLine NewLine;

        public ControlLine_V3(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "control-line (variant 4)",
             Description = "control-line: # define identifier lparen ... ) replacement-list new-line",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public class ControlLine_V4 : ControlLine
    {
        public const char HashtagKeyword = GrammarCConstants.Hashtag;
        public const string DefineKeyword = GrammarCKeywords.Keyword_define;
        Identifier Identifier;
        LParen Lparen;
        public const string VariadicParameters = GrammarCOperators.VariadicParameterPack;
        public const char ParametersCloseBracket = GrammarCConstants.BracketRight;
        ReplacementList ReplacementList;
        NewLine NewLine;

        public ControlLine_V4(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "control-line (variant 5)",
             Description = "control-line: # define identifier lparen identifier-list , ... ) replacement-list new-line",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public class ControlLine_V5 : ControlLine
    {
        public const char HashtagPrefix = GrammarCConstants.Hashtag;
        public const string DefineKeyword = GrammarCKeywords.Keyword_define;
        Identifier Identifier;
        LParen LParen;
        IdentifierList IdentifierList;
        public const char CommaSeparator = GrammarCConstants.Comma;
        public const string VariadicParameters = GrammarCOperators.VariadicParameterPack;
        public const char ParametersCloseBracket = GrammarCConstants.BracketRight;
        ReplacementList ReplacementList;
        NewLine NewLine;

        public ControlLine_V5(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "control-line (variant 6)",
             Description = "control-line: # undef identifier new-line",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public class ControlLine_V6 : ControlLine
    {
        public const char HashtagPrefix = GrammarCConstants.Hashtag;
        public const string UndefKeyword = GrammarCKeywords.Keyword_undef;
        Identifier Identifier;
        NewLine NewLine;

        public ControlLine_V6(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "control-line (variant 7)",
             Description = "control-line: # line pp-tokens new-line",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public class ControlLine_V7 : ControlLine
    {
        public const char HashtagPrefix = GrammarCConstants.Hashtag;
        public const string LineKeyword = GrammarCKeywords.Keyword_line;
        PreprocessingTokens PreprocessingTokens;
        NewLine NewLine;

        public ControlLine_V7(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "control-line (variant 8)",
             Description = "control-line: # error pp-tokens_opt new-line",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public class ControlLine_V8 : ControlLine
    {
        public const char HashtagPrefix = GrammarCConstants.Hashtag;
        public const string ErrorKeyword = GrammarCKeywords.Keyword_error;
        PreprocessingTokens? PreprocessingTokens;
        NewLine NewLine;

        public ControlLine_V8(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "control-line (variant 9)",
             Description = "control-line: # pragma pp-tokens_opt new-line",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public class ControlLine_V9 : ControlLine
    {
        public const char HashtagPrefix = GrammarCConstants.Hashtag;
        public const string PragmaKeyword = GrammarCKeywords.Keyword_pragma;
        PreprocessingTokens? PreprocessingTokens;
        NewLine NewLine;

        public ControlLine_V9(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "control-line (variant 10)",
             Description = "control-line: # new-line",
             Section = ISOCStandardAnnexSection.A_3,
             SubSection = ISOCStandardAnnexSubSection.None,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_10)]
    public class ControlLine_V10 : ControlLine
    {
        public const char HashtagPrefix = GrammarCConstants.Hashtag;
        NewLine NewLine;

        public ControlLine_V10(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
