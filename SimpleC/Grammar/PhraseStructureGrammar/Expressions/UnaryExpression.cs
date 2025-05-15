using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.PhraseStructureGrammar.Declarations;

namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    [Grammar(Name = "unary-expression (base)",
             Description = "unary-expression: (6 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_3)]
    public abstract class UnaryExpression : GrammarConstant
    {
        protected UnaryExpression(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "unary-expression (variant 1)",
             Description = "unary-expression: postfix-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_3)]
    public class UnaryExpression_V1 : UnaryExpression
    {
        PostfixExpression PostfixExpression;

        public UnaryExpression_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "unary-expression (variant 2)",
             Description = "unary-expression: ++ unary-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_3)]
    public class UnaryExpression_V2 : UnaryExpression
    {
        public const string IncrementPrefix = GrammarCOperators.Increment;
        UnaryExpression UnaryExpression;

        public UnaryExpression_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "unary-expression (variant 3)",
             Description = "unary-expression: -- unary-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_3)]
    public class UnaryExpression_V3 : UnaryExpression
    {
        public const string DecrementPrefix = GrammarCOperators.Decrement;
        UnaryExpression UnaryExpression;

        public UnaryExpression_V3(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "unary-expression (variant 4)",
             Description = "unary-expression: unary-operator cast-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_3)]
    public class UnaryExpression_V4 : UnaryExpression
    {
        public UnaryOperator UnaryOperator;
        public CastExpression CastExpression;

        public UnaryExpression_V4(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "unary-expression (variant 5)",
             Description = "unary-expression: sizeof unary-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_3)]
    public class UnaryExpression_V5 : UnaryExpression
    {
        public const string SizeofKeyword = GrammarCKeywords.Keyword_sizeof;
        UnaryExpression UnaryExpression;

        public UnaryExpression_V5(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "unary-expression (variant 6)",
             Description = "unary-expression: sizeof ( type-name )",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_3)]
    public class UnaryExpression_V6 : UnaryExpression
    {
        public const string SizeofKeyword = GrammarCKeywords.Keyword_sizeof;
        public const char TypeNameOpenBracket = GrammarCConstants.BracketLeft;
        TypeName TypeName;
        public const char TypeNameCloseBracket = GrammarCConstants.BracketRight;

        public UnaryExpression_V6(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
