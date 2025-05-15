using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;
using SimpleC.Grammar.LexicalElements.Constants;

namespace SimpleC.Grammar.LexicalElements.UniversalCharacter
{
    [Grammar(Name = "hex-quad",
             Description = "hex-quad: hexadecimal-digit hexadecimal-digit hexadecimal-digit hexadecimal-digit",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_4,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_3)]
    public class HexQuad : HexadecimalDigit
    {
        public HexadecimalDigit HexadecimalDigit1;
        public HexadecimalDigit HexadecimalDigit2;
        public HexadecimalDigit HexadecimalDigit3;
        public HexadecimalDigit HexadecimalDigit4;

        public HexQuad(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
