using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    [Grammar(Name = "additive-expression (base)",
             Description = "additive-expression: (3 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_6)]
    public abstract class AdditiveExpression : GrammarBase
    {
        protected AdditiveExpression(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "additive-expression (variant 1)",
             Description = "additive-expression: multiplicative-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_6)]
    public class AdditiveExpression_V1 : AdditiveExpression
    {
        MultiplicativeExpression MultiplicativeExpression;

        public AdditiveExpression_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "additive-expression (variant 2)",
             Description = "additive-expression: additive-expression + multiplicative-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_6)]
    public class AdditiveExpression_V2 : AdditiveExpression
    {
        AdditiveExpression AdditiveExpression;
        public const string AdditionOperator = GrammarCOperators.Addition;
        MultiplicativeExpression MultiplicativeExpression;

        public AdditiveExpression_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "additive-expression (variant 3)",
             Description = "additive-expression: additive-expression - multiplicative-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_6)]
    public class AdditiveExpression_V3 : AdditiveExpression
    {
        AdditiveExpression AdditiveExpression;
        public const string SubtractionOperator = GrammarCOperators.Subtraction;
        MultiplicativeExpression MultiplicativeExpression;

        public AdditiveExpression_V3(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
