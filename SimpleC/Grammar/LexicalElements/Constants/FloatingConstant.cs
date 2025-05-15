using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    [Grammar(Name = "floating-constant (base)",
             Description = "floating-constant: (2 variants)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_2)]
    public abstract class FloatingConstant : GrammarBase
    {
        public FloatingConstant(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "floating-constant (variant 1)",
             Description = "floating-constant: decimal-floating-constant",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_2)]
    public class FloatingConstant_V1 : FloatingConstant
    {
        public DecimalFloatingConstant DecimalFloatingConstant;

        public FloatingConstant_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "floating-constant (variant 2)",
             Description = "floating-constant: hexadecimal-floating-constant",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_2)]
    public class FloatingConstant_V2 : FloatingConstant
    {
        public HexadecimalFloatingConstant HexadecimalFloatingConstant;

        public FloatingConstant_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
