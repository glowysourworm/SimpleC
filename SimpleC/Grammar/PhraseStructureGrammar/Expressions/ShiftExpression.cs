using SimpleC.Base.Standard;
using SimpleC.Code.Attribute;
using SimpleC.Code;

namespace SimpleC.Grammar.PhraseStructureGrammar.Expressions
{
    [Grammar(Name = "shift-expression (base)",
             Description = "shift-expression: (3 variants)",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_7)]
    public abstract class ShiftExpression : GrammarBase
    {
        protected ShiftExpression(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "shift-expression (variant 1)",
             Description = "shift-expression: additive-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_7)]
    public class ShiftExpression_V1 : ShiftExpression
    {
        AdditiveExpression AdditiveExpression;

        public ShiftExpression_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "shift-expression (variant 2)",
             Description = "shift-expression: shift-expression << additive-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_7)]
    public class ShiftExpression_V2 : ShiftExpression
    {
        ShiftExpression ShiftExpression;
        public const string BitwiseLeftShiftOperator = GrammarCOperators.BitwiseLeftShift;
        AdditiveExpression AdditiveExpression;

        public ShiftExpression_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }


    [Grammar(Name = "shift-expression (variant 3)",
             Description = "shift-expression: shift-expression >> additive-expression",
             Section = ISOCStandardAnnexSection.A_2,
             SubSection = ISOCStandardAnnexSubSection.A_2_1,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_5_7)]
    public class ShiftExpression_V3 : ShiftExpression
    {
        ShiftExpression ShiftExpression;
        public const string BitwiseRightShiftOperator = GrammarCOperators.BitwiseRightShift;
        AdditiveExpression AdditiveExpression;

        public ShiftExpression_V3(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
