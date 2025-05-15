using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    [Grammar(Name = "assignment-expression (base)",
             Description = "assigment-expression: (2 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_16)]
    public abstract class AssignmentExpression : GrammarBase
    {
        protected AssignmentExpression(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "assignment-expression (variant 1)",
             Description = "assigment-expression: conditional-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_16)]
    public class AssignmentExpression_V1 : AssignmentExpression
    {
        ConditionalExpression ConditionalExpression;

        public AssignmentExpression_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "assignment-expression (variant 2)",
             Description = "assigment-expression: unary-expression assignment-operator assignment-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_16)]
    public class AssignmentExpression_V2 : AssignmentExpression
    {
        UnaryExpression UnaryExpression;
        AssignmentOperator AssignmentOperator;
        AssignmentExpression AssignmentExpression;

        public AssignmentExpression_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
