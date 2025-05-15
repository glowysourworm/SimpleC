using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    [Grammar(Name = "hexadecimal-escape-sequence (base)",
             Description = "hexadecimal-escape-sequence: (2 variants)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_4)]
    public abstract class HexadecimalEscapeSequence : GrammarBase
    {
        protected HexadecimalEscapeSequence(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "hexadecimal-escape-sequence (variant 1)",
             Description = "hexadecimal-escape-sequence: \\x hexadecimal-digit",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_4)]
    public class HexadecimalEscapeSequence_V1 : HexadecimalEscapeSequence
    {
        public const string EscapePrefix = GrammarCEscapeSequences.HexadecimalEscape;
        HexadecimalDigit HexadecimalDigit;

        public HexadecimalEscapeSequence_V1(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }

    [Grammar(Name = "hexadecimal-escape-sequence (variant 2)",
             Description = "hexadecimal-escape-sequence: hexadecimal-escape-sequence hexadecimal-digit",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_4)]
    public class HexadecimalEscapeSequence_V2 : HexadecimalEscapeSequence
    {
        HexadecimalDigitSequence HexadecimalDigitSequence;
        HexadecimalDigit HexadecimalDigit;

        public HexadecimalEscapeSequence_V2(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
