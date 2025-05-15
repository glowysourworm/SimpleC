using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    [Grammar(Name = "multiplicative-expression (base)",
             Description = "multiplicative-expression: (4 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_5)]
    public abstract class MultiplicativeExpression : GrammarBase
    {
        protected MultiplicativeExpression(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "multiplicative-expression (variant 1)",
             Description = "multiplicative-expression: cast-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_5)]
    public class MultiplicativeExpression_V1 : MultiplicativeExpression
    {
        CastExpression CastExpression;

        public MultiplicativeExpression_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "multiplicative-expression (variant 2)",
             Description = "multiplicative-expression: multiplicative-expression * cast-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_5)]
    public class MultiplicativeExpression_V2 : MultiplicativeExpression
    {
        MultiplicativeExpression MultiplicativeExpression;
        public const string MultiplicationOperator = GrammarCOperators.Multiplication;
        CastExpression CastExpression;

        public MultiplicativeExpression_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "multiplicative-expression (variant 3)",
             Description = "multiplicative-expression: multiplicative-expression / cast-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_5)]
    public class MultiplicativeExpression_V3 : MultiplicativeExpression
    {
        MultiplicativeExpression MultiplicativeExpression;
        public const string DivisionOperator = GrammarCOperators.Division;
        CastExpression CastExpression;

        public MultiplicativeExpression_V3(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "multiplicative-expression (variant 4)",
             Description = "multiplicative-expression: multiplicative-expression % cast-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_5)]
    public class MultiplicativeExpression_V4 : MultiplicativeExpression
    {
        MultiplicativeExpression MultiplicativeExpression;
        public const string ModuloOperator = GrammarCOperators.Modulo;
        CastExpression CastExpression;

        public MultiplicativeExpression_V4(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
