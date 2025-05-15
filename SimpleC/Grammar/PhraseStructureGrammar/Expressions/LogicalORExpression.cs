using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    [Grammar(Name = "logical-OR-expression (base)",
             Description = "logical-OR-expression: (2 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_14)]
    public abstract class LogicalORExpression : GrammarBase
    {
        protected LogicalORExpression(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "logical-OR-expression (variant 1)",
             Description = "logical-OR-expression: logical-AND-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_14)]
    public class LogicalORExpression_V1 : LogicalORExpression
    {
        LogicalANDExpression LogicalANDExpression;

        public LogicalORExpression_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "logical-OR-expression (variant 2)",
             Description = "logical-OR-expression: logical-OR-expression || logical-AND-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_14)]
    public class LogicalORExpression_V2 : LogicalORExpression
    {
        LogicalORExpression LogicalORExpression;
        public const string LogicalOROperator = GrammarCOperators.LogicalOR;
        LogicalANDExpression LogicalANDExpression;

        public LogicalORExpression_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
