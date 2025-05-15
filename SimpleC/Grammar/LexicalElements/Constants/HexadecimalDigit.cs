using Microsoft.Win32.SafeHandles;

using SimpleC.Base.Standard;
using SimpleC.Code;
using SimpleC.Code.Attribute;

namespace SimpleC.Grammar.LexicalElements.Constants
{
    [Grammar(Name = "hexadecimal-digit",
             Description = "hexadecimal-digit: one of (...)",
             Section = ISOCStandardAnnexSection.A_1,
             SubSection = ISOCStandardAnnexSubSection.A_1_5,
             SubSectionChapter = ISOCStandardAnnexSubSectionChapter.s6_4_4_1)]
    public class HexadecimalDigit : GrammarConstant
    {
        // ONE OF: 0 1 2 3 4 5 6 7 8 9 a b c d e f A B C D E F
        public HexadecimalDigit(CodeRefBase codeRef) : base(codeRef)
        {
        }
    }
}
