using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    [Grammar(Name = "expression (base)",
             Description = "expression: (2 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_17)]
    public abstract class Expression : GrammarBase
    {
        protected Expression(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "expression (variant 1)",
             Description = "expression: assignment-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_17)]
    public class Expression_V1 : Expression
    {
        AssignmentExpression AssignmentExpression;

        public Expression_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "expression (variant 2)",
             Description = "expression: expression , assignment-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_17)]
    public class Expression_V2 : Expression
    {
        Expression Expression;
        public const char CommaSeparator = GrammarCConstants.Comma;
        AssignmentExpression AssignmentExpression;

        public Expression_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
