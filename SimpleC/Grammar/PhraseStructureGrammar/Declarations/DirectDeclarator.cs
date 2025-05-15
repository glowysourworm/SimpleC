using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.LexicalElements.Identifiers;
using SimpleC.Grammar.PhraseStructureGrammar.Expressions;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    [Grammar(Name = "direct-declarator (base)",
             Description = "direct-declarator: (8 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_5)]
    public abstract class DirectDeclarator : GrammarBase
    {
        protected DirectDeclarator(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "direct-declarator (variant 1)",
             Description = "direct-declarator: identifier",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_5)]
    public class DirectDeclarator_V1 : DirectDeclarator
    {
        Identifier Identifier;

        public DirectDeclarator_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "direct-declarator (variant 2)",
             Description = "direct-declarator: ( declarator )",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_5)]
    public class DirectDeclarator_V2 : DirectDeclarator
    {
        public const char OpenBracket = GrammarCConstants.BracketLeft;
        Declarator Declarator;
        public const char CloseBracket = GrammarCConstants.BracketRight;

        public DirectDeclarator_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "direct-declarator (variant 3)",
             Description = "direct-declarator: direct-declarator [ type-qualifier-list_opt assignment-expression_opt ]",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_5)]
    public class DirectDeclarator_V3 : DirectDeclarator
    {
        DirectDeclarator DirectDeclarator;

        public const char OpenBracket = GrammarCConstants.BracketSquareLeft;
        TypeQualifierList? TypeQualifierList;
        AssignmentExpression? AssignmentExpression;
        public const char CloseBracket = GrammarCConstants.BracketSquareRight;

        public DirectDeclarator_V3(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "direct-declarator (variant 4)",
             Description = "direct-declarator: direct-declarator [ static type-qualifier-list_opt assignment-expression ]",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_5)]
    public class DirectDeclarator_V4 : DirectDeclarator
    {
        DirectDeclarator DirectDeclarator;

        public const char OpenBracket = GrammarCConstants.BracketSquareLeft;
        public const string StaticKeyword = GrammarCKeywords.Keyword_static;
        TypeQualifierList? TypeQualifierList;
        AssignmentExpression AssignmentExpression;
        public const char CloseBracket = GrammarCConstants.BracketSquareRight;

        public DirectDeclarator_V4(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "direct-declarator (variant 5)",
             Description = "direct-declarator: direct-declarator [ type-qualifier-list static assignment-expression ]",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_5)]
    public class DirectDeclarator_V5 : DirectDeclarator
    {
        DirectDeclarator DirectDeclarator;

        public const char OpenBracket = GrammarCConstants.BracketSquareLeft;        
        TypeQualifierList TypeQualifierList;
        public const string StaticKeyword = GrammarCKeywords.Keyword_static;
        AssignmentExpression AssignmentExpression;
        public const char CloseBracket = GrammarCConstants.BracketSquareRight;

        public DirectDeclarator_V5(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "direct-declarator (variant 6)",
             Description = "direct-declarator: direct-declarator [ type-qualifier-list_opt * ]",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_5)]
    public class DirectDeclarator_V6 : DirectDeclarator
    {
        DirectDeclarator DirectDeclarator;

        public const char OpenBracket = GrammarCConstants.BracketSquareLeft;
        TypeQualifierList? TypeQualifierList;
        public const char PointerChar = GrammarCConstants.Asterix;
        public const char CloseBracket = GrammarCConstants.BracketSquareRight;

        public DirectDeclarator_V6(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "direct-declarator (variant 7)",
             Description = "direct-declarator: direct-declarator ( parameter-type-list )",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_5)]
    public class DirectDeclarator_V7 : DirectDeclarator
    {
        DirectDeclarator DirectDeclarator;

        public const char OpenBracket = GrammarCConstants.BracketLeft;
        public ParameterTypeList ParameterTypeList;
        public const char CloseBracket = GrammarCConstants.BracketRight;

        public DirectDeclarator_V7(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "direct-declarator (variant 8)",
             Description = "direct-declarator: direct-declarator ( identifier-list_opt )",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_5)]
    public class DirectDeclarator_V8 : DirectDeclarator
    {
        DirectDeclarator DirectDeclarator;

        public const char OpenBracket = GrammarCConstants.BracketLeft;
        public IdentifierList? IdentifierList;
        public const char CloseBracket = GrammarCConstants.BracketRight;

        public DirectDeclarator_V8(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
