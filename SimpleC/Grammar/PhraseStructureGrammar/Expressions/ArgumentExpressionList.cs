using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    [Grammar(Name = "argument-expression-list (base)",
             Description = "argument-expression-list: (2 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_2)]
    public abstract class ArgumentExpressionList : GrammarBase
    {
        protected ArgumentExpressionList(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "argument-expression-list (variant 1)",
             Description = "argument-expression-list: assignment-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_2)]
    public class ArgumentExpressionList_V1 : ArgumentExpressionList
    {
        AssignmentExpression AssignmentExpression;

        public ArgumentExpressionList_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "argument-expression-list (variant 2)",
             Description = "argument-expression-list: argument-expression-list , assignment-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_2)]
    public class ArgumentExpressionList_V2 : ArgumentExpressionList
    {
        ArgumentExpressionList ArgumentExpressionList;
        public const char CommaSeparator = GrammarCConstants.Comma;
        AssignmentExpression AssignmentExpression;

        public ArgumentExpressionList_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
