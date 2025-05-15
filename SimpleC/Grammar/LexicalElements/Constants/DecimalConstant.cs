using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.LexicalElements.Identifiers;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    [Grammar(Name = "decimal-constant (base)",
             Description = "(base) decimal-constant: (2 variants)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_1)]
    public abstract class DecimalConstant : GrammarBase
    {
        public DecimalConstant(CodeRefBase codeRef) : base(codeRef) { }
    }

    [Grammar(Name = "decimal-constant (variant 1)",
             Description = "decimal-constant: nonzero-digit",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_1)]
    public class DecimalConstant_V1 : DecimalConstant
    {
        public NonZeroDigit NonZeroDigit;

        public DecimalConstant_V1(CodeRefBase codeRef) : base(codeRef) { }
    }

    [Grammar(Name = "decimal-constant (variant 2)",
             Description = "decimal-constant: decimal-constant digit",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_1)]
    public class DecimalConstant_V2 : DecimalConstant
    {
        public DecimalConstant DecimalConstant;
        public Digit Digit;

        public DecimalConstant_V2(CodeRefBase codeRef) : base(codeRef) { }
    }
}
