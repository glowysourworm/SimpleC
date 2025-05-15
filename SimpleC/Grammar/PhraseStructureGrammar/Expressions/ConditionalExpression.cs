using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    [Grammar(Name = "conditional-expression (base)",
             Description = "conditional-expression: (2 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_15)]
    public abstract class ConditionalExpression : GrammarBase
    {
        protected ConditionalExpression(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "conditional-expression (variant 1)",
             Description = "conditional-expression: logical-OR-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_15)]
    public class ConditionalExpression_V1 : ConditionalExpression
    {
        public LogicalORExpression LogicalORExpression;

        public ConditionalExpression_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "conditional-expression (variant 2)",
             Description = "conditional-expression: logical-OR-expression ? expression : conditional-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_15)]
    public class ConditionalExpression_V2 : ConditionalExpression
    {
        LogicalORExpression LogicalORExpression;
        public const string TertiaryBranchOperatorQuestionMark = GrammarCOperators.TertiaryIfThenQuestionMark;
        Expression Expression;
        public const string TertiaryBranchOperatorColon = GrammarCOperators.TertiaryIfThenColon;
        ConditionalExpression ConditionalExpression;

        public ConditionalExpression_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
