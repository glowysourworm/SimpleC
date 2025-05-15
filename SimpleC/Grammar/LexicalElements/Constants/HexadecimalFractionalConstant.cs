using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    [Grammar(Name = "hexadecimal-fractional-constant (base)",
             Description = "hexadecimal-fractional-constant: (2 variants)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_2)]
    public abstract class HexadecimalFractionalConstant : GrammarBase
    {
        protected HexadecimalFractionalConstant(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "hexadecimal-fractional-constant (variant 1)",
             Description = "hexadecimal-fractional-constant: hexadecimal-digit-sequence_opt . hexadecimal-digit-sequence",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_2)]
    public class HexadecimalFractionalConstant_V1 : GrammarBase
    {
        public HexadecimalDigitSequence? HexadecimalDigitSequence1;
        public const char PeriodSeparator = GrammarCConstants.Period;
        public HexadecimalDigitSequence HexadecimalDigitSequence2;

        public HexadecimalFractionalConstant_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "hexadecimal-fractional-constant (variant 2)",
             Description = "hexadecimal-fractional-constant: hexadecimal-digit-sequence .",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_2)]
    public class HexadecimalFractionalConstant_V2 : GrammarBase
    {
        public HexadecimalDigitSequence HexadecimalDigitSequence;
        public const char PeriodSeparator = GrammarCConstants.Period;

        public HexadecimalFractionalConstant_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
