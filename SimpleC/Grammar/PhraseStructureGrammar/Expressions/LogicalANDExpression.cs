using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    [Grammar(Name = "logical-AND-expression (base)",
             Description = "logical-AND-expression: (2 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_13)]
    public abstract class LogicalANDExpression : GrammarBase
    {
        protected LogicalANDExpression(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "logical-AND-expression (variant 1)",
             Description = "logical-AND-expression: inclusive-OR-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_13)]
    public class LogicalANDExpression_V1 : LogicalANDExpression
    {
        BitwiseORExpression ORExpression;

        public LogicalANDExpression_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "logical-AND-expression (variant 2)",
             Description = "logical-AND-expression: logical-AND-expression && inclusive-OR-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_13)]
    public class LogicalANDExpression_V2 : LogicalANDExpression
    {
        LogicalANDExpression LogicalANDExpression;
        public const string LogicalANDOperator = GrammarCOperators.LogicalAND;
        BitwiseORExpression ORExpression;

        public LogicalANDExpression_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
