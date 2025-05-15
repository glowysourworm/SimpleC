using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    [Grammar(Name = "equality-expression (base)",
             Description = "equality-expression: (3 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_9)]
    public abstract class EqualityExpression : GrammarBase
    {
        protected EqualityExpression(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "equality-expression (variant 1)",
             Description = "equality-expression: relational-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_9)]
    public class EqualityExpression_V1 : EqualityExpression
    {
        RelationalExpression RelationalExpression;

        public EqualityExpression_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "equality-expression (variant 2)",
             Description = "equality-expression: equality-expression == relational-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_9)]
    public class EqualityExpression_V2 : EqualityExpression
    {
        EqualityExpression EqualityExpression;
        public const string EqualityOperator = GrammarCOperators.Equality;
        RelationalExpression RelationalExpression;

        public EqualityExpression_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "equality-expression (variant 3)",
             Description = "equality-expression: equality-expression != relational-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_9)]
    public class EqualityExpression_V3 : EqualityExpression
    {
        EqualityExpression EqualityExpression;
        public const string EqualityNOTOperator = GrammarCOperators.EqualityNOT;
        RelationalExpression RelationalExpression;

        public EqualityExpression_V3(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
