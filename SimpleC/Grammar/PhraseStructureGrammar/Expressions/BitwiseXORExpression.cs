using SimpleC.Base.Standard;
using SimpleC.Code.Attribute;
using SimpleC.Code;

namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    [Grammar(Name = "exclusive-OR-expression (base)",
             Description = "exclusive-OR-expression: (2 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_11)]
    public abstract class BitwiseXORExpression : GrammarBase
    {
        protected BitwiseXORExpression(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "exclusive-OR-expression (variant 1)",
             Description = "exclusive-OR-expression: AND-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_11)]
    public class BitwiseXORExpression_V1 : BitwiseXORExpression
    {
        BitwiseANDExpression ANDExpression;

        public BitwiseXORExpression_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "exclusive-OR-expression (variant 2)",
             Description = "exclusive-OR-expression: exclusive-OR-expression ^ AND-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_11)]
    public class BitwiseXORExpression_V2 : BitwiseXORExpression
    {
        BitwiseXORExpression XORExpression;
        public const string BitwiseXOROperator = GrammarCOperators.BitwiseXOR;
        BitwiseANDExpression ANDExpression;

        public BitwiseXORExpression_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
