using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.PhraseStructureGrammar.Expressions;

namespace SimpleC.Grammar.PhraseStructureGrammar.Declarations
{
    [Grammar(Name = "direct-abstract-declarator (base)",
             Description = "direct-abstract-declarator: (6 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_6)]
    public abstract class DirectAbstractDeclarator : GrammarBase
    {
        protected DirectAbstractDeclarator(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "direct-abstract-declarator (variant 1)",
             Description = "direct-abstract-declarator: ( abstract-declarator )",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_6)]
    public class DirectAbstractDeclarator_V1 : DirectAbstractDeclarator
    {
        public const char AbstractDeclaratorBracketOpen = GrammarCConstants.BracketLeft;
        AbstractDeclarator AbstractDeclarator;
        public const char AbstractDeclaratorBracketClose = GrammarCConstants.BracketRight;

        public DirectAbstractDeclarator_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "direct-abstract-declarator (variant 2)",
             Description = "direct-abstract-declarator: direct-abstract-declarator_opt [ type-qualifier-list_opt assignment-expression_opt ]",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_6)]
    public class DirectAbstractDeclarator_V2 : DirectAbstractDeclarator
    {
        DirectAbstractDeclarator? DirectAbstractDeclarator;
        public const char DeclaratorBracketOpen = GrammarCConstants.BracketSquareLeft;
        TypeQualifierList? TypeQualifierList;
        AssignmentExpression? AssignmentExpression;
        public const char DeclaratorBracketClose = GrammarCConstants.BracketSquareRight;

        public DirectAbstractDeclarator_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "direct-abstract-declarator (variant 3)",
             Description = "direct-abstract-declarator: direct-abstract-declarator_opt [ static type-qualifier-list_opt assignment-expression ]",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_6)]
    public class DirectAbstractDeclarator_V3 : DirectAbstractDeclarator
    {
        DirectAbstractDeclarator? DirectAbstractDeclarator;
        public const char DeclaratorBracketOpen = GrammarCConstants.BracketSquareLeft;
        public const string StaticKeyword = GrammarCKeywords.Keyword_static;
        TypeQualifierList? TypeQualifierList;
        AssignmentExpression AssignmentExpression;
        public const char DeclaratorBracketClose = GrammarCConstants.BracketSquareRight;

        public DirectAbstractDeclarator_V3(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "direct-abstract-declarator (variant 4)",
             Description = "direct-abstract-declarator: direct-abstract-declarator_opt [ type-qualifier-list static assignment-expression ]",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_6)]
    public class DirectAbstractDeclarator_V4 : DirectAbstractDeclarator
    {
        DirectAbstractDeclarator? DirectAbstractDeclarator;
        public const char DeclaratorBracketOpen = GrammarCConstants.BracketSquareLeft;
        TypeQualifierList TypeQualifierList;
        public const string StaticKeyword = GrammarCKeywords.Keyword_static;
        AssignmentExpression AssignmentExpression;
        public const char DeclaratorBracketClose = GrammarCConstants.BracketSquareRight;

        public DirectAbstractDeclarator_V4(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "direct-abstract-declarator (variant 5)",
             Description = "direct-abstract-declarator: direct-abstract-declarator_opt [ * ]",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_6)]
    public class DirectAbstractDeclarator_V5 : DirectAbstractDeclarator
    {
        DirectAbstractDeclarator? DirectAbstractDeclarator;
        public const char DeclaratorBracketOpen = GrammarCConstants.BracketSquareLeft;
        public const char PointerOperator = GrammarCConstants.Asterix;
        public const char DeclaratorBracketClose = GrammarCConstants.BracketSquareRight;

        public DirectAbstractDeclarator_V5(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "direct-abstract-declarator (variant 6)",
             Description = "direct-abstract-declarator: direct-abstract-declarator_opt ( parameter-type-list_opt )",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_2,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_7_6)]
    public class DirectAbstractDeclarator_V6 : DirectAbstractDeclarator
    {
        DirectAbstractDeclarator? DirectAbstractDeclarator;
        public const char DeclaratorBracketOpen = GrammarCConstants.BracketLeft;
        ParameterTypeList? ParameterTypeList;
        public const char DeclaratorBracketClose = GrammarCConstants.BracketRight;

        public DirectAbstractDeclarator_V6(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
