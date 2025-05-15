using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    [Grammar(Name = "hexadecimal-digit-sequence (base)",
             Description = "hexadecimal-digit-sequence: (2 variants)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_2)]
    public abstract class HexadecimalDigitSequence : GrammarBase
    {
        protected HexadecimalDigitSequence(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "hexadecimal-digit-sequence (variant 1)",
             Description = "hexadecimal-digit-sequence: hexadecimal-digit",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_2)]
    public class HexadecimalDigitSequence_V1 : HexadecimalDigitSequence
    {
        public HexadecimalDigit HexadecimalDigit;

        public HexadecimalDigitSequence_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "hexadecimal-digit-sequence (variant 2)",
             Description = "hexadecimal-digit-sequence: hexadecimal-digit-sequence hexadecimal-digit",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_2)]
    public class HexadecimalDigitSequence_V2 : HexadecimalDigitSequence
    {
        public HexadecimalDigitSequence HexadecimalDigitSequence;
        public HexadecimalDigit HexadecimalDigit;

        public HexadecimalDigitSequence_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
