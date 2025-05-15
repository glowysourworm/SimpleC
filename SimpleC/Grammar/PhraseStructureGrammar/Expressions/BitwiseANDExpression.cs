using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    [Grammar(Name = "AND-expression (base)",
             Description = "AND-expression: (2 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_10)]
    public abstract class BitwiseANDExpression : GrammarBase
    {
        protected BitwiseANDExpression(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "AND-expression (variant 1)",
             Description = "AND-expression: equality-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_10)]
    public class BitwiseANDExpression_V1 : BitwiseANDExpression
    {
        EqualityExpression EqualityExpression;

        public BitwiseANDExpression_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "AND-expression (variant 2)",
             Description = "AND-expression: AND-expression & equality-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_10)]
    public class BitwiseANDExpression_V2 : BitwiseANDExpression
    {
        BitwiseANDExpression ANDExpression;
        public const string BitwiseANDOperator = GrammarCOperators.BitwiseAND;
        EqualityExpression EqualityExpression;

        public BitwiseANDExpression_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
