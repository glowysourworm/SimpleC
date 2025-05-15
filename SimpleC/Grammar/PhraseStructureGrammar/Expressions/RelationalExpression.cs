using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    [Grammar(Name = "relational-expression (base)",
             Description = "relational-expression: (5 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_8)]
    public abstract class RelationalExpression : GrammarBase
    {
        protected RelationalExpression(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "relational-expression (variant 1)",
             Description = "relational-expression: shift-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_8)]
    public class RelationalExpression_V1 : RelationalExpression
    {
        ShiftExpression ShiftExpression;

        public RelationalExpression_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "relational-expression (variant 2)",
             Description = "relational-expression: relational-expression < shift-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_8)]
    public class RelationalExpression_V2 : RelationalExpression
    {
        RelationalExpression RelationalExpression;
        public const string LessThanOperator = GrammarCOperators.LessThan;
        ShiftExpression ShiftExpression;    

        public RelationalExpression_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "relational-expression (variant 3)",
             Description = "relational-expression: relational-expression > shift-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_8)]
    public class RelationalExpression_V3 : RelationalExpression
    {
        RelationalExpression RelationalExpression;
        public const string GreaterThanOperator = GrammarCOperators.GreaterThan;
        ShiftExpression ShiftExpression;

        public RelationalExpression_V3(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "relational-expression (variant 4)",
             Description = "relational-expression: relational-expression <= shift-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_8)]
    public class RelationalExpression_V4 : RelationalExpression
    {
        RelationalExpression RelationalExpression;
        public const string LessThanOrEqualToOperator = GrammarCOperators.LessThanOrEqualTo;
        ShiftExpression ShiftExpression;

        public RelationalExpression_V4(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "relational-expression (variant 5)",
             Description = "relational-expression: relational-expression >= shift-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_8)]
    public class RelationalExpression_V5 : RelationalExpression
    {
        RelationalExpression RelationalExpression;
        public const string GreaterThanOrEqualToOperator = GrammarCOperators.GreaterThanOrEqualTo;
        ShiftExpression ShiftExpression;

        public RelationalExpression_V5(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
