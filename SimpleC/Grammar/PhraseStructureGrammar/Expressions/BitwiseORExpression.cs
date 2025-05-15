using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    [Grammar(Name = "inclusive-OR-expression (base)",
             Description = "inclusive-OR-expression: (2 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_12)]
    public abstract class BitwiseORExpression : GrammarBase
    {
        protected BitwiseORExpression(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "inclusive-OR-expression (variant 1)",
             Description = "inclusive-OR-expression: exclusive-OR-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_12)]
    public class BitwiseORExpression_V1 : BitwiseORExpression
    {
        BitwiseXORExpression XORExpression;

        protected BitwiseORExpression_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "inclusive-OR-expression (variant 2)",
             Description = "inclusive-OR-expression: inclusive-OR-expression | exclusive-OR-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_12)]
    public class BitwiseORExpression_V2 : BitwiseORExpression
    {
        BitwiseORExpression ORExpression;
        public const string BitwiseOROperator = GrammarCOperators.BitwiseOR;
        BitwiseXORExpression XORExpression;

        protected BitwiseORExpression_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
