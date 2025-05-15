using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    [Grammar(Name = "hexadecimal-floating-constant (base)",
             Description = "hexadecimal-floating-constant: (2 variants)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_2)]
    public abstract class HexadecimalFloatingConstant : GrammarBase
    {
        protected HexadecimalFloatingConstant(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "hexadecimal-floating-constant (variant 1)",
             Description = "hexadecimal-floating-constant: hexadecimal-prefix hexadecimal-fractional-constant binary-exponent-part floating-suffix_opt",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_2)]
    public class HexadecimalFloatingConstant_V1 : HexadecimalFloatingConstant
    {
        public HexadecimalPrefix HexadecimalPrefix;
        public HexadecimalFractionalConstant HexadecimalFractionalConstant;
        public BinaryExponentPart BinaryExponentPart;
        public FloatingSuffix? FloatingSuffix;

        public HexadecimalFloatingConstant_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "hexadecimal-floating-constant (variant 2)",
             Description = "hexadecimal-floating-constant: hexadecimal-prefix hexadecimal-digit-sequence binary-exponent-part floating-suffix_opt",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_2)]
    public class HexadecimalFloatingConstant_V2 : HexadecimalFloatingConstant
    {
        public HexadecimalPrefix HexadecimalPrefix;
        public HexadecimalDigitSequence HexadecimalDigitSequence;
        public BinaryExponentPart BinaryExponentPart;
        public FloatingSuffix? FloatingSuffix;

        public HexadecimalFloatingConstant_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
