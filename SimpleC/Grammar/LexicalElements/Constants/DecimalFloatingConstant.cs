using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    [Grammar(Name = "decimal-floating-constant (base)",
             Description = "decimal-floating-constant: (2 variants)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_2)]
    public abstract class DecimalFloatingConstant : GrammarBase
    {
        protected DecimalFloatingConstant(CodeRefBase codeRef) : base(codeRef){}
    }

    [Grammar(Name = "decimal-floating-constant (variant 1)",
             Description = "decimal-floating-constant: fractional-constant exponent-part_opt floating-suffix_opt",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_2)]
    public class DecimalFloatingConstant_V1 : DecimalFloatingConstant
    {
        public FractionalConstant FractionalConstant;
        public ExponentPart? ExponentPart;
        public FloatingSuffix? FloatingSuffix;

        public DecimalFloatingConstant_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "decimal-floating-constant (variant 2)",
             Description = "decimal-floating-constant: digit-sequence exponent-part floating-suffix_opt",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_2)]
    public class DecimalFloatingConstant_V2 : DecimalFloatingConstant
    {
        public DigitSequence DigitSequence;
        public ExponentPart ExponentPart;
        public FloatingSuffix? FloatingSuffix;

        public DecimalFloatingConstant_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
